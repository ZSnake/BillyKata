using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_a_number_five
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("5"); };

        private It should_return_five = () => { _return.ShouldBeLike(5); };
    }
}