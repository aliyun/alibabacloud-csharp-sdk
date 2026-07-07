// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundResult : TeaModel {
        /// <summary>
        /// <para>Current buyer\&quot;s refund request description</para>
        /// 
        /// <b>Example:</b>
        /// <para>多拍不想要</para>
        /// </summary>
        [NameInMap("applyDisputeDesc")]
        [Validation(Required=false)]
        public string ApplyDisputeDesc { get; set; }

        /// <summary>
        /// <para>Request reason</para>
        /// </summary>
        [NameInMap("applyReason")]
        [Validation(Required=false)]
        public ApplyReason ApplyReason { get; set; }

        /// <summary>
        /// <para>Order return method<br>1 – identity indicates refund only<br>3 – identity indicates return and refund</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        /// <summary>
        /// <para>Dispute creation time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-15T19:23:59.000+08:00</para>
        /// </summary>
        [NameInMap("disputeCreateTime")]
        [Validation(Required=false)]
        public string DisputeCreateTime { get; set; }

        /// <summary>
        /// <para>Reverse request description</para>
        /// 
        /// <b>Example:</b>
        /// <para>多拍不想要</para>
        /// </summary>
        [NameInMap("disputeDesc")]
        [Validation(Required=false)]
        public string DisputeDesc { get; set; }

        /// <summary>
        /// <para>Reverse process end time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-15T19:23:59.000+08:00</para>
        /// </summary>
        [NameInMap("disputeEndTime")]
        [Validation(Required=false)]
        public string DisputeEndTime { get; set; }

        /// <summary>
        /// <para>Reverse order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6693****4352</para>
        /// </summary>
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// <para>Reverse order status<br>1 – Return pending<br>2 – Awaiting buyer return<br>3 – Awaiting merchant receipt<br>4 – Refund shutdown<br>5 – Refund succeeded<br>6 – Refund denied<br>17 – Canceling refund</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("disputeStatus")]
        [Validation(Required=false)]
        public int? DisputeStatus { get; set; }

        /// <summary>
        /// <para>Main order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Sub-order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <para>Order logistics status<br>1 – Not shipped → Awaiting seller shipment<br>2 – Shipped → Awaiting buyer confirmation of receipt<br>3 – Received → Transaction succeeded<br>6 – Partially shipping<br>8 – Logistics order not yet created</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orderLogisticsStatus")]
        [Validation(Required=false)]
        public int? OrderLogisticsStatus { get; set; }

        /// <summary>
        /// <para>Refund amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("refundFee")]
        [Validation(Required=false)]
        public long? RefundFee { get; set; }

        /// <summary>
        /// <para>Refund period</para>
        /// </summary>
        [NameInMap("refundFeeData")]
        [Validation(Required=false)]
        public RefundFeeData RefundFeeData { get; set; }

        /// <summary>
        /// <para>Merchant return address (available when disputeStatus=2, indicating the status is pending buyer return; save the return address during this status if needed)</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云谷</para>
        /// </summary>
        [NameInMap("refunderAddress")]
        [Validation(Required=false)]
        public string RefunderAddress { get; set; }

        /// <summary>
        /// <para>Return recipient name</para>
        /// 
        /// <b>Example:</b>
        /// <para>赵先生</para>
        /// </summary>
        [NameInMap("refunderName")]
        [Validation(Required=false)]
        public string RefunderName { get; set; }

        /// <summary>
        /// <para>Return contact information</para>
        /// 
        /// <b>Example:</b>
        /// <para>182****1334</para>
        /// </summary>
        [NameInMap("refunderTel")]
        [Validation(Required=false)]
        public string RefunderTel { get; set; }

        /// <summary>
        /// <para>Return address ZIP code</para>
        /// 
        /// <b>Example:</b>
        /// <para>331001</para>
        /// </summary>
        [NameInMap("refunderZipCode")]
        [Validation(Required=false)]
        public string RefunderZipCode { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return logistics status<br>0 – Return not initiated<br>1 – Awaiting pickup<br>2 – Package picked up<br>3 – In transit<br>4 – Out for delivery<br>5 – Delivered<br>6 – Delivery failed</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("returnGoodLogisticsStatus")]
        [Validation(Required=false)]
        public int? ReturnGoodLogisticsStatus { get; set; }

        /// <summary>
        /// <para>Seller’s return approval message</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意退款</para>
        /// </summary>
        [NameInMap("sellerAgreeMsg")]
        [Validation(Required=false)]
        public string SellerAgreeMsg { get; set; }

        /// <summary>
        /// <para>Merchant\&quot;s message explaining the denial</para>
        /// 
        /// <b>Example:</b>
        /// <para>不同意退款</para>
        /// </summary>
        [NameInMap("sellerRefuseAgreementMessage")]
        [Validation(Required=false)]
        public string SellerRefuseAgreementMessage { get; set; }

        /// <summary>
        /// <para>Merchant denial reason</para>
        /// 
        /// <b>Example:</b>
        /// <para>商品没问题，买家举证无效</para>
        /// </summary>
        [NameInMap("sellerRefuseReason")]
        [Validation(Required=false)]
        public string SellerRefuseReason { get; set; }

    }

}
