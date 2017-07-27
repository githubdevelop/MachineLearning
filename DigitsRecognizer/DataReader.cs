using System;
using System.IO;
using System.Linq;

namespace DigitsRecognizer
{
    public class DataReader
    {
        public static Observation[] ReadObservations(string dataPath)
        {
            var data = File.ReadAllLines(path: dataPath).Skip(1).Select(ObservationFactory).ToArray();
            return data;
        }

        private static Observation ObservationFactory(string data)
        {
            var commaSeparated = data.Split(',');
            var label = commaSeparated[0];
            var pixels = commaSeparated.Skip(1).Select(x => Convert.ToInt32(x)).ToArray();
            return new Observation(label, pixels);
        }
    }
}
