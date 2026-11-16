// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountLowAvailableAmountAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the fund account. If this parameter is not specified, the ID of the account owned by the current logon account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

    }

}
