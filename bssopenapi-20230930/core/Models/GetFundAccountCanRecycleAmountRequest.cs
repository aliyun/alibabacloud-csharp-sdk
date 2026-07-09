// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanRecycleAmountRequest : TeaModel {
        /// <summary>
        /// <para>The currency.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The ID of the source account (payer account) from which funds are reclaimed. If not specified, the account ID owned by the current account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122321223</para>
        /// </summary>
        [NameInMap("RecycleFromFundAccountId")]
        [Validation(Required=false)]
        public string RecycleFromFundAccountId { get; set; }

    }

}
