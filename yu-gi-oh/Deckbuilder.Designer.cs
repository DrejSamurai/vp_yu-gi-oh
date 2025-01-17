﻿
namespace yu_gi_oh
{
    partial class Deckbuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deckbuilder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeck = new System.Windows.Forms.DataGridView();
            this.loadingPB = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnSaveDeck = new System.Windows.Forms.Button();
            this.btnNewDeck = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddtoDeck = new System.Windows.Forms.Button();
            this.btnRemoveFromDeck = new System.Windows.Forms.Button();
            this.btnOpenDeck = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.SelectedCardGB = new System.Windows.Forms.GroupBox();
            this.gbCardFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.nudDEF = new System.Windows.Forms.NumericUpDown();
            this.nudATK = new System.Windows.Forms.NumericUpDown();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnumberofcardsinDeck = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblcurr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.SelectedCardGB.SuspendLayout();
            this.gbCardFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudATK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.BackgroundImage = global::yu_gi_oh.Properties.Resources.link_wizard__bg__by_alanmac95_dcbum43_250t;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgvDeck);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Deck";
            // 
            // dgvDeck
            // 
            this.dgvDeck.AllowUserToAddRows = false;
            this.dgvDeck.AllowUserToDeleteRows = false;
            this.dgvDeck.AllowUserToResizeColumns = false;
            this.dgvDeck.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvDeck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDeck.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeck.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeck.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDeck.Location = new System.Drawing.Point(7, 22);
            this.dgvDeck.MultiSelect = false;
            this.dgvDeck.Name = "dgvDeck";
            this.dgvDeck.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeck.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeck.RowHeadersVisible = false;
            this.dgvDeck.RowTemplate.Height = 25;
            this.dgvDeck.Size = new System.Drawing.Size(701, 463);
            this.dgvDeck.TabIndex = 0;
            this.dgvDeck.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeck_CellClick);
            // 
            // loadingPB
            // 
            this.loadingPB.AccessibleName = "";
            this.loadingPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loadingPB.BackColor = System.Drawing.SystemColors.Window;
            this.loadingPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadingPB.ErrorImage = null;
            this.loadingPB.Image = global::yu_gi_oh.Properties.Resources.loading;
            this.loadingPB.Location = new System.Drawing.Point(6, 28);
            this.loadingPB.Name = "loadingPB";
            this.loadingPB.Size = new System.Drawing.Size(738, 458);
            this.loadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingPB.TabIndex = 5;
            this.loadingPB.TabStop = false;
            this.loadingPB.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.BackgroundImage = global::yu_gi_oh.Properties.Resources.link_wizard__bg__by_alanmac95_dcbum43_250t;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.loadingPB);
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(755, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 492);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Cards";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(6, 22);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(738, 464);
            this.dgv1.TabIndex = 15;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // btnSaveDeck
            // 
            this.btnSaveDeck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDeck.Location = new System.Drawing.Point(105, 754);
            this.btnSaveDeck.Name = "btnSaveDeck";
            this.btnSaveDeck.Size = new System.Drawing.Size(127, 33);
            this.btnSaveDeck.TabIndex = 7;
            this.btnSaveDeck.Text = "Save Deck";
            this.btnSaveDeck.UseVisualStyleBackColor = false;
            this.btnSaveDeck.Click += new System.EventHandler(this.btnSaveDeck_Click);
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewDeck.Location = new System.Drawing.Point(420, 754);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(127, 33);
            this.btnNewDeck.TabIndex = 8;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.UseVisualStyleBackColor = false;
            this.btnNewDeck.Click += new System.EventHandler(this.btnNewDeck_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(1713, 784);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 33);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddtoDeck
            // 
            this.btnAddtoDeck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddtoDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddtoDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddtoDeck.Location = new System.Drawing.Point(878, 163);
            this.btnAddtoDeck.Name = "btnAddtoDeck";
            this.btnAddtoDeck.Size = new System.Drawing.Size(173, 53);
            this.btnAddtoDeck.TabIndex = 11;
            this.btnAddtoDeck.Text = "Add to deck";
            this.btnAddtoDeck.UseVisualStyleBackColor = false;
            this.btnAddtoDeck.Click += new System.EventHandler(this.btnAddtoDeck_Click);
            // 
            // btnRemoveFromDeck
            // 
            this.btnRemoveFromDeck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveFromDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveFromDeck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromDeck.Location = new System.Drawing.Point(1057, 164);
            this.btnRemoveFromDeck.Name = "btnRemoveFromDeck";
            this.btnRemoveFromDeck.Size = new System.Drawing.Size(173, 53);
            this.btnRemoveFromDeck.TabIndex = 12;
            this.btnRemoveFromDeck.Text = "Remove from deck";
            this.btnRemoveFromDeck.UseVisualStyleBackColor = false;
            this.btnRemoveFromDeck.Click += new System.EventHandler(this.btnRemoveFromDeck_Click);
            // 
            // btnOpenDeck
            // 
            this.btnOpenDeck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDeck.Location = new System.Drawing.Point(254, 754);
            this.btnOpenDeck.Name = "btnOpenDeck";
            this.btnOpenDeck.Size = new System.Drawing.Size(127, 33);
            this.btnOpenDeck.TabIndex = 14;
            this.btnOpenDeck.Text = "Open Deck";
            this.btnOpenDeck.UseVisualStyleBackColor = false;
            this.btnOpenDeck.Click += new System.EventHandler(this.btnOpenDeck_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPreviousPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreviousPage.Enabled = false;
            this.btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousPage.Location = new System.Drawing.Point(1057, 750);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(59, 40);
            this.btnPreviousPage.TabIndex = 16;
            this.btnPreviousPage.Text = "<<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextPage.Location = new System.Drawing.Point(1144, 750);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(54, 40);
            this.btnNextPage.TabIndex = 17;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pbCardImage
            // 
            this.pbCardImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCardImage.BackgroundImage = global::yu_gi_oh.Properties.Resources.wp2866512;
            this.pbCardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCardImage.Enabled = false;
            this.pbCardImage.Location = new System.Drawing.Point(36, 32);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(190, 229);
            this.pbCardImage.TabIndex = 18;
            this.pbCardImage.TabStop = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbDescription.Location = new System.Drawing.Point(19, 267);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(225, 247);
            this.rtbDescription.TabIndex = 19;
            this.rtbDescription.Text = "";
            // 
            // SelectedCardGB
            // 
            this.SelectedCardGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectedCardGB.BackgroundImage = global::yu_gi_oh.Properties.Resources.link_wizard__bg__by_alanmac95_dcbum43_250t;
            this.SelectedCardGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectedCardGB.Controls.Add(this.pbCardImage);
            this.SelectedCardGB.Controls.Add(this.rtbDescription);
            this.SelectedCardGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCardGB.Location = new System.Drawing.Point(1559, 44);
            this.SelectedCardGB.Name = "SelectedCardGB";
            this.SelectedCardGB.Size = new System.Drawing.Size(260, 538);
            this.SelectedCardGB.TabIndex = 20;
            this.SelectedCardGB.TabStop = false;
            this.SelectedCardGB.Text = "Selected Card Info";
            // 
            // gbCardFilter
            // 
            this.gbCardFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCardFilter.BackgroundImage = global::yu_gi_oh.Properties.Resources.link_wizard__bg__by_alanmac95_dcbum43_250t;
            this.gbCardFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCardFilter.Controls.Add(this.btnResetFilter);
            this.gbCardFilter.Controls.Add(this.btnFilter);
            this.gbCardFilter.Controls.Add(this.nudDEF);
            this.gbCardFilter.Controls.Add(this.nudATK);
            this.gbCardFilter.Controls.Add(this.cbCardType);
            this.gbCardFilter.Controls.Add(this.tbCardName);
            this.gbCardFilter.Controls.Add(this.label4);
            this.gbCardFilter.Controls.Add(this.label3);
            this.gbCardFilter.Controls.Add(this.label2);
            this.gbCardFilter.Controls.Add(this.label1);
            this.gbCardFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCardFilter.Location = new System.Drawing.Point(296, 45);
            this.gbCardFilter.Name = "gbCardFilter";
            this.gbCardFilter.Size = new System.Drawing.Size(1209, 112);
            this.gbCardFilter.TabIndex = 21;
            this.gbCardFilter.TabStop = false;
            this.gbCardFilter.Text = "Available Card Filter";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetFilter.Location = new System.Drawing.Point(1074, 42);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(125, 40);
            this.btnResetFilter.TabIndex = 10;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(943, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(125, 40);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // nudDEF
            // 
            this.nudDEF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudDEF.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDEF.Location = new System.Drawing.Point(736, 52);
            this.nudDEF.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDEF.Name = "nudDEF";
            this.nudDEF.Size = new System.Drawing.Size(190, 25);
            this.nudDEF.TabIndex = 8;
            // 
            // nudATK
            // 
            this.nudATK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudATK.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudATK.Location = new System.Drawing.Point(281, 53);
            this.nudATK.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudATK.Name = "nudATK";
            this.nudATK.Size = new System.Drawing.Size(190, 25);
            this.nudATK.TabIndex = 7;
            // 
            // cbCardType
            // 
            this.cbCardType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Items.AddRange(new object[] {
            "MONSTER",
            "SPELL"});
            this.cbCardType.Location = new System.Drawing.Point(489, 52);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(203, 25);
            this.cbCardType.TabIndex = 6;
            // 
            // tbCardName
            // 
            this.tbCardName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCardName.Location = new System.Drawing.Point(7, 53);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(202, 25);
            this.tbCardName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(736, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEF Points:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(281, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "ATK Points:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(489, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.BackgroundImage = global::yu_gi_oh.Properties.Resources.Refresh;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(1239, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 715);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cards in Deck:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnumberofcardsinDeck
            // 
            this.lblnumberofcardsinDeck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblnumberofcardsinDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnumberofcardsinDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnumberofcardsinDeck.Location = new System.Drawing.Point(170, 715);
            this.lblnumberofcardsinDeck.Name = "lblnumberofcardsinDeck";
            this.lblnumberofcardsinDeck.Size = new System.Drawing.Size(44, 27);
            this.lblnumberofcardsinDeck.TabIndex = 24;
            this.lblnumberofcardsinDeck.Text = "1";
            this.lblnumberofcardsinDeck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmax
            // 
            this.lblmax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblmax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmax.Location = new System.Drawing.Point(1122, 717);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(47, 25);
            this.lblmax.TabIndex = 26;
            this.lblmax.Text = "12";
            this.lblmax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcurr
            // 
            this.lblcurr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblcurr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcurr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcurr.Location = new System.Drawing.Point(1085, 717);
            this.lblcurr.Name = "lblcurr";
            this.lblcurr.Size = new System.Drawing.Size(39, 25);
            this.lblcurr.TabIndex = 27;
            this.lblcurr.Text = "1";
            this.lblcurr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(209, 715);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 27);
            this.label8.TabIndex = 29;
            this.label8.Text = "/ 30";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Deckbuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yu_gi_oh.Properties.Resources.d17ad80144ef56adbf58a17a686ea619;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1852, 829);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcurr);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblnumberofcardsinDeck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbCardFilter);
            this.Controls.Add(this.SelectedCardGB);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnOpenDeck);
            this.Controls.Add(this.btnRemoveFromDeck);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnAddtoDeck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewDeck);
            this.Controls.Add(this.btnSaveDeck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deckbuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deckbuilder";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.SelectedCardGB.ResumeLayout(false);
            this.gbCardFilter.ResumeLayout(false);
            this.gbCardFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudATK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveDeck;
        private System.Windows.Forms.Button btnNewDeck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddtoDeck;
        private System.Windows.Forms.Button btnRemoveFromDeck;
        private System.Windows.Forms.Button btnOpenDeck;
        private System.Windows.Forms.PictureBox loadingPB;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridView dgvDeck;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox SelectedCardGB;
        public System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.GroupBox gbCardFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.NumericUpDown nudDEF;
        private System.Windows.Forms.NumericUpDown nudATK;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.TextBox tbCardName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnumberofcardsinDeck;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblcurr;
        private System.Windows.Forms.Label label8;
    }
}