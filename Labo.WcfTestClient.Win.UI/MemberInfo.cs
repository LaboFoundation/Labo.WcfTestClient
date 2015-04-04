using Labo.WcfTestClient.Core.Utils;
using Labo.WcfTestClient.Core.Utils.Reflection;

namespace Labo.WcfTestClient.Win.UI
{
    public sealed class MemberInfo
    {
        public Member Member { get; set; }

        private object m_Value;
        public object Value
        {
            get
            {
                if (m_Value == null)
                {
                    return TypeUtils.GetDefaultValueOfType(Member.Type);
                }
                return m_Value;
            }
            set
            {
                m_Value = value;
            }
        }
    }
}
