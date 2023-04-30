using AljabarLibraries;

double[] APK = { 1, -3, -10 };
double[] HS = { 2, -3 };

double[] AkarPersamaanKuadrat = QuadraticForm.AkarPersamaanKuadrat(APK);
double[] HasilKuadrat = QuadraticForm.HasilKuadrat(HS);

Console.WriteLine("{" + AkarPersamaanKuadrat[0] + ", " + AkarPersamaanKuadrat[1] + "}");
Console.WriteLine("{" + HasilKuadrat[0] + ", " + HasilKuadrat[1] + ", " + HasilKuadrat[2] + "}");