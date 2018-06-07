namespace my_primitive_paint
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clear = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cb_figures = new System.Windows.Forms.ComboBox();
            this.btn_add_custom_figure = new System.Windows.Forms.Button();
            this.btn_delete_custom_figure = new System.Windows.Forms.Button();
            this.cmb_custom_figures = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_clear.Location = new System.Drawing.Point(734, 331);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(184, 90);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture.Location = new System.Drawing.Point(11, 27);
            this.picture.Margin = new System.Windows.Forms.Padding(2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(708, 429);
            this.picture.TabIndex = 18;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // cb_figures
            // 
            this.cb_figures.BackColor = System.Drawing.SystemColors.ControlText;
            this.cb_figures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_figures.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_figures.FormattingEnabled = true;
            this.cb_figures.Items.AddRange(new object[] {
            "Rectangle",
            "Circle",
            "Square",
            "Ellipse"});
            this.cb_figures.Location = new System.Drawing.Point(734, 27);
            this.cb_figures.Margin = new System.Windows.Forms.Padding(2);
            this.cb_figures.Name = "cb_figures";
            this.cb_figures.Size = new System.Drawing.Size(124, 21);
            this.cb_figures.TabIndex = 19;
            this.cb_figures.SelectionChangeCommitted += new System.EventHandler(this.cb_figures_SelectionChangeCommitted);
            // 
            // btn_add_custom_figure
            // 
            this.btn_add_custom_figure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_custom_figure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_custom_figure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_custom_figure.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_add_custom_figure.Location = new System.Drawing.Point(734, 144);
            this.btn_add_custom_figure.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_custom_figure.Name = "btn_add_custom_figure";
            this.btn_add_custom_figure.Size = new System.Drawing.Size(184, 92);
            this.btn_add_custom_figure.TabIndex = 22;
            this.btn_add_custom_figure.Text = "Добавить";
            this.btn_add_custom_figure.UseVisualStyleBackColor = false;
            this.btn_add_custom_figure.Click += new System.EventHandler(this.btn_add_custom_figure_Click);
            // 
            // btn_delete_custom_figure
            // 
            this.btn_delete_custom_figure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete_custom_figure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete_custom_figure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete_custom_figure.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_delete_custom_figure.Location = new System.Drawing.Point(734, 240);
            this.btn_delete_custom_figure.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete_custom_figure.Name = "btn_delete_custom_figure";
            this.btn_delete_custom_figure.Size = new System.Drawing.Size(184, 87);
            this.btn_delete_custom_figure.TabIndex = 23;
            this.btn_delete_custom_figure.Text = "Удалить";
            this.btn_delete_custom_figure.UseVisualStyleBackColor = false;
            this.btn_delete_custom_figure.Click += new System.EventHandler(this.btn_delete_custom_figure_Click);
            // 
            // cmb_custom_figures
            // 
            this.cmb_custom_figures.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmb_custom_figures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_custom_figures.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_custom_figures.FormattingEnabled = true;
            this.cmb_custom_figures.Location = new System.Drawing.Point(734, 93);
            this.cmb_custom_figures.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_custom_figures.Name = "cmb_custom_figures";
            this.cmb_custom_figures.Size = new System.Drawing.Size(124, 21);
            this.cmb_custom_figures.TabIndex = 24;
            this.cmb_custom_figures.SelectedIndexChanged += new System.EventHandler(this.cmb_custom_figures_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(956, 485);
            this.Controls.Add(this.cmb_custom_figures);
            this.Controls.Add(this.btn_delete_custom_figure);
            this.Controls.Add(this.btn_add_custom_figure);
            this.Controls.Add(this.cb_figures);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btn_clear);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(972, 523);
            this.MinimumSize = new System.Drawing.Size(972, 523);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox cb_figures;
        private System.Windows.Forms.Button btn_add_custom_figure;
        private System.Windows.Forms.Button btn_delete_custom_figure;
        public System.Windows.Forms.ComboBox cmb_custom_figures;
    }
}

