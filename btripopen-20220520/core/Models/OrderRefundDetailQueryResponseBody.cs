// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class OrderRefundDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CA36096-1FEE-5756-86DD-D195FEDE080E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public OrderRefundDetailQueryResponseBodyModule Module { get; set; }
        public class OrderRefundDetailQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The order ID on the Zhongzhou platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017002195370467138</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The refund detail records of the order.</para>
            /// </summary>
            [NameInMap("refund_details")]
            [Validation(Required=false)]
            public List<OrderRefundDetailQueryResponseBodyModuleRefundDetails> RefundDetails { get; set; }
            public class OrderRefundDetailQueryResponseBodyModuleRefundDetails : TeaModel {
                /// <summary>
                /// <para>Valid values:</para>
                /// <para>●ALIPAY: Alipay.</para>
                /// <para>●WECHAT: WeChat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIPAY</para>
                /// </summary>
                [NameInMap("person_pay_channel")]
                [Validation(Required=false)]
                public string PersonPayChannel { get; set; }

                /// <summary>
                /// <para>The refund ID for the personal payment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025010223001423691442474885</para>
                /// </summary>
                [NameInMap("person_refund_id")]
                [Validation(Required=false)]
                public string PersonRefundId { get; set; }

                /// <summary>
                /// <para>The refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("refund_amount")]
                [Validation(Required=false)]
                public long? RefundAmount { get; set; }

                /// <summary>
                /// <para>The refund amount for the enterprise portion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4800</para>
                /// </summary>
                [NameInMap("refund_amount_corp")]
                [Validation(Required=false)]
                public long? RefundAmountCorp { get; set; }

                /// <summary>
                /// <para>The refund amount for the personal portion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("refund_amount_person")]
                [Validation(Required=false)]
                public long? RefundAmountPerson { get; set; }

                /// <summary>
                /// <para>The refund ID of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZLJD12241231000002</para>
                /// </summary>
                [NameInMap("supplier_refund_id")]
                [Validation(Required=false)]
                public string SupplierRefundId { get; set; }

            }

            /// <summary>
            /// <para>The total amount of the original order. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("total_amount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
