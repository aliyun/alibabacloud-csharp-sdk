// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOrderDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyOrderDetailV2ResponseBodyModule Module { get; set; }
        public class FlightModifyOrderDetailV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The time when the change was applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14 11:28:01</para>
            /// </summary>
            [NameInMap("apply_time")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The extension fields.</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public FlightModifyOrderDetailV2ResponseBodyModuleAttributes Attributes { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleAttributes : TeaModel {
                /// <summary>
                /// <para>The baggage allowance rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{
                ///     &quot;baggageSubItems&quot;: [{
                ///         &quot;baggageSubContentVisualizes&quot;: [{
                ///             &quot;baggageDesc&quot;: [&quot;每人可携带 1件 登机&quot;, &quot;至多 5公斤/件&quot;, &quot;尺寸不超过 20<em>40</em>55cm&quot;],
                ///             &quot;baggageSubContentType&quot;: 0,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;手提行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png">https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png</a>&quot;,
                ///                 &quot;largest&quot;: &quot;55&quot;,
                ///                 &quot;middle&quot;: &quot;40&quot;,
                ///                 &quot;smallest&quot;: &quot;20&quot;
                ///             },
                ///             &quot;isHighlight&quot;: false,
                ///             &quot;subTitle&quot;: &quot;免费手提行李&quot;
                ///         }, {
                ///             &quot;baggageDesc&quot;: [&quot;尺寸不超过 40<em>60</em>100cm&quot;, &quot;至多 20公斤/人&quot;],
                ///             &quot;baggageSubContentType&quot;: 1,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您需要在登机前将行李在值机柜台办理托运，领取托运凭证，该行李在飞机货舱中随飞机到达目的地，抵达后您凭托运凭证在行李领取处领取。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;托运行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png">https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png</a>&quot;,
                ///                 &quot;largest&quot;: &quot;100&quot;,
                ///                 &quot;middle&quot;: &quot;60&quot;,
                ///                 &quot;smallest&quot;: &quot;40&quot;
                ///             },
                ///             &quot;isHighlight&quot;: false,
                ///             &quot;subTitle&quot;: &quot;免费托运行李&quot;
                ///         }],
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;ADT&quot;,
                ///         &quot;title&quot;: &quot;成人行李&quot;
                ///     }, {
                ///         &quot;baggageSubContentVisualizes&quot;: [{
                ///             &quot;baggageDesc&quot;: [&quot;每人可携带 1件 登机&quot;, &quot;至多 5公斤/件&quot;, &quot;尺寸不超过 20<em>40</em>55cm&quot;],
                ///             &quot;baggageSubContentType&quot;: 0,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;手提行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png">https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png</a>&quot;,
                ///                 &quot;largest&quot;: &quot;55&quot;,
                ///                 &quot;middle&quot;: &quot;40&quot;,
                ///                 &quot;smallest&quot;: &quot;20&quot;
                ///             },
                ///             &quot;isHighlight&quot;: false,
                ///             &quot;subTitle&quot;: &quot;儿童 免费手提行李&quot;
                ///         }, {
                ///             &quot;baggageDesc&quot;: [&quot;尺寸不超过 40<em>60</em>100cm&quot;, &quot;至多 20公斤/人&quot;],
                ///             &quot;baggageSubContentType&quot;: 1,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您需要在登机前将行李在值机柜台办理托运，领取托运凭证，该行李在飞机货舱中随飞机到达目的地，抵达后您凭托运凭证在行李领取处领取。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;托运行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png">https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png</a>&quot;,
                ///                 &quot;largest&quot;: &quot;100&quot;,
                ///                 &quot;middle&quot;: &quot;60&quot;,
                ///                 &quot;smallest&quot;: &quot;40&quot;
                ///             },
                ///             &quot;isHighlight&quot;: false,
                ///             &quot;subTitle&quot;: &quot;儿童 免费托运行李&quot;
                ///         }],
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;CHD&quot;,
                ///         &quot;title&quot;: &quot;儿童/婴儿行李&quot;
                ///     }, {
                ///         &quot;baggageSubContentVisualizes&quot;: [{
                ///             &quot;baggageDesc&quot;: [&quot;按照航司规定，暂无免费手提行李额&quot;],
                ///             &quot;baggageSubContentType&quot;: 0,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;手提行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i3/O1CN01BoSFry1SnmSBe52VJ_!!6000000002292-2-tps-280-300.png">https://gw.alicdn.com/imgextra/i3/O1CN01BoSFry1SnmSBe52VJ_!!6000000002292-2-tps-280-300.png</a>&quot;
                ///             },
                ///             &quot;isHighlight&quot;: true,
                ///             &quot;subTitle&quot;: &quot;婴儿 无免费手提行李&quot;
                ///         }, {
                ///             &quot;baggageDesc&quot;: [&quot;尺寸不超过 40<em>60</em>100cm&quot;, &quot;至多 10公斤/人&quot;],
                ///             &quot;baggageSubContentType&quot;: 1,
                ///             &quot;description&quot;: {
                ///                 &quot;desc&quot;: &quot;您需要在登机前将行李在值机柜台办理托运，领取托运凭证，该行李在飞机货舱中随飞机到达目的地，抵达后您凭托运凭证在行李领取处领取。&quot;,
                ///                 &quot;icon&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a>&quot;,
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png</a>&quot;,
                ///                 &quot;title&quot;: &quot;托运行李说明&quot;
                ///             },
                ///             &quot;imageDO&quot;: {
                ///                 &quot;image&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png">https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png</a>&quot;,
                ///                 &quot;largest&quot;: &quot;100&quot;,
                ///                 &quot;middle&quot;: &quot;60&quot;,
                ///                 &quot;smallest&quot;: &quot;40&quot;
                ///             },
                ///             &quot;isHighlight&quot;: false,
                ///             &quot;subTitle&quot;: &quot;婴儿 免费托运行李&quot;
                ///         }],
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;INF&quot;,
                ///         &quot;title&quot;: &quot;儿童/婴儿行李&quot;
                ///     }],
                ///     &quot;index&quot;: 0,
                ///     &quot;tips&quot;: {
                ///         &quot;logo&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png">https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png</a>&quot;,
                ///         &quot;tipsDesc&quot;: &quot;各个尺寸的行李箱有多大？&quot;,
                ///         &quot;tipsImage&quot;: &quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png">https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png</a>&quot;
                ///     },
                ///     &quot;title&quot;: &quot;行李规定&quot;,
                ///     &quot;type&quot;: 2
                /// }]</para>
                /// </summary>
                [NameInMap("baggage_rule")]
                [Validation(Required=false)]
                public string BaggageRule { get; set; }

                /// <summary>
                /// <para>The change rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{
                ///     &quot;index&quot;: 0,
                ///     &quot;refundSubItems&quot;: [{
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;ADT&quot;,
                ///         &quot;refundSubContents&quot;: [{
                ///             &quot;feeDesc&quot;: &quot;￥54/人&quot;,
                ///             &quot;feeRange&quot;: &quot;7月30日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥108/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月4日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥270/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥378/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 后&quot;,
                ///             &quot;style&quot;: 1
                ///         }],
                ///         &quot;title&quot;: &quot;成人&quot;
                ///     }, {
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;CHD&quot;,
                ///         &quot;refundSubContents&quot;: [{
                ///             &quot;feeDesc&quot;: &quot;￥54/人&quot;,
                ///             &quot;feeRange&quot;: &quot;7月30日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥108/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月4日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥270/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥378/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 后&quot;,
                ///             &quot;style&quot;: 1
                ///         }],
                ///         &quot;title&quot;: &quot;儿童&quot;
                ///     }, {
                ///         &quot;content&quot;: &quot;&quot;,
                ///         &quot;isStruct&quot;: false,
                ///         &quot;ptc&quot;: &quot;INF&quot;,
                ///         &quot;title&quot;: &quot;婴儿&quot;
                ///     }],
                ///     &quot;title&quot;: &quot;同舱改期规则&quot;,
                ///     &quot;type&quot;: 1
                /// }, {
                ///     &quot;index&quot;: 0,
                ///     &quot;refundSubItems&quot;: [{
                ///         &quot;content&quot;: &quot;不可签转&quot;,
                ///         &quot;isStruct&quot;: false
                ///     }],
                ///     &quot;title&quot;: &quot;签转条件&quot;,
                ///     &quot;type&quot;: 2
                /// }]</para>
                /// </summary>
                [NameInMap("change_rule")]
                [Validation(Required=false)]
                public string ChangeRule { get; set; }

                /// <summary>
                /// <para>The latest payment time (UNIX timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725333295287</para>
                /// </summary>
                [NameInMap("latest_pay_time")]
                [Validation(Required=false)]
                public object LatestPayTime { get; set; }

                /// <summary>
                /// <para>The latest payment time (character string format: yyyy-MM-dd HH:mm:ss).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-03 11:14:55</para>
                /// </summary>
                [NameInMap("latest_pay_time_str")]
                [Validation(Required=false)]
                public string LatestPayTimeStr { get; set; }

                /// <summary>
                /// <para>The refund rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{
                ///     &quot;extraContents&quot;: [{
                ///         &quot;content&quot;: &quot;变更航班或舱位如有差价须补足。客票有效期一年；退票不晚于有效期，截止后一个月之内办理；特殊折扣机票退改签按其相应规定执行。&quot;,
                ///         &quot;title&quot;: &quot;特殊说明&quot;
                ///     }],
                ///     &quot;index&quot;: 0,
                ///     &quot;refundSubItems&quot;: [{
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;ADT&quot;,
                ///         &quot;refundSubContents&quot;: [{
                ///             &quot;feeDesc&quot;: &quot;￥108/人&quot;,
                ///             &quot;feeRange&quot;: &quot;7月30日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥162/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月4日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥378/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥486/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 后&quot;,
                ///             &quot;style&quot;: 1
                ///         }],
                ///         &quot;title&quot;: &quot;成人&quot;
                ///     }, {
                ///         &quot;isStruct&quot;: true,
                ///         &quot;ptc&quot;: &quot;CHD&quot;,
                ///         &quot;refundSubContents&quot;: [{
                ///             &quot;feeDesc&quot;: &quot;￥108/人&quot;,
                ///             &quot;feeRange&quot;: &quot;7月30日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥162/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月4日 21:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥378/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 前&quot;,
                ///             &quot;style&quot;: 1
                ///         }, {
                ///             &quot;feeDesc&quot;: &quot;￥486/人&quot;,
                ///             &quot;feeRange&quot;: &quot;8月6日 17:20 后&quot;,
                ///             &quot;style&quot;: 1
                ///         }],
                ///         &quot;title&quot;: &quot;儿童&quot;
                ///     }, {
                ///         &quot;content&quot;: &quot;免费退改&quot;,
                ///         &quot;isStruct&quot;: false,
                ///         &quot;ptc&quot;: &quot;INF&quot;,
                ///         &quot;title&quot;: &quot;婴儿&quot;
                ///     }],
                ///     &quot;title&quot;: &quot;退票收费规则&quot;,
                ///     &quot;type&quot;: 0
                /// }]</para>
                /// </summary>
                [NameInMap("refund_rule")]
                [Validation(Required=false)]
                public string RefundRule { get; set; }

            }

            /// <summary>
            /// <para>The email of the booker for the original order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>j*********@example.com</para>
            /// </summary>
            [NameInMap("book_user_email")]
            [Validation(Required=false)]
            public string BookUserEmail { get; set; }

            /// <summary>
            /// <para>The name of the booker for the original order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>正向订单预订人姓名</para>
            /// </summary>
            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            /// <summary>
            /// <para>The phone number of the booker for the original order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("bookuser_phone")]
            [Validation(Required=false)]
            public string BookuserPhone { get; set; }

            /// <summary>
            /// <para>The reason why the change failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>原因说明</para>
            /// </summary>
            [NameInMap("change_fail_reason")]
            [Validation(Required=false)]
            public string ChangeFailReason { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// </summary>
            [NameInMap("contact_info_d_t_o")]
            [Validation(Required=false)]
            public FlightModifyOrderDetailV2ResponseBodyModuleContactInfoDTO ContactInfoDTO { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleContactInfoDTO : TeaModel {
                /// <summary>
                /// <para>The email address of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j****<a href="mailto:o@example.com">o@example.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <para>The name of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浪花</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The phone number of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****8888</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <para>Specifies whether to send an SMS notification to the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            /// <summary>
            /// <para>The target flight information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Returns an empty array when no value is available.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("dest_flight_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS> DestFlightInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOS : TeaModel {
                /// <summary>
                /// <para>The two-letter code of the airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                /// <summary>
                /// <para>The URL of the airline icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>航司 icon</para>
                /// </summary>
                [NameInMap("airline_icon_url")]
                [Validation(Required=false)]
                public string AirlineIconUrl { get; set; }

                /// <summary>
                /// <para>The name of the airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国东方航空</para>
                /// </summary>
                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival terminal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>到达航站楼</para>
                /// </summary>
                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-03 09:30:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_name")]
                [Validation(Required=false)]
                public string CabinClassName { get; set; }

                /// <summary>
                /// <para>The discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("cabin_discount")]
                [Validation(Required=false)]
                public long? CabinDiscount { get; set; }

                /// <summary>
                /// <para>The two-letter code of the operating airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司二字码</para>
                /// </summary>
                [NameInMap("carrier_airline_code")]
                [Validation(Required=false)]
                public string CarrierAirlineCode { get; set; }

                /// <summary>
                /// <para>The URL of the operating airline icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司 icon</para>
                /// </summary>
                [NameInMap("carrier_airline_icon_url")]
                [Validation(Required=false)]
                public string CarrierAirlineIconUrl { get; set; }

                /// <summary>
                /// <para>The name of the operating airline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运方航司名称</para>
                /// </summary>
                [NameInMap("carrier_airline_name")]
                [Validation(Required=false)]
                public string CarrierAirlineName { get; set; }

                /// <summary>
                /// <para>The operating flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>承运航班号</para>
                /// </summary>
                [NameInMap("carrier_flight_no")]
                [Validation(Required=false)]
                public string CarrierFlightNo { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PKX</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The name of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大兴国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The name of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure terminal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>出发航站楼</para>
                /// </summary>
                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-03 07:30:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The flight change information.</para>
                /// </summary>
                [NameInMap("flight_change")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSFlightChange FlightChange { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSFlightChange : TeaModel {
                    /// <summary>
                    /// <para>The flight change description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>计划起飞时间10-01 07:30延误至10-01 07:40</para>
                    /// </summary>
                    [NameInMap("change_desc")]
                    [Validation(Required=false)]
                    public string ChangeDesc { get; set; }

                    /// <summary>
                    /// <para>The description of the flight change status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>出发时间延误</para>
                    /// </summary>
                    [NameInMap("change_status")]
                    [Validation(Required=false)]
                    public string ChangeStatus { get; set; }

                    /// <summary>
                    /// <para>The flight change status code. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEP_TIME_DELAY</para>
                    /// </summary>
                    [NameInMap("change_status_code")]
                    [Validation(Required=false)]
                    public string ChangeStatusCode { get; set; }

                    /// <summary>
                    /// <para>The new segment information.
                    /// [<em>single.resp.200.props.module.dest_flight_info_d_t_o_s.items.flight_change.new</em></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新航段信息</para>
                    /// </summary>
                    [NameInMap("new_segment")]
                    [Validation(Required=false)]
                    public object NewSegment { get; set; }

                    /// <summary>
                    /// <para>The list of passengers affected by the flight change.</para>
                    /// </summary>
                    [NameInMap("passenger_names")]
                    [Validation(Required=false)]
                    public List<string> PassengerNames { get; set; }

                }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU5193</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The aircraft type, such as &quot;738&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机型，例&quot;738&quot;</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The meal description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>餐食描述</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The segment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1194012</para>
                /// </summary>
                [NameInMap("segmentI_id")]
                [Validation(Required=false)]
                public string SegmentIId { get; set; }

                /// <summary>
                /// <para>The segment position information, indicating the journey index and segment index within the itinerary.</para>
                /// </summary>
                [NameInMap("segment_position")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition SegmentPosition { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleDestFlightInfoDTOSSegmentPosition : TeaModel {
                    /// <summary>
                    /// <para>The journey index (starting from 0).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index (starting from 0 within the same journey).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                }

                /// <summary>
                /// <para>The arrival time at the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停到达时间</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停城市</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The departure time from the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经停到达时间</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

            }

            /// <summary>
            /// <para>The latest payment time.</para>
            /// <remarks>
            /// <para>Warning: Deprecated</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14 11:48:01</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

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
            /// <para>The distribution external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017124195788186048</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The distribution external sub-order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1019195836916029</para>
            /// </summary>
            [NameInMap("out_sub_order_id")]
            [Validation(Required=false)]
            public string OutSubOrderId { get; set; }

            /// <summary>
            /// <para>The actual payment time.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This field has a value only after payment is successful.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14 11:38:01</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The reason for the flight change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>改签原因</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The change order status. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The sub-order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1019195836916029</para>
            /// </summary>
            [NameInMap("sub_order_id")]
            [Validation(Required=false)]
            public long? SubOrderId { get; set; }

            /// <summary>
            /// <para>The ticketing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-19 15:24:08</para>
            /// </summary>
            [NameInMap("ticket_time")]
            [Validation(Required=false)]
            public string TicketTime { get; set; }

            /// <summary>
            /// <para>The total cost. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            /// <summary>
            /// <para>The change service fee. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("total_service_fee_price")]
            [Validation(Required=false)]
            public long? TotalServiceFeePrice { get; set; }

            /// <summary>
            /// <para>The passenger information.</para>
            /// </summary>
            [NameInMap("traveler_info_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS> TravelerInfoDTOS { get; set; }
            public class FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOS : TeaModel {
                /// <summary>
                /// <para>The date of birth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-08-19</para>
                /// </summary>
                [NameInMap("birth_date")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                /// <summary>
                /// <para>The identity document number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110101********1234</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The type of the identity document. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <para>The change fee at the passenger level.</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOSChangeFee ChangeFee { get; set; }
                public class FlightModifyOrderDetailV2ResponseBodyModuleTravelerInfoDTOSChangeFee : TeaModel {
                    /// <summary>
                    /// <para>The change fee (service fee + upgrade fee). Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("change_fee")]
                    [Validation(Required=false)]
                    public long? ChangeFee { get; set; }

                    /// <summary>
                    /// <para>The service fee. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("service_fee")]
                    [Validation(Required=false)]
                    public long? ServiceFee { get; set; }

                    /// <summary>
                    /// <para>The upgrade fee. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>900</para>
                    /// </summary>
                    [NameInMap("upgrade_price")]
                    [Validation(Required=false)]
                    public long? UpgradePrice { get; set; }

                }

                /// <summary>
                /// <para>The gender of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The original ticket numbers.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns empty when no value is available.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("origin_ticket_nos")]
                [Validation(Required=false)]
                public List<string> OriginTicketNos { get; set; }

                /// <summary>
                /// <para>The passenger ID, corresponding to btripUserId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12172819047252004460056</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <para>The name of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>逐浪</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The type of the passenger. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

                /// <summary>
                /// <para>The phone number of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****8888</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The primary key ID of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("pid")]
                [Validation(Required=false)]
                public long? Pid { get; set; }

                /// <summary>
                /// <para>The mapping between ticket numbers and segments (key is the ticket number, value is the list of segments).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;000-123456789&quot;:&quot;[54321,54322]&quot;}</para>
                /// </summary>
                [NameInMap("ticket_no_segment_map")]
                [Validation(Required=false)]
                public Dictionary<string, object> TicketNoSegmentMap { get; set; }

                /// <summary>
                /// <para>The ticket numbers.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns empty when no value is available.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identity of the request.</para>
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
        /// <para>The global identity of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc2dc16839612026565712dcbe6</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
