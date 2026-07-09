// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountAvailableAmountRequest : TeaModel {
        /// <summary>
        /// <para>Account ID. If not specified, the account ID owned by the current account (owner) is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public string FundAccountId { get; set; }

    }

}
