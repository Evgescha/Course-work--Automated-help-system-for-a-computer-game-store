using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_help_system_for_a_computer_game_store
{
    public class Helper
    {
        private static DialogResult DialogResult;
        public bool isNumberOrControlChar(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                return true;            
            return false;
        }
        public bool isRemove()
        {
            return (DialogResult = MessageBox.Show("Удалить выбранное?", "Удаление", MessageBoxButtons.YesNo)) == DialogResult.Yes;
        }
        public void AddedMessage() {
            MessageBox.Show("Добавлено");
        }
        public void UpdatedMessage()
        {
            MessageBox.Show("Обновлено");
        }
        public void RemovedMessage()
        {
            MessageBox.Show("Удалено");
        }
        public void ErrorMessage(String error)
        {
            MessageBox.Show("Ошибка выполнения команды.\r\n"+error);
        }
    }
}
