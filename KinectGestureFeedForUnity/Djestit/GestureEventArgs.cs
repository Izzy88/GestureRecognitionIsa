﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GestureForKinect.Djestit
{
    public class GestureEventArgs : EventArgs
    {
        /* Attributi */
        public readonly Term term;
        public readonly Token token;

        /* Costruttore */
        public GestureEventArgs(Term term, Token token)
        {
            this.term = term;
            this.token = token;
        }
    }
}
