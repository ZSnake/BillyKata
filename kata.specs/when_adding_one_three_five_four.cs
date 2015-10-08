using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_one_three_five_four
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("1,3,5,4"); };

        private It should_return_thirteen = () => { _return.ShouldBeLike(13); };
    }
}
