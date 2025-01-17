﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Controllers
{
    public class AccountController
    {
        public static async Task<Models.OAuth> GetLoginToken(string username, string password)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("grant_type", "password");
            dict.Add("username",username);
            dict.Add("password", EncryptSHA256(password));
  

            using (HttpClient http = new HttpClient())
            {
                var data = new HttpRequestMessage(HttpMethod.Post, $"http://{Properties.DB_HOST}:8080/oauth/token");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("yugiohjwtclientid:XY7kmzoNzl100"));
                data.Headers.Add("Authorization", $"Basic {base64authorization}");
                

                data.Content = new FormUrlEncodedContent(dict);
                var response = await http.SendAsync(data).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode) throw new Exception(await response.Content.ReadAsStringAsync());
                try
                {
                    return JsonConvert.DeserializeObject<Models.OAuth>(await response.Content.ReadAsStringAsync());
                }
                catch (JsonSerializationException e)
                {
                    Debug.WriteLine(e.Message);
                }
            }

            return null;
        }

        public static async Task GetRegistrationCode(string username, string password)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("username", username);
            dict.Add("password", EncryptSHA256(password));


            using (HttpClient http = new HttpClient())
            {
                var data = new HttpRequestMessage(HttpMethod.Post, $"http://{Properties.DB_HOST}:8080/api/account/register");

                var json = JsonConvert.SerializeObject(dict);

                data.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await http.SendAsync(data).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode) throw new Exception(await response.Content.ReadAsStringAsync());
            }

        }

        public static string EncryptSHA256(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
                return string.Join("", bytes.ToList().Select(b => b.ToString("x2"))); 
            }
        }
    }
}
