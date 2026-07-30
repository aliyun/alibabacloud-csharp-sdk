// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The module information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public MealOrderDetailQueryResponseBodyModule Module { get; set; }
        public class MealOrderDetailQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The approval form ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>118526587</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The enterprise code order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024032522001423601409393178</para>
            /// </summary>
            [NameInMap("corp_code_order_id")]
            [Validation(Required=false)]
            public string CorpCodeOrderId { get; set; }

            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingaa15ca45cba9ee744a5</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise payment amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("corp_pay_amount")]
            [Validation(Required=false)]
            public long? CorpPayAmount { get; set; }

            /// <summary>
            /// <para>The enterprise refund amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("corp_refund_amount")]
            [Validation(Required=false)]
            public long? CorpRefundAmount { get; set; }

            /// <summary>
            /// <para>The reason for the meal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>团建用餐</para>
            /// </summary>
            [NameInMap("meal_reason")]
            [Validation(Required=false)]
            public string MealReason { get; set; }

            /// <summary>
            /// <para>The restaurant merchant store name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商旅火锅店（杭州店）</para>
            /// </summary>
            [NameInMap("merchant_name")]
            [Validation(Required=false)]
            public string MerchantName { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1034088398073015303</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The order substatus.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_sub_status")]
            [Validation(Required=false)]
            public int? OrderSubStatus { get; set; }

            /// <summary>
            /// <para>The order type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>到店餐饮</para>
            /// </summary>
            [NameInMap("order_type")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The total payment amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("pay_amount")]
            [Validation(Required=false)]
            public long? PayAmount { get; set; }

            /// <summary>
            /// <para>The payment method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>The personal payment amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("person_pay_amount")]
            [Validation(Required=false)]
            public long? PersonPayAmount { get; set; }

            /// <summary>
            /// <para>The personal refund amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("person_refund_amount")]
            [Validation(Required=false)]
            public long? PersonRefundAmount { get; set; }

            /// <summary>
            /// <para>The download URLs of meal receipt images.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://url1,http://url1">http://url1,http://url1</a></para>
            /// </summary>
            [NameInMap("receipt_image_urls")]
            [Validation(Required=false)]
            public string ReceiptImageUrls { get; set; }

            /// <summary>
            /// <para>The total refund amount, in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_amount")]
            [Validation(Required=false)]
            public long? RefundAmount { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>差旅用餐</para>
            /// </summary>
            [NameInMap("scene_name")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The payment settlement time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711702782</para>
            /// </summary>
            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            /// <summary>
            /// <para>The third-party approval form ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024073128454753</para>
            /// </summary>
            [NameInMap("third_part_apply_id")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// <para>The user Alipay account, for example, <a href="mailto:xxxxx@xx.com">xxxxx@xx.com</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17509140000</para>
            /// </summary>
            [NameInMap("user_alipay_id")]
            [Validation(Required=false)]
            public string UserAlipayId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>014134681304653773</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
