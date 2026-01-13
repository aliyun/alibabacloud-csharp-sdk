// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class GetMeteringSummaryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>202505</para>
        /// </summary>
        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        [NameInMap("billingItem")]
        [Validation(Required=false)]
        public string BillingItem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20250522</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20240920</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2312312312312</para>
        /// </summary>
        [NameInMap("subAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

    }

}
