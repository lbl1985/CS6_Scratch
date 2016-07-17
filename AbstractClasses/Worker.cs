using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Worker
    {
        public Worker()
        {
            work();
        }

        public void work()
        {
            List<Control> controls = new List<Control>();

            Button button = new Button(0, 100, "Click the button");

            ListBox listBox = new ListBox(100, 300, new List<string>());

            Button cancelButton = new Button(150, 100, "cancel");

            controls.Add(button);
            controls.Add(listBox);
            controls.Add(cancelButton);

            foreach (Control control in controls)
            {
                control.Draw();
            }

        }
    }
}
