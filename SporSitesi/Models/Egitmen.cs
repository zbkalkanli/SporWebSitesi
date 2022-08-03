using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SporSitesi.Models
{
    public class Egitmen
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public Sporlar VerdigiDersler { get; set; }
        public Sporlar IlgilendigiSporlar { get; set; }
        public string ProfilResmiUrl { get; set; }
        public int Puan { get; set; }
        public string Hakkinda { get; set; }
        public string Sertifikalari { get; set; }
        public DateTime MusaitVakitleri { get; set; }
        public bool Cevrimici { get; set; }
        [ForeignKey("Adres")]
        public int AdresId { get; set; }
    }
    public enum Sporlar
    {
        avcılık,
        badminton,
        bale,
        dans,
        balıkçılık,
        basketbol,
        binicilik,
        bisiklet,
        boks,
        bushcraft,
        dalis,
        fitnessKardiyo,
        futbol,
        golf,
        hentbol,
        hiking,
        trekking,
        outdoor,
        jimnastik,
        trambolin,
        kamp,
        kano,
        kayak,
        snowboard,
        kitesurf,
        kosu,
        masaTenisi,
        okculuk,
        oryantiring,
        paten,
        kaykay,
        scooter,
        pilates,
        fitness,
        plajTenisi,
        speedBall,
        sorf,
        squash,
        tenis,
        tirmanis,
        dagcilik,
        voleybol,
        bodyBuilding,
        yelken,
        yoga,
        yuruyus,
        yuzme
    }
}
