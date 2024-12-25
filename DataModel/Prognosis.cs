namespace WpfApp2.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    public partial class Prognosis
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public string Time { get; set; }

        public Prognosis()
        {

        }

        public Prognosis(DateTime? date, string time)
        {
            Date = date;
            Time = time;
        }
    }
}
