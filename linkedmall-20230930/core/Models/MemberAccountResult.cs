// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class MemberAccountResult : TeaModel {
        /// <summary>
        /// <para>The signed and bound Alipay auto-debit account (masked).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;yue***@newburn.cn&quot;]</para>
        /// </summary>
        [NameInMap("accountNo")]
        [Validation(Required=false)]
        public List<string> AccountNo { get; set; }

        /// <summary>
        /// <para>The store ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

    }

}
