using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Memory
    {

        public string Data { get; set; }
        public int Size { get; set; }
        public void Write(string data, int size)
        {
            Data = data;
            Size = size;
        }
        public void Show()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Data  - > {Data} - size - > {Size}");
        }
    }
    class AudioDevice
    {
        public AudioDevice(bool ısenabled)
        {
            Enable = ısenabled;
        }

        public bool Enable { get; set; }
        public bool IsEnabled()
        {
            return Enable;
        }
    }

    class VideoFacade
    {
        public void Play(string filename)
        {
            AudioDevice device = new AudioDevice(false);
            Memory memory = new Memory();
            memory.Write("best music", 2000);
            if (device.IsEnabled())
            {
                memory.Show();

            }
            else
            {
                throw new Exception("Audio does not work");
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            VideoFacade facade = new VideoFacade();
            try
            {
                facade.Play("data.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Reason - > {ex.Message}");
            }

        }
    }
}
