using Machine.Specifications;

namespace kata.specs
{
    public class when_running_a_test
    {
        static string _result;

        Because of =
            () => _result = "hello".ToUpper();

        It should_pass =
            () => _result.ShouldEqual("HELLO");
    }
}