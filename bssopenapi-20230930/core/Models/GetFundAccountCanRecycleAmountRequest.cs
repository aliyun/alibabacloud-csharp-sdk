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
        /// <para>The ID of the source account for reclamation (the payer account ID). If this parameter is not specified, the ID of the account owned by the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122321223</para>
        /// </summary>
        [NameInMap("RecycleFromFundAccountId")]
        [Validation(Required=false)]
        public string RecycleFromFundAccountId { get; set; }

    }

}
