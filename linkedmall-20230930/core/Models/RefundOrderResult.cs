// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundOrderResult : TeaModel {
        /// <summary>
        /// <para>Dispute ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6693****4352</para>
        /// </summary>
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// <para>Status of the reverse operation<br>1 – Return pending<br>2 – Awaiting buyer return<br>3 – Awaiting merchant receipt<br>4 – Refund closed<br>5 – Refund succeeded<br>6 – Refund denied<br>17 – Canceling refund</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("disputeStatus")]
        [Validation(Required=false)]
        public int? DisputeStatus { get; set; }

        /// <summary>
        /// <para>Sub-distribution order ID for which the reverse operation was initiated</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <para>API request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
