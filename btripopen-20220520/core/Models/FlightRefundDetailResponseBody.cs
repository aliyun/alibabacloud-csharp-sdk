// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundDetailResponseBodyModule Module { get; set; }
        public class FlightRefundDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <para>The refund order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis1234</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <para>The refund order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>refun123</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the refund is voluntary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_voluntary")]
            [Validation(Required=false)]
            public int? IsVoluntary { get; set; }

            /// <summary>
            /// <para>The refund reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>自愿申请</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The refund service fee. Unit: cents. &gt;Notice: This field has a value only after the refund is successful. The default value is 0.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            /// <summary>
            /// <para>The list of refund fees. &gt;Notice: This field has a value only after the refund is successful. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("refund_fee_list")]
            [Validation(Required=false)]
            public List<FlightRefundDetailResponseBodyModuleRefundFeeList> RefundFeeList { get; set; }
            public class FlightRefundDetailResponseBodyModuleRefundFeeList : TeaModel {
                /// <summary>
                /// <para>The Alipay transaction order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>293982882881999</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <para>The refund service fee. Unit: cents. &gt;Notice: This field has a value only after the refund is successful. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                /// <summary>
                /// <para>The refund amount. Unit: cents. &gt;Notice: This field has a value only after the refund is successful. The default value is 0.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_price")]
                [Validation(Required=false)]
                public long? RefundPrice { get; set; }

                /// <summary>
                /// <para>The refund status.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Consistent with the outer refund request order status.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0枚举取外层状态</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The refund amount. Unit: cents. &gt;Notice: This field has a value only after the refund is successful. The default value is 0.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_price")]
            [Validation(Required=false)]
            public long? RefundPrice { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
