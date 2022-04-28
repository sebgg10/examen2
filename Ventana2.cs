namespace examen2;

public class Ventana2 : Form
{
    private System.ComponentModel.IContainer components = null;
    Button btnCancelar;
    public Ventana2()
    {
        btnCancelar = new Button();
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Text = "Ventana2";

        //Boton Cancelar
        btnCancelar.Text = "Cancelar";
        btnCancelar.AutoSize = true;
        btnCancelar.Location = new Point(10,165);
        btnCancelar.Click += new EventHandler(btnCancelar_Click);

        //Agregar Controles
        this.Controls.Add(btnCancelar);

    }
    private void btnCancelar_Click(object sender, EventArgs e){
        Application.Restart();
    }

}