using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Worker
    {
        public Worker()
        {
            work();
        }

        public void work()
        {
            Document doc1 = new Document();
            doc1.Reformat();
            doc1.Read("myFile");
            doc1.Speak();

            IStrorable doc2 = new Document();
            doc2.Read("myFile 2");
            doc2.Write("myFileWrite 2");


            ISpeak doc3 = new Document();
            doc3.Speak();

            Document doc4 = new Memo();
            doc4.Reformat();
            doc4.Read("myFile 4");

            Memo doc5 = new Memo();
            doc5.Read("Myfile 5");
            doc5.Reformat();
            doc5.MemoTo = "Jesse";
        }
    }
}
