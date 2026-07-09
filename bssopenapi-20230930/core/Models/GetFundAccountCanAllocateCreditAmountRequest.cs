// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanAllocateCreditAmountRequest : TeaModel {
        /// <summary>
        /// <para>Fund account ID. If not specified, the account owned by the current account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1233231</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

    }

}
