using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZirkuläreListen {

    public class Zirkulator {
        private Entry first, last, current, newValue;
        // Konstanten = unveränderliche Werte!
        private const int standardGroesse = 26;  
        private const int beginnAsCIIBuchstaben = 65;

        /*** Der Konstruktor soll eine zirkuläre, doppelverkettete Liste
         * mit Einträgen des Alphabets bereitstellen
         Die Liste soll in beide Richtungen durchlaufen werden!
         ***/
        public Zirkulator () {
            if ( first == null ) {
                newValue = new Entry () { Value = 'A'};
                first = newValue;
                last = newValue; 
                newValue.Next = first;
                newValue.Prev = first; 
            }
            else {
                for ( int i = 1 ; i < standardGroesse ; i++ ) {
                    char c = ( char ) ( i + beginnAsCIIBuchstaben );
                    AddElement ( c, last );
                }
            }
        }

        // Soll ein Zeichen entgegennehmen und ein Entry in die Liste einfügen
        private void AddElement ( char c, Entry last ) {
            // warum sollte ich mir aufzeichnen, wie es funktioniert
            // es geht doch auch ohne ...
            // have fun ...
            newValue = new Entry () { Value = c };
            last.Next = newValue;
            this.last = newValue;
            newValue.Prev = last;
        }


        // gibt innerhalb der Klasse ein Entry des gesuchten Elements zurück
        private Entry FindEntry(char c) {
            return null;
        }

        // geht von einem gesuchten Entry x Eintragungen in Richtung Nächster
        // und liefert den Entry
        private Entry SkipXForward ( Entry e, int distance) {
            return null;
        }


        // geht von einem gesuchten Entry x Eintragungen in Richtung Vorgänger
        // und liefert den Entry
        private Entry SkipXBackward ( Entry e, int distance ) {
            return null;
        }


        // Soll einmal alles anzeigen ...
        public void ShowValues () {
            this.current = this.first;

            while ( this.current != null ) {
                Console.WriteLine ( current.Value );
                Thread.Sleep ( 1000 );
                this.current = current.Next;
            }
        }


        // inner class = eine Klasse in einer Klasse
        class Entry {
            public char Value { get; set; }
            public Entry Next { get; set; }
            public Entry Prev { get; set; }
        }  // ende Entry
    } // Ende Zirkulator
}
