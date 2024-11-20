using System.Threading.Tasks;
using Testes.Views;

namespace Testes.Utils
{
    public class SomeSource
    {
        private readonly ValueWindow _window;
        public SomeSource()
        {
            _window = new ValueWindow();
        }


        public async Task<string> GetData()
        {
            var tcs = new TaskCompletionSource<string>();
            _window.Show();
            _window.DataEntered += (sender, data) =>
            {
                tcs.TrySetResult(data);
            };
            return await tcs.Task;
        }

        public void Close()
        {
            _window.Close();
        }
    }
}
