namespace Dic_Palavra;

public partial class Form1 : Form {
    int Mouse_X_ori;
    int Mouse_Y_ori;
    int Height_Original;
    int des;

    public Form1() {
        InitializeComponent();
        Height_Original = Height;
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void Form1_MouseDown(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            Mouse_X_ori = e.X;
            Mouse_Y_ori = e.Y;
        }
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            Left = Left + (e.X - Mouse_X_ori);
            Top = Top + (e.Y - Mouse_Y_ori);
        }
    }

    private void timer1_Tick(object sender, EventArgs e) {
        int atu = (int)(Opacity * 100);
        if (atu == des) {
            (sender as System.Windows.Forms.Timer)!.Enabled = false;
            if (atu == 100) {
                this.Height = Height_Original;
            } else {
                Height = tableLayoutPanel1.Top + (this.Height - this.ClientRectangle.Height);
            }
        } else {
            if (atu < des) {
                Opacity += 0.1;
            } else {
                Opacity -= 0.1;
            }
        }
    }

    private void Form1_Activated(object sender, EventArgs e) {
        des = 100;
        timer1.Enabled = true;
    }

    private void Form1_Deactivate(object sender, EventArgs e) {
        des = 50;
        timer1.Enabled = true;
    }

    private void Txt_Entrada_TextChanged(object sender, EventArgs e) {
        string t = Txt_Entrada.Text;
        LV_Lista.Items.Clear();
        var rs = BD.Loja.SQL("SELECT TOP 10 * FROM Meta.Dic_Palavra WHERE Termo LIKE @1 OR Extenso LIKE @1", t + '%');
        if (rs.HasRows) {
            while (rs.Read()) {
                LV_Lista.Items.Add(new ListViewItem(new string[3] {
                    rs["Termo"].ToStr() ?? "",
                    rs["Extenso"].ToStr() ?? "",
                    rs["Descr_Termo"].ToStr() ?? ""
                }));
            }
        }
        T_Termo.Text = "";
        T_Extenso.Text = "";
        T_Descricao.Text = "";
    }

    private void button1_Click(object sender, EventArgs e) {
        if (T_Termo.Text == "") return;
        if (MessageBox.Show("Confirma a gravação?","Salvar",MessageBoxButtons.OKCancel)==DialogResult.OK) {
            BD.Loja.SQLCmd("INSERT INTO Meta.Dic_Palavra (Termo,Extenso,Descr_Termo) VALUES (@1,@2,@3);",
                T_Termo.Text, T_Extenso.Text, T_Descricao.Text);
        }
    }
}
