// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CommonApplyQueryResponseBody : TeaModel {
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The approval order object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public CommonApplyQueryResponseBodyModule Module { get; set; }
        public class CommonApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The Alibaba business travel approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The approval type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("biz_category")]
            [Validation(Required=false)]
            public int? BizCategory { get; set; }

            /// <summary>
            /// <para>The application reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>改签</para>
            /// </summary>
            [NameInMap("cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btrip5tnut0d3v78sl794</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The extended information of the approval order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>改签：
            /// {
            ///     &quot;changeFee&quot;: 100,
            ///     &quot;itineraryId&quot;: &quot;fc2824e458a140b5b950001bc51bcc54-8&quot;,
            ///     &quot;changeReason&quot;: &quot;机票改签测试11302052&quot;,
            ///     &quot;changeFlightOrders&quot;: [
            ///         {
            ///             &quot;arrTime&quot;: 1639008600000,
            ///             &quot;depTime&quot;: 1639000200000,
            ///             &quot;flightNo&quot;: &quot;GJ8988&quot;,
            ///             &quot;arrCityName&quot;: &quot;杭州&quot;,
            ///             &quot;depCityName&quot;: &quot;北京&quot;,
            ///             &quot;passengerInfos&quot;: [
            ///                 {
            ///                     &quot;id&quot;: 993146468,
            ///                     &quot;cabin&quot;: &quot;Y&quot;,
            ///                     &quot;discount&quot;: 10,
            ///                     &quot;changeFee&quot;: 100,
            ///                     &quot;cabinClass&quot;: &quot;2&quot;,
            ///                     &quot;cabinClassStr&quot;: &quot;经济舱&quot;,
            ///                     &quot;passengerName&quot;: &quot;商旅&quot;
            ///                 }
            ///             ]
            ///         }
            ///     ],
            ///     &quot;originFlightOrders&quot;: [
            ///         {
            ///             &quot;arrTime&quot;: 1638923400000,
            ///             &quot;depTime&quot;: 1638915600000,
            ///             &quot;flightNo&quot;: &quot;MU8477&quot;,
            ///             &quot;arrCityName&quot;: &quot;杭州&quot;,
            ///             &quot;depCityName&quot;: &quot;北京&quot;,
            ///             &quot;passengerInfos&quot;: [
            ///                 {
            ///                     &quot;id&quot;: 993146468,
            ///                     &quot;cabin&quot;: &quot;Y&quot;,
            ///                     &quot;discount&quot;: 0.1,
            ///                     &quot;changeFee&quot;: 100,
            ///                     &quot;cabinClass&quot;: &quot;2&quot;,
            ///                     &quot;cabinClassStr&quot;: &quot;经济舱&quot;,
            ///                     &quot;passengerName&quot;: &quot;商旅&quot;
            ///                 }
            ///             ]
            ///         }
            ///     ],
            ///     &quot;cabinAndDiscountDesc&quot;: &quot;可订经济舱2.0折及以下&quot;
            /// }，</para>
            /// <para>退票：
            /// {
            ///     &quot;refundFee&quot;: 7000,
            ///     &quot;itineraryId&quot;: &quot;fc2824e458a140b5b950001bc51bcc54-8&quot;,
            ///     &quot;refundReason&quot;: &quot;行程取消&quot;,
            ///     &quot;originFlightOrders&quot;: [
            ///         {
            ///             &quot;arrTime&quot;: 1638374400000,
            ///             &quot;depTime&quot;: 1638397200000,
            ///             &quot;flightNo&quot;: &quot;MU8477&quot;,
            ///             &quot;arrCityName&quot;: &quot;杭州&quot;,
            ///             &quot;depCityName&quot;: &quot;北京&quot;,
            ///             &quot;passengerInfos&quot;: [
            ///                 {
            ///                     &quot;id&quot;: 281825548,
            ///                     &quot;cabin&quot;: &quot;Y&quot;,
            ///                     &quot;discount&quot;: 0,
            ///                     &quot;refundFee&quot;: 500,
            ///                     &quot;cabinClass&quot;: 2,
            ///                     &quot;cabinClassStr&quot;: &quot;全价经济舱&quot;,
            ///                     &quot;passengerName&quot;: &quot;商旅&quot;
            ///                 }
            ///             ]
            ///         }
            ///     ]
            /// }</para>
            /// </summary>
            [NameInMap("extend_value")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The approval status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The third-party enterprise ID. The value is the same as the business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btrip5tnut0d3v78sl794</para>
            /// </summary>
            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

            /// <summary>
            /// <para>The third-party business trip approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            /// <summary>
            /// <para>The reason for the business trip.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州出差</para>
            /// </summary>
            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The third-party username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
