using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SQLLoader
{
    [RunInstaller(true)]
    public partial class LoadSql : System.Configuration.Install.Installer
    {
        //Kullanıcının bilgisayarının Belgelerim klasöründe yükleyeceğim SQLEXPR.exe dosyasının yolu tanımlanıyor.

        public static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SQL2019-SSEI-Expr.exe";

        void CopyStream(Stream readStream, Stream writeStream)

        {

            //readStream nesnesi writeStream nesnesine byte'lar halinde kopyalanacaktır.Bu amaçla buffer dizisi tanımlanmıştır.

            byte[] buffer = new byte[256];

            //readStream nesnesinden her seferde 256 byte okunarak buffer dizine atılmaya çalışılmaktadır.

            int bufferLength = readStream.Read(buffer, 0, 256);

            //Eğer konunan Steram'de hala okunacak byte kaldıysan okumaya devam et

            while (bufferLength > 0)

            {

                //okunan bölümü yazılacak stream'e yaz

                writeStream.Write(buffer, 0, bufferLength);

                bufferLength = readStream.Read(buffer, 0, 256);

            }

            writeStream.Close();

            readStream.Close();
        }
        public LoadSql()
        {
            InitializeComponent();

            InitializeComponent();

            //yazılacak stream tanımlanıyor.

            FileStream fs = new FileStream(path, FileMode.Create);

            //SQLLoader projesi içerinde dll'e gömülen resource nesnemize ulaşmak için namespace.klasör.dosya yolunu kullanıyoruz.

            Stream readStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SQLLoader.SQL2019-SSEI-Expr.exe");

            //Böylece Assebmbly içerisine gömülen kurulum dosyamız tekrar kullanıcın Belgelerim klasörü içerinde fiziksel olarak oluşturulmaktadır.

            CopyStream(readStream, fs);
        
        }
    }
}