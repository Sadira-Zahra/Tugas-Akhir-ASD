using System;
using System.Collections;
using System.Collections.Generic;

namespace Tugas_Akhir_ASD
{
    internal class Program
    {
        private class Jadwal
        {
            public string NamaRuangan { get; set; }
            public string Angkatan { get; set; }
            public string Hari { get; set; }
            public string Prodi { get; set; }
        }
        private static List<Jadwal> daftarJadwal = new List<Jadwal>();
        private static Dictionary<string, string> namaHari = new Dictionary<string, string>
        {
            {"1", "Senin"},
            {"2", "Selasa"},
            {"3", "Rabu"},
            {"4", "Kamis"},
            {"5", "Jumat"}
        };
        private static Dictionary<string, string> namaProdi = new Dictionary<string, string>
        {
            {"AB01", "ABO1"},
            {"AB02", "ABO2"},
            {"SA01", "SIIO1"},
            {"SA02", "SIIO2"},
            {"SA03", "SIIO3"},
            {"TI01", "TIO1"},
            {"TI02", "TIO2"},
            {"TR01", "TRO1"},
            {"TR02", "TRO2"},
            {"TK01", "TKP1"},
            {"TK02", "TKP2"}
        };

        static void Main(string[] args)
        {
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2021", Prodi = "AB01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2021", Prodi = "AB01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2021", Prodi = "AB01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2021", Prodi = "AB01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2021", Prodi = "AB01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2021", Prodi = "AB02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2021", Prodi = "AB02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2021", Prodi = "AB02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2021", Prodi = "AB02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A24", Angkatan = "2021", Prodi = "AB02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2021", Prodi = "SA01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A24", Angkatan = "2021", Prodi = "SA01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2021", Prodi = "SA01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2021", Prodi = "SA01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2021", Prodi = "SA01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2021", Prodi = "SA02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2021", Prodi = "SA02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2021", Prodi = "SA02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2021", Prodi = "SA02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2021", Prodi = "SA02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2021", Prodi = "TI01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2021", Prodi = "TI01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2021", Prodi = "TI01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2021", Prodi = "TI01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2021", Prodi = "TI01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2021", Prodi = "TI02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2021", Prodi = "TI02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2021", Prodi = "TI02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2021", Prodi = "TI02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2021", Prodi = "TI02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2021", Prodi = "TK01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2021", Prodi = "TK01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2021", Prodi = "TK01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2021", Prodi = "TK01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2021", Prodi = "TK01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2021", Prodi = "TK02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2021", Prodi = "TK02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2021", Prodi = "TK02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2021", Prodi = "TK02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2021", Prodi = "TK02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2021", Prodi = "TR01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2021", Prodi = "TR01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2021", Prodi = "TR01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2021", Prodi = "TR01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2021", Prodi = "TR01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2021", Prodi = "TR02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2021", Prodi = "TR02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2021", Prodi = "TR02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2021", Prodi = "TR02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2021", Prodi = "TR02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A24", Angkatan = "2022", Prodi = "AB01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2022", Prodi = "AB01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2022", Prodi = "AB01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2022", Prodi = "AB01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2022", Prodi = "AB01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2022", Prodi = "AB02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2022", Prodi = "AB02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2022", Prodi = "AB02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2022", Prodi = "AB02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2022", Prodi = "AB02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A24", Angkatan = "2022", Prodi = "SA01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2022", Prodi = "SA01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2022", Prodi = "SA01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2022", Prodi = "SA01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2022", Prodi = "SA01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2022", Prodi = "SA02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2022", Prodi = "SA02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2022", Prodi = "SA02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2022", Prodi = "SA02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2022", Prodi = "SA02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2022", Prodi = "TI01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2022", Prodi = "TI01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2022", Prodi = "TI01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2022", Prodi = "TI01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2022", Prodi = "TI01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2022", Prodi = "TI02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2022", Prodi = "TI02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2022", Prodi = "TI02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2022", Prodi = "TI02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2022", Prodi = "TI02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2022", Prodi = "TK01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2022", Prodi = "TK01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2022", Prodi = "TK01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2022", Prodi = "TK01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2022", Prodi = "TK01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2022", Prodi = "TK02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2022", Prodi = "TK02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2022", Prodi = "TK02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2022", Prodi = "TK02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2022", Prodi = "TK02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2022", Prodi = "TR01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2022", Prodi = "TR01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2022", Prodi = "TR01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A24", Angkatan = "2022", Prodi = "TR01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2022", Prodi = "TR01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2022", Prodi = "TR02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2022", Prodi = "TR02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2022", Prodi = "TR02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2022", Prodi = "TR02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2022", Prodi = "TR02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2023", Prodi = "AB01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2023", Prodi = "AB01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2023", Prodi = "AB01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2023", Prodi = "AB01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2023", Prodi = "AB01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2023", Prodi = "AB02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2023", Prodi = "AB02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2023", Prodi = "AB02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2023", Prodi = "AB02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2023", Prodi = "AB02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2023", Prodi = "SA01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A32", Angkatan = "2023", Prodi = "SA01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A42", Angkatan = "2023", Prodi = "SA01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2023", Prodi = "SA01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2023", Prodi = "SA01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A21", Angkatan = "2023", Prodi = "SA02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A36", Angkatan = "2023", Prodi = "SA02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A26", Angkatan = "2023", Prodi = "SA02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2023", Prodi = "SA02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A22", Angkatan = "2023", Prodi = "SA02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2023", Prodi = "SA03", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A31", Angkatan = "2023", Prodi = "SA03", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A25", Angkatan = "2023", Prodi = "SA03", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A54", Angkatan = "2023", Prodi = "SA03", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2023", Prodi = "SA03", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2023", Prodi = "TI01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2023", Prodi = "TI01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2023", Prodi = "TI01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2023", Prodi = "TI01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2023", Prodi = "TI01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2023", Prodi = "TI02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2023", Prodi = "TI02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A52", Angkatan = "2023", Prodi = "TI02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2023", Prodi = "TI02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2023", Prodi = "TI02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2023", Prodi = "TK01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A23", Angkatan = "2023", Prodi = "TK01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A33", Angkatan = "2023", Prodi = "TK01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2023", Prodi = "TK01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B22", Angkatan = "2023", Prodi = "TK01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2023", Prodi = "TK02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B32", Angkatan = "2023", Prodi = "TK02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A51", Angkatan = "2023", Prodi = "TK02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2023", Prodi = "TK02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2023", Prodi = "TK02", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A53", Angkatan = "2023", Prodi = "TR01", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "A41", Angkatan = "2023", Prodi = "TR01", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2023", Prodi = "TR01", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2023", Prodi = "TR01", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B41", Angkatan = "2023", Prodi = "TR01", Hari = "5" });

            daftarJadwal.Add(new Jadwal { NamaRuangan = "A35", Angkatan = "2023", Prodi = "TR02", Hari = "1" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B31", Angkatan = "2023", Prodi = "TR02", Hari = "2" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B42", Angkatan = "2023", Prodi = "TR02", Hari = "3" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "B21", Angkatan = "2023", Prodi = "TR02", Hari = "4" });
            daftarJadwal.Add(new Jadwal { NamaRuangan = "C21", Angkatan = "2023", Prodi = "TR02", Hari = "5" });

            while (true)
            {
                Console.WriteLine("Pilih Opsi:");
                Console.WriteLine("1. Lihat Seluruh Jadwal Ruang Kelas");
                Console.WriteLine("2. Lihat Jadwal Ruang Kelas");
                Console.WriteLine("3. Lihat Ruangan Digunakan");
                Console.WriteLine("4. Booking Ruangan");
                Console.WriteLine("5. Hapus Jadwal");
                Console.WriteLine("6. Keluar");

                Console.Write("Masukkan pilihan (1/2/3/4/5) : ");
                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        LihatSemuaJadwal();
                        break;
                    case 2:
                        LihatJadwalKelas();
                        break;
                    case 3:
                        LihatRuangan();
                        break;
                    case 4:
                        BookingRuangan();
                        break;
                    case 5:
                        HapusJadwal();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }

        static void LihatJadwalKelas()
        {
            Console.Write("Masukkan Angkatan : ");
            string inputAngkatan = Console.ReadLine();
            Console.Write("Masukkan Kode Prodi : ");
            string inputProdi = Console.ReadLine();
            Console.Write("Masukkan Hari (1-5) : ");
            string inputHari = Console.ReadLine();
            Console.WriteLine();

            var jadwalDitemukan = daftarJadwal.FindAll(j => j.Angkatan == inputAngkatan && j.Prodi == inputProdi && j.Hari == inputHari);

            if (jadwalDitemukan.Count > 0)
            {
                Console.WriteLine("Jadwal Kelas:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("| Nama Ruangan  | Angkatan | Hari      |");
                Console.WriteLine("----------------------------------------");

                foreach (var jadwal in jadwalDitemukan)
                {
                    Console.WriteLine($"| {jadwal.NamaRuangan,-13} | {jadwal.Angkatan,-8} | {namaHari[jadwal.Hari],-9} |");
                }
                    
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine("Tidak Ada Kelas Hari Ini");
            }

            Console.WriteLine();
        }

        static void LihatRuangan()
        {
            Console.Write("Masukkan Kode Ruangan : ");
            string inputRuangan = Console.ReadLine();
            Console.WriteLine();

            var jadwalDitemukan = daftarJadwal.FindAll(j => j.NamaRuangan == inputRuangan);

            if (jadwalDitemukan.Count > 0)
            {
                Console.WriteLine($"Ruangan {inputRuangan} digunakan oleh:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("| Prodi         | Angkatan | Hari      |");
                Console.WriteLine("----------------------------------------");

                foreach (var jadwal in jadwalDitemukan)
                {
                    Console.WriteLine($"| {namaProdi[jadwal.Prodi],-13} | {jadwal.Angkatan,-8} | {namaHari[jadwal.Hari],-9} |");
                }

                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine($"Ruangan {inputRuangan} tidak digunakan.");
            }

            Console.WriteLine();
        }

        static void BookingRuangan()
        {
            Console.Write("Masukkan Kode Ruangan yang ingin dipesan : ");
            string inputRuangan = Console.ReadLine();
            Console.Write("Masukkan Kode Prodi untuk kelas tambahan : ");
            string inputProdi = Console.ReadLine();
            Console.Write("Masukkan Kode Angkatan untuk kelas tambahan : ");
            string inputAngkatan = Console.ReadLine();
            Console.Write("Masukkan Hari (1-5) untuk kelas tambahan : ");
            string inputHari = Console.ReadLine();
            Console.WriteLine();

            var jumlahKelas = daftarJadwal.Count(j => j.NamaRuangan == inputRuangan && j.Hari == inputHari);

            if (jumlahKelas < 3)
            {
                daftarJadwal.Add(new Jadwal { NamaRuangan = inputRuangan, Angkatan = inputAngkatan, Prodi = inputProdi, Hari = inputHari});
                Console.WriteLine($"Ruangan {inputRuangan} berhasil dipesan untuk kelas tambahan pada hari {namaHari[inputHari]}.");
            }
            else
            {
                Console.WriteLine($"Ruangan {inputRuangan} sudah terisi 3 kali pada hari {namaHari[inputHari]}. Pilih hari lain.");
            }
        }

        static void HapusJadwal()
        {
            Console.Write("Masukkan Kode Ruangan yang ingin dihapus jadwalnya : ");
            string inputRuangan = Console.ReadLine();
            Console.Write("Masukkan Kode Angkatan yang ingin dihapus jadwalnya : ");
            string inputAngkatan = Console.ReadLine();
            Console.Write("Masukkan Kode Prodi yang ingin dihapus jadwalnya : ");
            string inputProdi = Console.ReadLine();
            Console.Write("Masukkan Hari (1-5) yang ingin dihapus jadwalnya : ");
            string inputHari = Console.ReadLine();
            Console.WriteLine();

            var jadwalDitemukan = daftarJadwal.FindAll(j => j.NamaRuangan == inputRuangan && j.Angkatan == inputAngkatan && j.Prodi == inputProdi && j.Hari == inputHari);

            if (jadwalDitemukan.Count > 0)
            {
                daftarJadwal.RemoveAll(j => j.NamaRuangan == inputRuangan && j.Angkatan == inputAngkatan && j.Prodi == inputProdi && j.Hari == inputHari);
                Console.WriteLine($"Jadwal dihapus untuk Ruangan {inputRuangan}, Angkatan {inputAngkatan}, Prodi {inputProdi}, Hari {inputHari}.");
            }
            else
            {
                Console.WriteLine($"Tidak ada jadwal untuk Ruangan {inputRuangan}, Angkatan {inputAngkatan}, Prodi {inputProdi}, Hari {inputHari}.");
            }
            Console.WriteLine();
        }

        static void LihatSemuaJadwal()
        {
            if (daftarJadwal.Count > 0)
            {
                Console.WriteLine("Semua Jadwal Ruangan:");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("| Nama Ruangan  | Angkatan | Hari      | Prodi              |");
                Console.WriteLine("-------------------------------------------------------------");

                foreach (var jadwal in daftarJadwal)
                {
                    Console.WriteLine($"| {jadwal.NamaRuangan,-13} | {jadwal.Angkatan,-8} | {namaHari[jadwal.Hari],-9} | {namaProdi[jadwal.Prodi],-19}|");
                }

                Console.WriteLine("-------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Tidak Ada Jadwal Ruangan.");
            }

            Console.WriteLine();
        }

    }
}
