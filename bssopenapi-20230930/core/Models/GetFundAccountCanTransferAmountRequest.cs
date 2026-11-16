// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanTransferAmountRequest : TeaModel {
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
        /// <para>The ID of the source fund account. If you do not specify this parameter, the ID of the fund account owned by the current account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123212</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public string FundAccountId { get; set; }

    }

}
