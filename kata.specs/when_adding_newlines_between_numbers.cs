using System;
using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_newlines_between_numbers
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("1,3\n5,4"); };

        private It should_return_thirteen = () => { _return.ShouldBeLike(13); };
    }
}
