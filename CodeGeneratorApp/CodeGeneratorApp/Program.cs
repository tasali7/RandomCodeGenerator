// See https://aka.ms/new-console-template for more information




int numberOfCodes = 10; // Oluşturulacak kod sayısı
int codeLength = 8; // Kod uzunluğu
string characters = "ACDEFGHKLMNPRTXYZ234579"; // Kod karakter kümesi

List<string> generatedCodes = GenerateUniqueCodes(numberOfCodes, codeLength, characters);

// Oluşturulan kodları ekrana yazdırma
foreach (string code in generatedCodes)
{
    Console.WriteLine(code);
}


// Unique kodları oluşturan fonksiyon
static List<string> GenerateUniqueCodes(int numberOfCodes, int codeLength, string characters)
{
    HashSet<string> generatedCodes = new HashSet<string>(); // Oluşturulan kodları saklayacak küme
    List<string> result = new List<string>(); // Sonuç listesi

    Random random = new Random();

    while (generatedCodes.Count < numberOfCodes)
    {
        char[] codeArray = new char[codeLength];

        // Kodu oluşturma
        for (int i = 0; i < codeLength; i++)
        {
            int randomIndex = random.Next(characters.Length);
            codeArray[i] = characters[randomIndex];
        }

        string code = new string(codeArray);

        // Unique olup olmadığını kontrol etme
        if (!generatedCodes.Contains(code))
        {
            generatedCodes.Add(code);
            result.Add(code);
        }
    }

    return result;
}