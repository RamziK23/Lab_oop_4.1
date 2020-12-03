using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_oop_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p = 0; 
        static int k = 5; 
        Storage storag = new Storage(k); 
        static int index = 0; 
        int indexin = 0; 

        class Circle
        {
            public int x, y; 
            public int rad = 15; 
            public Color color = Color.Navy;
            public bool is_drawed = true; 
            public Circle()
            {
                x = 0;
                y = 0;
            }
            public Circle(int x, int y)
            {
                this.x = x - rad;
                this.y = y - rad;
            }
            ~Circle() { }
        }

        class Storage
        {
            public Circle[] objects;
            public Storage(int count)
            {  
                
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void initialisat(int count)
            {   
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void add_object(int ind, ref Circle object1, int count, ref int indexin)
            {  
                while (objects[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                objects[ind] = object1;
                indexin = ind;
            }
            public void delete_object(int ind)
            {   
                objects[ind] = null;
                index--;
            }
            public bool check_empty(int index)
            {   
                if (objects[index] == null)
                    return true;
                else return false;
            }
            public int occupied(int size)
            {
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!check_empty(i))
                        ++count_occupied;
                return count_occupied;
            }
            public void doubleSize(ref int size)
            {   
                Storage storage1 = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                    storage1.objects[i] = objects[i];
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size * 2;
                initialisat(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = storage1.objects[i];
            }
            ~Storage() { }
        };



        private void button_show_Click(object sender, EventArgs e)
        {

        }

        private void button_deletestorage_Click(object sender, EventArgs e)
        {

        }

        private void button_del__item_storage_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_paintbox_Click(object sender, EventArgs e)
        {

        }
    }
}
