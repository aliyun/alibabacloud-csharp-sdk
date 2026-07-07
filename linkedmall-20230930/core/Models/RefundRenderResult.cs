// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundRenderResult : TeaModel {
        /// <summary>
        /// <para>The return methods supported for the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("maxRefundFeeData")]
        [Validation(Required=false)]
        public DistributionMaxRefundFee MaxRefundFeeData { get; set; }

        /// <summary>
        /// <para>The ID of the sub-distribution order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <para>A collection of refund reasons.</para>
        /// </summary>
        [NameInMap("refundReasonList")]
        [Validation(Required=false)]
        public List<RefundReason> RefundReasonList { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
