// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderDetailQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealOrderDetailQueryResponseBodyModule Module { get; set; }
        public class MealOrderDetailQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024032522001423601409393178</para>
            /// </summary>
            [NameInMap("corp_code_order_id")]
            [Validation(Required=false)]
            public string CorpCodeOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingaa15ca45cba9ee744a5</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("corp_pay_amount")]
            [Validation(Required=false)]
            public long? CorpPayAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("corp_refund_amount")]
            [Validation(Required=false)]
            public long? CorpRefundAmount { get; set; }

            [NameInMap("merchant_name")]
            [Validation(Required=false)]
            public string MerchantName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1034088398073015303</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_sub_status")]
            [Validation(Required=false)]
            public int? OrderSubStatus { get; set; }

            [NameInMap("order_type")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("pay_amount")]
            [Validation(Required=false)]
            public long? PayAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("person_pay_amount")]
            [Validation(Required=false)]
            public long? PersonPayAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("person_refund_amount")]
            [Validation(Required=false)]
            public long? PersonRefundAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_amount")]
            [Validation(Required=false)]
            public long? RefundAmount { get; set; }

            [NameInMap("scene_name")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1711702782</para>
            /// </summary>
            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            [NameInMap("third_part_apply_id")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17509140000</para>
            /// </summary>
            [NameInMap("user_alipay_id")]
            [Validation(Required=false)]
            public string UserAlipayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>014134681304653773</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
