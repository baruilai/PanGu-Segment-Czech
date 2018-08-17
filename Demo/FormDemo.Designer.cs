namespace Demo
{
    partial class FormDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemo));
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownRedundancy = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultiSelect = new System.Windows.Forms.CheckBox();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.numericUpDownUnknownWordsThreshold = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFreqFirst = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayPosition = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterStopWords = new System.Windows.Forms.CheckBox();
            this.checkBoxMatchName = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSrcLength = new System.Windows.Forms.Label();
            this.labelRegRate = new System.Windows.Forms.Label();
            this.labelSegTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSegment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxForceSingleWord = new System.Windows.Forms.CheckBox();
            this.checkBoxTraditionalChs = new System.Windows.Forms.CheckBox();
            this.checkBoxST = new System.Windows.Forms.CheckBox();
            this.checkBoxUnknownWord = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterEnglish = new System.Windows.Forms.CheckBox();
            this.numericUpDownFilterEnglishLength = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.labelFilterNumericLength = new System.Windows.Forms.Label();
            this.numericUpDownFilterNumericLength = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFilterNumeric = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreCapital = new System.Windows.Forms.CheckBox();
            this.checkBoxShowTimeOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishSegment = new System.Windows.Forms.CheckBox();
            this.checkBoxSynonymOutput = new System.Windows.Forms.CheckBox();
            this.checkBoxWildcard = new System.Windows.Forms.CheckBox();
            this.checkBoxWildcardSegment = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomRule = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishMultiSelect = new System.Windows.Forms.CheckBox();
            this.textBoxSegwords = new System.Windows.Forms.RichTextBox();
            this.textBoxSource = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClearForms = new System.Windows.Forms.Button();
            this.checkBoxIgnoreEOL = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreSpace = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedundancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknownWordsThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterEnglishLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterNumericLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Stránky projektu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(894, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Redundantní počet možností";
            // 
            // numericUpDownRedundancy
            // 
            this.numericUpDownRedundancy.Location = new System.Drawing.Point(836, 560);
            this.numericUpDownRedundancy.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRedundancy.Name = "numericUpDownRedundancy";
            this.numericUpDownRedundancy.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRedundancy.TabIndex = 86;
            this.numericUpDownRedundancy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxMultiSelect
            // 
            this.checkBoxMultiSelect.AutoSize = true;
            this.checkBoxMultiSelect.Location = new System.Drawing.Point(836, 510);
            this.checkBoxMultiSelect.Name = "checkBoxMultiSelect";
            this.checkBoxMultiSelect.Size = new System.Drawing.Size(131, 17);
            this.checkBoxMultiSelect.TabIndex = 85;
            this.checkBoxMultiSelect.Text = "Ambiguitní tokenizace";
            this.checkBoxMultiSelect.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(836, 654);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(124, 25);
            this.buttonSaveConfig.TabIndex = 84;
            this.buttonSaveConfig.Text = "Uložit nastavení";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // numericUpDownUnknownWordsThreshold
            // 
            this.numericUpDownUnknownWordsThreshold.Location = new System.Drawing.Point(865, 697);
            this.numericUpDownUnknownWordsThreshold.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownUnknownWordsThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnknownWordsThreshold.Name = "numericUpDownUnknownWordsThreshold";
            this.numericUpDownUnknownWordsThreshold.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownUnknownWordsThreshold.TabIndex = 80;
            this.numericUpDownUnknownWordsThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxFreqFirst
            // 
            this.checkBoxFreqFirst.AutoSize = true;
            this.checkBoxFreqFirst.Checked = true;
            this.checkBoxFreqFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFreqFirst.Location = new System.Drawing.Point(836, 153);
            this.checkBoxFreqFirst.Name = "checkBoxFreqFirst";
            this.checkBoxFreqFirst.Size = new System.Drawing.Size(202, 17);
            this.checkBoxFreqFirst.TabIndex = 78;
            this.checkBoxFreqFirst.Text = "Priorita rozlišení podle frekvence slov";
            this.checkBoxFreqFirst.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayPosition
            // 
            this.checkBoxDisplayPosition.AutoSize = true;
            this.checkBoxDisplayPosition.Location = new System.Drawing.Point(836, 130);
            this.checkBoxDisplayPosition.Name = "checkBoxDisplayPosition";
            this.checkBoxDisplayPosition.Size = new System.Drawing.Size(132, 17);
            this.checkBoxDisplayPosition.TabIndex = 76;
            this.checkBoxDisplayPosition.Text = "Zobrazovat pozici slov";
            this.checkBoxDisplayPosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterStopWords
            // 
            this.checkBoxFilterStopWords.AutoSize = true;
            this.checkBoxFilterStopWords.Location = new System.Drawing.Point(836, 107);
            this.checkBoxFilterStopWords.Name = "checkBoxFilterStopWords";
            this.checkBoxFilterStopWords.Size = new System.Drawing.Size(114, 17);
            this.checkBoxFilterStopWords.TabIndex = 74;
            this.checkBoxFilterStopWords.Text = "Filtrovat stop slova";
            this.checkBoxFilterStopWords.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatchName
            // 
            this.checkBoxMatchName.AutoSize = true;
            this.checkBoxMatchName.Checked = true;
            this.checkBoxMatchName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMatchName.Location = new System.Drawing.Point(836, 84);
            this.checkBoxMatchName.Name = "checkBoxMatchName";
            this.checkBoxMatchName.Size = new System.Drawing.Size(151, 17);
            this.checkBoxMatchName.TabIndex = 73;
            this.checkBoxMatchName.Text = "Identifikovat čínská jména";
            this.checkBoxMatchName.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(100, 41);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(206, 13);
            this.linkLabel2.TabIndex = 72;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://www.codeplex.com/pangusegment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(444, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "盘古中英文分词组件是由eaglet开发的一款基于 .Net Framework 2.0的轻量级分词组件";
            // 
            // labelSrcLength
            // 
            this.labelSrcLength.AutoSize = true;
            this.labelSrcLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrcLength.Location = new System.Drawing.Point(166, 540);
            this.labelSrcLength.Name = "labelSrcLength";
            this.labelSrcLength.Size = new System.Drawing.Size(14, 15);
            this.labelSrcLength.TabIndex = 68;
            this.labelSrcLength.Text = "0";
            // 
            // labelRegRate
            // 
            this.labelRegRate.AutoSize = true;
            this.labelRegRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegRate.Location = new System.Drawing.Point(671, 540);
            this.labelRegRate.Name = "labelRegRate";
            this.labelRegRate.Size = new System.Drawing.Size(14, 15);
            this.labelRegRate.TabIndex = 67;
            this.labelRegRate.Text = "0";
            // 
            // labelSegTime
            // 
            this.labelSegTime.AutoSize = true;
            this.labelSegTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSegTime.Location = new System.Drawing.Point(413, 540);
            this.labelSegTime.Name = "labelSegTime";
            this.labelSegTime.Size = new System.Drawing.Size(14, 15);
            this.labelSegTime.TabIndex = 66;
            this.labelSegTime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(547, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Rychlost tokenizace:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(271, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Délka trvání tokenizace:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Délka zdrojového řetězce:";
            // 
            // buttonSegment
            // 
            this.buttonSegment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSegment.Location = new System.Drawing.Point(257, 581);
            this.buttonSegment.Name = "buttonSegment";
            this.buttonSegment.Size = new System.Drawing.Size(115, 63);
            this.buttonSegment.TabIndex = 60;
            this.buttonSegment.Text = "Tokenizovat";
            this.buttonSegment.UseVisualStyleBackColor = true;
            this.buttonSegment.Click += new System.EventHandler(this.buttonSegment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tokenizovaný text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Zdrojový text";
            // 
            // checkBoxForceSingleWord
            // 
            this.checkBoxForceSingleWord.AutoSize = true;
            this.checkBoxForceSingleWord.Location = new System.Drawing.Point(836, 533);
            this.checkBoxForceSingleWord.Name = "checkBoxForceSingleWord";
            this.checkBoxForceSingleWord.Size = new System.Drawing.Size(227, 17);
            this.checkBoxForceSingleWord.TabIndex = 89;
            this.checkBoxForceSingleWord.Text = "Nucená ambiguitní jednotková tokenizace";
            this.checkBoxForceSingleWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxTraditionalChs
            // 
            this.checkBoxTraditionalChs.AutoSize = true;
            this.checkBoxTraditionalChs.Checked = true;
            this.checkBoxTraditionalChs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTraditionalChs.Location = new System.Drawing.Point(836, 176);
            this.checkBoxTraditionalChs.Name = "checkBoxTraditionalChs";
            this.checkBoxTraditionalChs.Size = new System.Drawing.Size(251, 17);
            this.checkBoxTraditionalChs.TabIndex = 90;
            this.checkBoxTraditionalChs.Text = "Tokenizace textu v nezjednodušených znacích";
            this.checkBoxTraditionalChs.UseVisualStyleBackColor = true;
            // 
            // checkBoxST
            // 
            this.checkBoxST.AutoSize = true;
            this.checkBoxST.Checked = true;
            this.checkBoxST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxST.Location = new System.Drawing.Point(855, 199);
            this.checkBoxST.Name = "checkBoxST";
            this.checkBoxST.Size = new System.Drawing.Size(345, 17);
            this.checkBoxST.TabIndex = 91;
            this.checkBoxST.Text = "Současný výstup ve zjednodušených a nezjednodušených znacích";
            this.checkBoxST.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnknownWord
            // 
            this.checkBoxUnknownWord.AutoSize = true;
            this.checkBoxUnknownWord.Location = new System.Drawing.Point(836, 222);
            this.checkBoxUnknownWord.Name = "checkBoxUnknownWord";
            this.checkBoxUnknownWord.Size = new System.Drawing.Size(160, 17);
            this.checkBoxUnknownWord.TabIndex = 92;
            this.checkBoxUnknownWord.Text = "Identifikace neznámých slov";
            this.checkBoxUnknownWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterEnglish
            // 
            this.checkBoxFilterEnglish.AutoSize = true;
            this.checkBoxFilterEnglish.Location = new System.Drawing.Point(836, 399);
            this.checkBoxFilterEnglish.Name = "checkBoxFilterEnglish";
            this.checkBoxFilterEnglish.Size = new System.Drawing.Size(125, 17);
            this.checkBoxFilterEnglish.TabIndex = 93;
            this.checkBoxFilterEnglish.Text = "Filtrovat anglický text";
            this.checkBoxFilterEnglish.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFilterEnglishLength
            // 
            this.numericUpDownFilterEnglishLength.Location = new System.Drawing.Point(836, 468);
            this.numericUpDownFilterEnglishLength.Name = "numericUpDownFilterEnglishLength";
            this.numericUpDownFilterEnglishLength.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownFilterEnglishLength.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(894, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Délka slov pro filtraci anglického textu";
            // 
            // labelFilterNumericLength
            // 
            this.labelFilterNumericLength.AutoSize = true;
            this.labelFilterNumericLength.Location = new System.Drawing.Point(894, 624);
            this.labelFilterNumericLength.Name = "labelFilterNumericLength";
            this.labelFilterNumericLength.Size = new System.Drawing.Size(118, 13);
            this.labelFilterNumericLength.TabIndex = 98;
            this.labelFilterNumericLength.Text = "Délka filtrovaných čísel";
            // 
            // numericUpDownFilterNumericLength
            // 
            this.numericUpDownFilterNumericLength.Location = new System.Drawing.Point(836, 622);
            this.numericUpDownFilterNumericLength.Name = "numericUpDownFilterNumericLength";
            this.numericUpDownFilterNumericLength.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownFilterNumericLength.TabIndex = 97;
            // 
            // checkBoxFilterNumeric
            // 
            this.checkBoxFilterNumeric.AutoSize = true;
            this.checkBoxFilterNumeric.Location = new System.Drawing.Point(836, 599);
            this.checkBoxFilterNumeric.Name = "checkBoxFilterNumeric";
            this.checkBoxFilterNumeric.Size = new System.Drawing.Size(106, 17);
            this.checkBoxFilterNumeric.TabIndex = 96;
            this.checkBoxFilterNumeric.Text = "Filtrovat číslovky";
            this.checkBoxFilterNumeric.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreCapital
            // 
            this.checkBoxIgnoreCapital.AutoSize = true;
            this.checkBoxIgnoreCapital.Location = new System.Drawing.Point(836, 245);
            this.checkBoxIgnoreCapital.Name = "checkBoxIgnoreCapital";
            this.checkBoxIgnoreCapital.Size = new System.Drawing.Size(169, 17);
            this.checkBoxIgnoreCapital.TabIndex = 99;
            this.checkBoxIgnoreCapital.Text = "Nezohledňovat velikost písma";
            this.checkBoxIgnoreCapital.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowTimeOnly
            // 
            this.checkBoxShowTimeOnly.AutoSize = true;
            this.checkBoxShowTimeOnly.Location = new System.Drawing.Point(836, 335);
            this.checkBoxShowTimeOnly.Name = "checkBoxShowTimeOnly";
            this.checkBoxShowTimeOnly.Size = new System.Drawing.Size(224, 17);
            this.checkBoxShowTimeOnly.TabIndex = 100;
            this.checkBoxShowTimeOnly.Text = "Zobrazit pouze časovou délku tokenizace";
            this.checkBoxShowTimeOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishSegment
            // 
            this.checkBoxEnglishSegment.AutoSize = true;
            this.checkBoxEnglishSegment.Location = new System.Drawing.Point(836, 445);
            this.checkBoxEnglishSegment.Name = "checkBoxEnglishSegment";
            this.checkBoxEnglishSegment.Size = new System.Drawing.Size(218, 17);
            this.checkBoxEnglishSegment.TabIndex = 101;
            this.checkBoxEnglishSegment.Text = "Jednotková tokenizace anglického textu";
            this.checkBoxEnglishSegment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSynonymOutput
            // 
            this.checkBoxSynonymOutput.AutoSize = true;
            this.checkBoxSynonymOutput.Location = new System.Drawing.Point(836, 268);
            this.checkBoxSynonymOutput.Name = "checkBoxSynonymOutput";
            this.checkBoxSynonymOutput.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSynonymOutput.TabIndex = 102;
            this.checkBoxSynonymOutput.Text = "Výstup synonym";
            this.checkBoxSynonymOutput.UseVisualStyleBackColor = true;
            // 
            // checkBoxWildcard
            // 
            this.checkBoxWildcard.AutoSize = true;
            this.checkBoxWildcard.Location = new System.Drawing.Point(836, 289);
            this.checkBoxWildcard.Name = "checkBoxWildcard";
            this.checkBoxWildcard.Size = new System.Drawing.Size(170, 17);
            this.checkBoxWildcard.TabIndex = 103;
            this.checkBoxWildcard.Text = "Zohlednění zástupných znaků";
            this.checkBoxWildcard.UseVisualStyleBackColor = true;
            // 
            // checkBoxWildcardSegment
            // 
            this.checkBoxWildcardSegment.AutoSize = true;
            this.checkBoxWildcardSegment.Location = new System.Drawing.Point(855, 312);
            this.checkBoxWildcardSegment.Name = "checkBoxWildcardSegment";
            this.checkBoxWildcardSegment.Size = new System.Drawing.Size(355, 17);
            this.checkBoxWildcardSegment.TabIndex = 104;
            this.checkBoxWildcardSegment.Text = "Opětovná tokenizace slov, u kterých byly zohledněny zástupné znaky";
            this.checkBoxWildcardSegment.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomRule
            // 
            this.checkBoxCustomRule.AutoSize = true;
            this.checkBoxCustomRule.Location = new System.Drawing.Point(836, 358);
            this.checkBoxCustomRule.Name = "checkBoxCustomRule";
            this.checkBoxCustomRule.Size = new System.Drawing.Size(132, 17);
            this.checkBoxCustomRule.TabIndex = 105;
            this.checkBoxCustomRule.Text = "Uživatelské nastavení";
            this.checkBoxCustomRule.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishMultiSelect
            // 
            this.checkBoxEnglishMultiSelect.AutoSize = true;
            this.checkBoxEnglishMultiSelect.Location = new System.Drawing.Point(836, 422);
            this.checkBoxEnglishMultiSelect.Name = "checkBoxEnglishMultiSelect";
            this.checkBoxEnglishMultiSelect.Size = new System.Drawing.Size(212, 17);
            this.checkBoxEnglishMultiSelect.TabIndex = 106;
            this.checkBoxEnglishMultiSelect.Text = "Ambiguitní tokenizace anglického textu";
            this.checkBoxEnglishMultiSelect.UseVisualStyleBackColor = true;
            // 
            // textBoxSegwords
            // 
            this.textBoxSegwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSegwords.Location = new System.Drawing.Point(1, 305);
            this.textBoxSegwords.Name = "textBoxSegwords";
            this.textBoxSegwords.Size = new System.Drawing.Size(829, 222);
            this.textBoxSegwords.TabIndex = 107;
            this.textBoxSegwords.Text = "";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSource.Location = new System.Drawing.Point(1, 87);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(829, 198);
            this.textBoxSource.TabIndex = 108;
            this.textBoxSource.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(15, 613);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 30);
            this.SaveButton.TabIndex = 109;
            this.SaveButton.Text = "Uložit (UTF-8)";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // divider
            // 
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divider.Location = new System.Drawing.Point(550, 624);
            this.divider.MaxLength = 255;
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(243, 29);
            this.divider.TabIndex = 110;
            this.divider.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(547, 603);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 111;
            this.label12.Text = "Oddělovač";
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(15, 581);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(115, 30);
            this.OpenButton.TabIndex = 112;
            this.OpenButton.Text = "Otevřít";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(833, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "PanguCZ alpha v9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(833, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "Překlad: Vlastimil Dobečka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(833, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "Kód: Marek Bašista";
            // 
            // buttonClearForms
            // 
            this.buttonClearForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearForms.Location = new System.Drawing.Point(136, 581);
            this.buttonClearForms.Name = "buttonClearForms";
            this.buttonClearForms.Size = new System.Drawing.Size(115, 63);
            this.buttonClearForms.TabIndex = 116;
            this.buttonClearForms.Text = "Vymazat";
            this.buttonClearForms.UseVisualStyleBackColor = true;
            this.buttonClearForms.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // checkBoxIgnoreEOL
            // 
            this.checkBoxIgnoreEOL.AutoSize = true;
            this.checkBoxIgnoreEOL.Checked = true;
            this.checkBoxIgnoreEOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreEOL.Location = new System.Drawing.Point(674, 583);
            this.checkBoxIgnoreEOL.Name = "checkBoxIgnoreEOL";
            this.checkBoxIgnoreEOL.Size = new System.Drawing.Size(119, 17);
            this.checkBoxIgnoreEOL.TabIndex = 117;
            this.checkBoxIgnoreEOL.Text = "Mazat konce řádků";
            this.checkBoxIgnoreEOL.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreSpace
            // 
            this.checkBoxIgnoreSpace.AutoSize = true;
            this.checkBoxIgnoreSpace.Checked = true;
            this.checkBoxIgnoreSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreSpace.Location = new System.Drawing.Point(550, 583);
            this.checkBoxIgnoreSpace.Name = "checkBoxIgnoreSpace";
            this.checkBoxIgnoreSpace.Size = new System.Drawing.Size(91, 17);
            this.checkBoxIgnoreSpace.TabIndex = 118;
            this.checkBoxIgnoreSpace.Text = "Mazat mezery";
            this.checkBoxIgnoreSpace.UseVisualStyleBackColor = true;
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 691);
            this.Controls.Add(this.checkBoxIgnoreSpace);
            this.Controls.Add(this.checkBoxIgnoreEOL);
            this.Controls.Add(this.buttonClearForms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxSegwords);
            this.Controls.Add(this.checkBoxEnglishMultiSelect);
            this.Controls.Add(this.checkBoxCustomRule);
            this.Controls.Add(this.checkBoxWildcardSegment);
            this.Controls.Add(this.checkBoxWildcard);
            this.Controls.Add(this.checkBoxSynonymOutput);
            this.Controls.Add(this.checkBoxEnglishSegment);
            this.Controls.Add(this.checkBoxShowTimeOnly);
            this.Controls.Add(this.checkBoxIgnoreCapital);
            this.Controls.Add(this.labelFilterNumericLength);
            this.Controls.Add(this.numericUpDownFilterNumericLength);
            this.Controls.Add(this.checkBoxFilterNumeric);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownFilterEnglishLength);
            this.Controls.Add(this.checkBoxFilterEnglish);
            this.Controls.Add(this.checkBoxUnknownWord);
            this.Controls.Add(this.checkBoxST);
            this.Controls.Add(this.checkBoxTraditionalChs);
            this.Controls.Add(this.checkBoxForceSingleWord);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownRedundancy);
            this.Controls.Add(this.checkBoxMultiSelect);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.numericUpDownUnknownWordsThreshold);
            this.Controls.Add(this.checkBoxFreqFirst);
            this.Controls.Add(this.checkBoxDisplayPosition);
            this.Controls.Add(this.checkBoxFilterStopWords);
            this.Controls.Add(this.checkBoxMatchName);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelSrcLength);
            this.Controls.Add(this.labelRegRate);
            this.Controls.Add(this.labelSegTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSegment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDemo";
            this.Text = "PanGu Demo";
            this.Load += new System.EventHandler(this.FormDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedundancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknownWordsThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterEnglishLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterNumericLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownRedundancy;
        private System.Windows.Forms.CheckBox checkBoxMultiSelect;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.NumericUpDown numericUpDownUnknownWordsThreshold;
        private System.Windows.Forms.CheckBox checkBoxFreqFirst;
        private System.Windows.Forms.CheckBox checkBoxDisplayPosition;
        private System.Windows.Forms.CheckBox checkBoxFilterStopWords;
        private System.Windows.Forms.CheckBox checkBoxMatchName;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSrcLength;
        private System.Windows.Forms.Label labelRegRate;
        private System.Windows.Forms.Label labelSegTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSegment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxForceSingleWord;
        private System.Windows.Forms.CheckBox checkBoxTraditionalChs;
        private System.Windows.Forms.CheckBox checkBoxST;
        private System.Windows.Forms.CheckBox checkBoxUnknownWord;
        private System.Windows.Forms.CheckBox checkBoxFilterEnglish;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterEnglishLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelFilterNumericLength;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterNumericLength;
        private System.Windows.Forms.CheckBox checkBoxFilterNumeric;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCapital;
        private System.Windows.Forms.CheckBox checkBoxShowTimeOnly;
        private System.Windows.Forms.CheckBox checkBoxEnglishSegment;
        private System.Windows.Forms.CheckBox checkBoxSynonymOutput;
        private System.Windows.Forms.CheckBox checkBoxWildcard;
        private System.Windows.Forms.CheckBox checkBoxWildcardSegment;
        private System.Windows.Forms.CheckBox checkBoxCustomRule;
        private System.Windows.Forms.CheckBox checkBoxEnglishMultiSelect;
        private System.Windows.Forms.RichTextBox textBoxSegwords;
        private System.Windows.Forms.RichTextBox textBoxSource;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox divider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearForms;
        private System.Windows.Forms.CheckBox checkBoxIgnoreEOL;
        private System.Windows.Forms.CheckBox checkBoxIgnoreSpace;

    }
}

