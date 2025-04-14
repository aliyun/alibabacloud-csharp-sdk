// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SetFundAccountLowAvailableAmountAlarmRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12321213</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ThresholdAmount")]
        [Validation(Required=false)]
        public string ThresholdAmount { get; set; }

    }

}
