using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public DirectX.Capture.Filter Camera;
        public DirectX.Capture.Capture CaptureInfo;
        public DirectX.Capture.Filters CamContainer;
        Image capturaImagem;
        public string caminhoImagemSalva = null;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           CamContainer = new DirectX.Capture.Filters();  
           try
           {
             int no_of_cam = CamContainer.VideoInputDevices.Count;

             for (int i = 0; i < no_of_cam; i++ )
             {
                try
                {
                        // obtém o dispositivo de entrada do vídeo
                        Camera = CamContainer.VideoInputDevices[i];
 
                        // inicializa a Captura usando o dispositivo
                        CaptureInfo = new DirectX.Capture.Capture(Camera, null);
                                                                        
                        // Define a janela de visualização do vídeo
                        CaptureInfo.PreviewWindow = this.picWebCam;
 
                        // Capturando o tratamento de evento
                        CaptureInfo.FrameCaptureComplete += AtualizaImagem;
                                                 
                        // Captura o frame do dispositivo
                        CaptureInfo.CaptureFrame();
                         
                        // Se o dispositivo foi encontrado e inicializado então sai sem checar o resto
                        break;
                }
                catch (Exception ex) 
                {
                    throw ex;    
                }
            }
        }
        catch (Exception ex)
        {                
            MessageBox.Show(this, ex.Message);
        }
     }

        public void AtualizaImagem(PictureBox frame)
        {
            try
            {
                capturaImagem = frame.Image;
                this.picImagem.Image = capturaImagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
       
        private void btnCaptura_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureInfo.CaptureFrame();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                caminhoImagemSalva = @"c:\dados\" + "ImagemWebCam" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg";
                picImagem.Image.Save(caminhoImagemSalva, ImageFormat.Jpeg);
                MessageBox.Show("Imagem salva com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
    }
}
