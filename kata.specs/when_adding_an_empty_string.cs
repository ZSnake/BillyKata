using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_an_empty_string
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add(""); };

        private It should_return_0 = () => { _return.ShouldBeLike(0); };
    }
}