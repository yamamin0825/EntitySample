using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    /// <summary>
    /// キーと値を関連付けるクラス
    /// リストボックスや、コンボボックスのItemsにAddするときに使用する
    /// </summary>
    class KeyValuePair
    {
        int key;
        string val;

        /// <summary>
        /// キーと値を設定するコンストラクタ
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="val">値</param>
        public KeyValuePair(int key, string val)
        {
            this.key = key;
            this.val = val;
        }

        /// <summary>
        /// キー
        /// </summary>
        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        /// <summary>
        /// 値
        /// </summary>
        public string Value
        {
            get { return val; }
            set { val = value; }
        }

        /// <summary>
        /// 表示される値
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return val;
        }
    }
}
