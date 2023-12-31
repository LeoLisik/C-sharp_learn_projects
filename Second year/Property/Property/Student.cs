using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Student
    {
        string _name;
        int _age;
        float _midMark;

        public string Name
        {
            get=>_name;
            set=>_name = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 120 || value < 0)
                {
                    throw new Exception("Неверный возраст");
                }
                _age = value;
            }
        }

        public float MidMark
        {
            get => _midMark;
            set
            {
                if (value > 5 || value < 2)
                {
                    throw new Exception("Неверный средний бал");
                }
                _midMark = value;
            }
        }

        public Student()
        {
            _name = "";
            _age = 0;
            _midMark = 0;
        }
    }
}
