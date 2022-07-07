using System;
using Xunit;
using FluentAssertions;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Services;
using NSubstitute;

namespace TestProject1
{
    public class ConvertorTest
    {
        [Fact]
        public async Task Test1()
        {
            var input = new char[] { 'K', 'O' };
            var expectedResult = new List<int> { 150, 158 };

            var convertorService = new ConvertorService(); 
            var result = convertorService.Convert(input).ToList();

            result.Should().Equal(expectedResult);
        }
    }
}
