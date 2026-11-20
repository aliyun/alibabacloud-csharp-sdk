// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingBillSummaryRespDTO : TeaModel {
        /// <summary>
        /// <para>The list of cost trend data points.</para>
        /// </summary>
        [NameInMap("points")]
        [Validation(Required=false)]
        public List<BillingBillSummaryPointDTO> Points { get; set; }

        /// <summary>
        /// <para>The total cost within the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123.45</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public float? TotalAmount { get; set; }

    }

}
