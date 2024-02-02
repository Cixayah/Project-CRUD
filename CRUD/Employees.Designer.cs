namespace CRUD
{
    partial class Employees
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            maskedTextBox1 = new MaskedTextBox();
            btnSalvar = new Button();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            imageList1 = new ImageList(components);
            label7 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.ForeColor = Color.FromArgb(80, 250, 123);
            label1.Location = new Point(131, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 23);
            txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Cascadia Code", 9F);
            btnAdd.ForeColor = Color.FromArgb(255, 121, 198);
            btnAdd.ImageKey = "add.png";
            btnAdd.Location = new Point(191, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 23);
            btnAdd.TabIndex = 2;
            btnAdd.TabStop = false;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(191, 97);
            maskedTextBox1.Mask = "(00)00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(94, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Cascadia Code", 9F);
            btnSalvar.ForeColor = Color.FromArgb(255, 121, 198);
            btnSalvar.Location = new Point(284, 256);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.TabStop = false;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Cascadia Code", 9F);
            btnBuscar.ForeColor = Color.FromArgb(255, 121, 198);
            btnBuscar.Location = new Point(365, 256);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.TabStop = false;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Cascadia Code", 9F);
            btnEditar.ForeColor = Color.FromArgb(255, 121, 198);
            btnEditar.Location = new Point(446, 256);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 6;
            btnEditar.TabStop = false;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Cascadia Code", 9F);
            btnApagar.ForeColor = Color.FromArgb(255, 121, 198);
            btnApagar.Location = new Point(527, 256);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 7;
            btnApagar.TabStop = false;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.ForeColor = Color.FromArgb(80, 250, 123);
            label2.Location = new Point(104, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 8;
            label2.Text = "Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.ForeColor = Color.FromArgb(80, 250, 123);
            label3.Location = new Point(113, 124);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.ForeColor = Color.FromArgb(80, 250, 123);
            label4.Location = new Point(95, 153);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 11;
            label4.Text = "Endereço:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.ForeColor = Color.FromArgb(80, 250, 123);
            label5.Location = new Point(113, 182);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 13;
            label5.Text = "Número:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.ForeColor = Color.FromArgb(80, 250, 123);
            label7.Location = new Point(149, 215);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 17;
            label7.Text = "RG:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(325, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 23);
            textBox5.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F);
            label10.ForeColor = Color.FromArgb(80, 250, 123);
            label10.Location = new Point(246, 186);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 21;
            label10.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 12F);
            label9.ForeColor = Color.FromArgb(80, 250, 123);
            label9.Location = new Point(298, 215);
            label9.Name = "label9";
            label9.Size = new Size(46, 21);
            label9.TabIndex = 23;
            label9.Text = "CPF:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(192, 213);
            maskedTextBox2.Mask = "00.000.000-0";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 25;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(340, 213);
            maskedTextBox3.Mask = "000.000.000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 26;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(669, 315);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalvar);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(80, 250, 123);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnAdd;
        private MaskedTextBox maskedTextBox1;
        private Button btnSalvar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnApagar;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private ImageList imageList1;
        private Label label7;
        private TextBox textBox5;
        private Label label10;
        private Label label9;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
    }
}