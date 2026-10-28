// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditEndUserStatusRequest : TeaModel {
        /// <summary>
        /// <h3>Shutdown status</h3>
        /// <list type="bullet">
        /// <item><description>postPayFreeze: pay-as-you-go resource suspension</description></item>
        /// <item><description>postPayThaw: pay-as-you-go resource resumption.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>postPayFreeze</para>
        /// </summary>
        [NameInMap("CreditStatus")]
        [Validation(Required=false)]
        public string CreditStatus { get; set; }

        /// <summary>
        /// <para>The UID of the customer to be processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792155717328010</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
