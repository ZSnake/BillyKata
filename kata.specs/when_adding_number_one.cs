using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_a_number_one
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("1"); };

        private It should_return_one = () => { _return.ShouldBeLike(1); };
    }
}
