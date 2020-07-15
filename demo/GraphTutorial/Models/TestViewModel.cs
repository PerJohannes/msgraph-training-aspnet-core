using System;

namespace GraphTutorial.Models
{
    public class TestViewModel
    {
        public string TestString { get; set; }

        public bool ShowTestString => !string.IsNullOrEmpty(TestString);
    }
}