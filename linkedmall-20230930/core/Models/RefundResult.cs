// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundResult : TeaModel {
        [NameInMap("applyDisputeDesc")]
        [Validation(Required=false)]
        public string ApplyDisputeDesc { get; set; }

        [NameInMap("applyReason")]
        [Validation(Required=false)]
        public ApplyReason ApplyReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-02T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("disputeCreateTime")]
        [Validation(Required=false)]
        public string DisputeCreateTime { get; set; }

        [NameInMap("disputeDesc")]
        [Validation(Required=false)]
        public string DisputeDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-02T12:00:00.000Z</para>
        /// </summary>
        [NameInMap("disputeEndTime")]
        [Validation(Required=false)]
        public string DisputeEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6693****4352</para>
        /// </summary>
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("disputeStatus")]
        [Validation(Required=false)]
        public int? DisputeStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orderLogisticsStatus")]
        [Validation(Required=false)]
        public int? OrderLogisticsStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("refundFee")]
        [Validation(Required=false)]
        public long? RefundFee { get; set; }

        [NameInMap("refundFeeData")]
        [Validation(Required=false)]
        public RefundFeeData RefundFeeData { get; set; }

        [NameInMap("refunderAddress")]
        [Validation(Required=false)]
        public string RefunderAddress { get; set; }

        [NameInMap("refunderName")]
        [Validation(Required=false)]
        public string RefunderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>182****1334</para>
        /// </summary>
        [NameInMap("refunderTel")]
        [Validation(Required=false)]
        public string RefunderTel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>331001</para>
        /// </summary>
        [NameInMap("refunderZipCode")]
        [Validation(Required=false)]
        public string RefunderZipCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("returnGoodLogisticsStatus")]
        [Validation(Required=false)]
        public int? ReturnGoodLogisticsStatus { get; set; }

        [NameInMap("sellerAgreeMsg")]
        [Validation(Required=false)]
        public string SellerAgreeMsg { get; set; }

        [NameInMap("sellerRefuseAgreementMessage")]
        [Validation(Required=false)]
        public string SellerRefuseAgreementMessage { get; set; }

        [NameInMap("sellerRefuseReason")]
        [Validation(Required=false)]
        public string SellerRefuseReason { get; set; }

    }

}
