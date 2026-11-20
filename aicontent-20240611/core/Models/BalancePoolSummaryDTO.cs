// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BalancePoolSummaryDTO : TeaModel {
        /// <summary>
        /// <para>The balance allocated to users equals the sum of the sub-wallet balances of all members in the department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40.00</para>
        /// </summary>
        [NameInMap("allocated")]
        [Validation(Required=false)]
        public double? Allocated { get; set; }

        /// <summary>
        /// <para>The available department balance equals the sub-wallet balance of the department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.00</para>
        /// </summary>
        [NameInMap("available")]
        [Validation(Required=false)]
        public double? Available { get; set; }

        /// <summary>
        /// <para>The total amount equals the available department balance plus the balance allocated to users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public double? Total { get; set; }

    }

}
