using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface IConvertorService
    {
        IEnumerable<int> Convert(IEnumerable<char> input);
    }

    public class ConvertorService: IConvertorService
    {
        public IEnumerable<int> Convert(IEnumerable<char> input)
        {
            return input.Select(entry => entry < 'h' || entry < 'H' ? ((int)entry) * 2 : 0);
        }
    }
}
