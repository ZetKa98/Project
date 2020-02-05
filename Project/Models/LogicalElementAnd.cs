﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class LogicalElementAnd : LogicalElementBase
    {
        private Boolean entryOne;
        public  Boolean EntryOne
        {
            get 
            { 
                return entryOne; 
            }
            set 
            { 
                entryOne = value;
            }
        }

        private Boolean entryTwo;
        public Boolean EntryTwo
        {
            get
            {
                return entryTwo;
            }
            set
            {
                entryTwo = value;
            }
        }

        public override Boolean ReturnedValue
        {
            get
            {
                return entryOne & entryTwo;
            }
        }
    }
}
