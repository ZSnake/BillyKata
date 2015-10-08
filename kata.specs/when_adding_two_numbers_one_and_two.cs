using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers_one_and_two
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("1,2"); };

        private It should_return_three = () => { _return.ShouldBeLike(3); };
    }
}
