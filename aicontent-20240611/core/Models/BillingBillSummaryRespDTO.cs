// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingBillSummaryRespDTO : TeaModel {
        [NameInMap("points")]
        [Validation(Required=false)]
        public List<BillingBillSummaryPointDTO> Points { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123.45</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public float? TotalAmount { get; set; }

    }

}
