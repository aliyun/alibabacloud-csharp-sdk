// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingBillSummaryPointDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.23</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public float? TotalAmount { get; set; }

    }

}
