namespace Dic_Palavra;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components = new System.ComponentModel.Container();
        Txt_Entrada = new TextBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        LV_Lista = new ListView();
        Termo = new ColumnHeader();
        Extenso = new ColumnHeader();
        Desc_Termo = new ColumnHeader();
        flowLayoutPanel1 = new FlowLayoutPanel();
        label1 = new Label();
        T_Termo = new TextBox();
        label2 = new Label();
        T_Extenso = new TextBox();
        label3 = new Label();
        T_Descricao = new TextBox();
        button1 = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // Txt_Entrada
        // 
        Txt_Entrada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Txt_Entrada.Location = new Point(29, 2);
        Txt_Entrada.Name = "Txt_Entrada";
        Txt_Entrada.Size = new Size(460, 20);
        Txt_Entrada.TabIndex = 0;
        Txt_Entrada.TextChanged += Txt_Entrada_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(LV_Lista, 0, 0);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
        tableLayoutPanel1.Location = new Point(0, 28);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        tableLayoutPanel1.Size = new Size(492, 173);
        tableLayoutPanel1.TabIndex = 6;
        // 
        // LV_Lista
        // 
        LV_Lista.Columns.AddRange(new ColumnHeader[] { Termo, Extenso, Desc_Termo });
        LV_Lista.Dock = DockStyle.Fill;
        LV_Lista.Location = new Point(3, 3);
        LV_Lista.Name = "LV_Lista";
        LV_Lista.Size = new Size(486, 107);
        LV_Lista.TabIndex = 6;
        LV_Lista.UseCompatibleStateImageBehavior = false;
        LV_Lista.View = View.Details;
        // 
        // Termo
        // 
        Termo.Text = "Termo";
        Termo.Width = 71;
        // 
        // Extenso
        // 
        Extenso.Text = "Extenso";
        Extenso.Width = 89;
        // 
        // Desc_Termo
        // 
        Desc_Termo.Text = "Descrição";
        Desc_Termo.Width = 320;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.Controls.Add(label1);
        flowLayoutPanel1.Controls.Add(T_Termo);
        flowLayoutPanel1.Controls.Add(label2);
        flowLayoutPanel1.Controls.Add(T_Extenso);
        flowLayoutPanel1.Controls.Add(label3);
        flowLayoutPanel1.Controls.Add(T_Descricao);
        flowLayoutPanel1.Controls.Add(button1);
        flowLayoutPanel1.Location = new Point(3, 116);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(486, 54);
        flowLayoutPanel1.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(40, 13);
        label1.TabIndex = 0;
        label1.Text = "Termo:";
        // 
        // T_Termo
        // 
        T_Termo.Location = new Point(49, 3);
        T_Termo.Name = "T_Termo";
        T_Termo.Size = new Size(100, 20);
        T_Termo.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(155, 0);
        label2.Name = "label2";
        label2.Size = new Size(48, 13);
        label2.TabIndex = 2;
        label2.Text = "Extenso:";
        // 
        // T_Extenso
        // 
        T_Extenso.Location = new Point(209, 3);
        T_Extenso.Name = "T_Extenso";
        T_Extenso.Size = new Size(268, 20);
        T_Extenso.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 26);
        label3.Name = "label3";
        label3.Size = new Size(58, 13);
        label3.TabIndex = 4;
        label3.Text = "Descrição:";
        // 
        // T_Descricao
        // 
        T_Descricao.Location = new Point(67, 29);
        T_Descricao.Name = "T_Descricao";
        T_Descricao.Size = new Size(334, 20);
        T_Descricao.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new Point(407, 29);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 6;
        button1.Text = "Salva";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(492, 202);
        ControlBox = false;
        Controls.Add(tableLayoutPanel1);
        Controls.Add(Txt_Entrada);
        Name = "Form1";
        TopMost = true;
        Activated += Form1_Activated;
        Deactivate += Form1_Deactivate;
        Load += Form1_Load;
        MouseDown += Form1_MouseDown;
        MouseMove += Form1_MouseMove;
        tableLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox Txt_Entrada;
    private TableLayoutPanel tableLayoutPanel1;
    private ListView LV_Lista;
    private ColumnHeader Termo;
    private ColumnHeader Extenso;
    private ColumnHeader Desc_Termo;
    private System.Windows.Forms.Timer timer1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label label1;
    private TextBox T_Termo;
    private Label label2;
    private TextBox T_Extenso;
    private Label label3;
    private TextBox T_Descricao;
    private Button button1;
}
