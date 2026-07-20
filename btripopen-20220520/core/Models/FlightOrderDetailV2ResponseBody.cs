// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
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
        public FlightOrderDetailV2ResponseBodyModule Module { get; set; }
        public class FlightOrderDetailV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>协议价编码</para>
            /// </summary>
            [NameInMap("b2g_vip_code")]
            [Validation(Required=false)]
            public string B2gVipCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:28:44</para>
            /// </summary>
            [NameInMap("book_succ_time")]
            [Validation(Required=false)]
            public string BookSuccTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qingg1234</para>
            /// </summary>
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试预定人</para>
            /// </summary>
            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("build_price")]
            [Validation(Required=false)]
            public long? BuildPrice { get; set; }

            [NameInMap("contact_info_d_t_o")]
            [Validation(Required=false)]
            public FlightOrderDetailV2ResponseBodyModuleContactInfoDTO ContactInfoDTO { get; set; }
            public class FlightOrderDetailV2ResponseBodyModuleContactInfoDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:178169630111@163.com">178169630111@163.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试联系人</para>
                /// </summary>
                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>178169630111</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:03:11</para>
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>126000</para>
            /// </summary>
            [NameInMap("facevalue")]
            [Validation(Required=false)]
            public long? Facevalue { get; set; }

            [NameInMap("flight_tale_info_d_t_o")]
            [Validation(Required=false)]
            public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTO FlightTaleInfoDTO { get; set; }
            public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTO : TeaModel {
                [NameInMap("journeys")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneys> Journeys { get; set; }
                public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("all_fly_duration")]
                    [Validation(Required=false)]
                    public long? AllFlyDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("all_fly_duration_after_change")]
                    [Validation(Required=false)]
                    public long? AllFlyDurationAfterChange { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>申请单Id</para>
                    /// </summary>
                    [NameInMap("apply_id")]
                    [Validation(Required=false)]
                    public long? ApplyId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XIL</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>锡林浩特</para>
                    /// </summary>
                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-07-20 08:25:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;baggageDetails\&quot;:[{\&quot;index\&quot;:0,\&quot;title\&quot;:\&quot;行李规定\&quot;,\&quot;type\&quot;:2,\&quot;baggageSubItems\&quot;:[{\&quot;extraContentVisualizes\&quot;:[],\&quot;baggageSubContentVisualizes\&quot;:[{\&quot;baggageDesc\&quot;:[\&quot;每人可携带 1件 登机\&quot;,\&quot;至多 5公斤/件\&quot;,\&quot;尺寸不超过 20<em>40</em>55cm\&quot;],\&quot;baggageSubContentType\&quot;:0,\&quot;imageDO\&quot;:{\&quot;image\&quot;:\&quot;<a href="https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png%5C%5C%22,%5C%5C%22largest%5C%5C%22:%5C%5C%2255%5C%5C%22,%5C%5C%22middle%5C%5C%22:%5C%5C%2240%5C%5C%22,%5C%5C%22smallest%5C%5C%22:%5C%5C%2220%5C%5C%22%7D,%5C%5C%22subTitle%5C%5C%22:%5C%5C%22%E5%85%8D%E8%B4%B9%E6%89%8B%E6%8F%90%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isHighlight%5C%5C%22:false,%5C%5C%22description%5C%5C%22:%7B%5C%5C%22image%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png%5C%5C%22,%5C%5C%22icon%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png%5C%5C%22,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%89%8B%E6%8F%90%E8%A1%8C%E6%9D%8E%E8%AF%B4%E6%98%8E%5C%5C%22,%5C%5C%22desc%5C%5C%22:%5C%5C%22%E6%82%A8%E5%8F%AF%E4%BB%A5%E9%9A%8F%E8%BA%AB%E6%90%BA%E5%B8%A6%E4%B8%8A%E9%A3%9E%E6%9C%BA%E5%AE%A2%E8%88%B1%E5%86%85%E7%9A%84%E8%A1%8C%E6%9D%8E%E7%89%A9%E5%93%81%EF%BC%8C%E7%94%B1%E6%97%85%E5%AE%A2%E8%87%AA%E8%A1%8C%E8%B4%9F%E8%B4%A3%E4%BF%9D%E7%AE%A1%E3%80%82%E5%85%B7%E4%BD%93%E5%B0%BA%E5%AF%B8%E3%80%81%E9%87%8D%E9%87%8F%E3%80%81%E7%B1%BB%E5%9E%8B%E7%AD%89%E4%BB%A5%E5%90%84%E8%88%AA%E7%A9%BA%E5%85%AC%E5%8F%B8%E8%A7%84%E5%AE%9A%E4%B8%BA%E5%87%86%E3%80%82%5C%5C%22%7D%7D,%7B%5C%5C%22baggageDesc%5C%5C%22:%5B%5C%5C%22%E5%B0%BA%E5%AF%B8%E4%B8%8D%E8%B6%85%E8%BF%87">https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png\\&quot;,\\&quot;largest\\&quot;:\\&quot;55\\&quot;,\\&quot;middle\\&quot;:\\&quot;40\\&quot;,\\&quot;smallest\\&quot;:\\&quot;20\\&quot;},\\&quot;subTitle\\&quot;:\\&quot;免费手提行李\\&quot;,\\&quot;isHighlight\\&quot;:false,\\&quot;description\\&quot;:{\\&quot;image\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png\\&quot;,\\&quot;icon\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png\\&quot;,\\&quot;title\\&quot;:\\&quot;手提行李说明\\&quot;,\\&quot;desc\\&quot;:\\&quot;您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准。\\&quot;}},{\\&quot;baggageDesc\\&quot;:[\\&quot;尺寸不超过</a> 40<em>60</em>100cm\&quot;,\&quot;至多 20公斤/人\&quot;],\&quot;baggageSubContentType\&quot;:1,\&quot;imageDO\&quot;:{\&quot;image\&quot;:\&quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png%5C%5C%22,%5C%5C%22largest%5C%5C%22:%5C%5C%22100%5C%5C%22,%5C%5C%22middle%5C%5C%22:%5C%5C%2260%5C%5C%22,%5C%5C%22smallest%5C%5C%22:%5C%5C%2240%5C%5C%22%7D,%5C%5C%22subTitle%5C%5C%22:%5C%5C%22%E5%85%8D%E8%B4%B9%E6%89%98%E8%BF%90%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isHighlight%5C%5C%22:false,%5C%5C%22description%5C%5C%22:%7B%5C%5C%22image%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png%5C%5C%22,%5C%5C%22icon%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png%5C%5C%22,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%89%98%E8%BF%90%E8%A1%8C%E6%9D%8E%E8%AF%B4%E6%98%8E%5C%5C%22,%5C%5C%22desc%5C%5C%22:%5C%5C%22%E6%82%A8%E9%9C%80%E8%A6%81%E5%9C%A8%E7%99%BB%E6%9C%BA%E5%89%8D%E5%B0%86%E8%A1%8C%E6%9D%8E%E5%9C%A8%E5%80%BC%E6%9C%BA%E6%9F%9C%E5%8F%B0%E5%8A%9E%E7%90%86%E6%89%98%E8%BF%90%EF%BC%8C%E9%A2%86%E5%8F%96%E6%89%98%E8%BF%90%E5%87%AD%E8%AF%81%EF%BC%8C%E8%AF%A5%E8%A1%8C%E6%9D%8E%E5%9C%A8%E9%A3%9E%E6%9C%BA%E8%B4%A7%E8%88%B1%E4%B8%AD%E9%9A%8F%E9%A3%9E%E6%9C%BA%E5%88%B0%E8%BE%BE%E7%9B%AE%E7%9A%84%E5%9C%B0%EF%BC%8C%E6%8A%B5%E8%BE%BE%E5%90%8E%E6%82%A8%E5%87%AD%E6%89%98%E8%BF%90%E5%87%AD%E8%AF%81%E5%9C%A8%E8%A1%8C%E6%9D%8E%E9%A2%86%E5%8F%96%E5%A4%84%E9%A2%86%E5%8F%96%E3%80%82%5C%5C%22%7D%7D%5D,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%88%90%E4%BA%BA%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isStruct%5C%5C%22:true,%5C%5C%22ptc%5C%5C%22:%5C%5C%22ADT%5C%5C%22%7D%5D,%5C%5C%22tableHead%5C%5C%22:%5C%5C%22%E5%8C%97%E4%BA%AC-%E9%94%A1%E6%9E%97%E6%B5%A9%E7%89%B9%5C%5C%22,%5C%5C%22tips%5C%5C%22:%7B%5C%5C%22tipsDesc%5C%5C%22:%5C%5C%22%E5%90%84%E4%B8%AA%E5%B0%BA%E5%AF%B8%E7%9A%84%E8%A1%8C%E6%9D%8E%E7%AE%B1%E6%9C%89%E5%A4%9A%E5%A4%A7%EF%BC%9F%5C%5C%22,%5C%5C%22logo%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png%5C%5C%22,%5C%5C%22tipsImage%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png%5C%5C%22%7D%7D,%7B%5C%5C%22index%5C%5C%22:0,%5C%5C%22type%5C%5C%22:2,%5C%5C%22baggageSubItems%5C%5C%22:%5B%7B%5C%5C%22extraContentVisualizes%5C%5C%22:%5B%5D,%5C%5C%22baggageSubContentVisualizes%5C%5C%22:%5B%7B%5C%5C%22baggageDesc%5C%5C%22:%5B%5C%5C%22%E6%AF%8F%E4%BA%BA%E5%8F%AF%E6%90%BA%E5%B8%A6">https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png\\&quot;,\\&quot;largest\\&quot;:\\&quot;100\\&quot;,\\&quot;middle\\&quot;:\\&quot;60\\&quot;,\\&quot;smallest\\&quot;:\\&quot;40\\&quot;},\\&quot;subTitle\\&quot;:\\&quot;免费托运行李\\&quot;,\\&quot;isHighlight\\&quot;:false,\\&quot;description\\&quot;:{\\&quot;image\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png\\&quot;,\\&quot;icon\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png\\&quot;,\\&quot;title\\&quot;:\\&quot;托运行李说明\\&quot;,\\&quot;desc\\&quot;:\\&quot;您需要在登机前将行李在值机柜台办理托运，领取托运凭证，该行李在飞机货舱中随飞机到达目的地，抵达后您凭托运凭证在行李领取处领取。\\&quot;}}],\\&quot;title\\&quot;:\\&quot;成人行李\\&quot;,\\&quot;isStruct\\&quot;:true,\\&quot;ptc\\&quot;:\\&quot;ADT\\&quot;}],\\&quot;tableHead\\&quot;:\\&quot;北京-锡林浩特\\&quot;,\\&quot;tips\\&quot;:{\\&quot;tipsDesc\\&quot;:\\&quot;各个尺寸的行李箱有多大？\\&quot;,\\&quot;logo\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png\\&quot;,\\&quot;tipsImage\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png\\&quot;}},{\\&quot;index\\&quot;:0,\\&quot;type\\&quot;:2,\\&quot;baggageSubItems\\&quot;:[{\\&quot;extraContentVisualizes\\&quot;:[],\\&quot;baggageSubContentVisualizes\\&quot;:[{\\&quot;baggageDesc\\&quot;:[\\&quot;每人可携带</a> 1件 登机\&quot;,\&quot;至多 5公斤/件\&quot;,\&quot;尺寸不超过 20<em>40</em>55cm\&quot;],\&quot;baggageSubContentType\&quot;:0,\&quot;imageDO\&quot;:{\&quot;image\&quot;:\&quot;<a href="https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png%5C%5C%22,%5C%5C%22largest%5C%5C%22:%5C%5C%2255%5C%5C%22,%5C%5C%22middle%5C%5C%22:%5C%5C%2240%5C%5C%22,%5C%5C%22smallest%5C%5C%22:%5C%5C%2220%5C%5C%22%7D,%5C%5C%22subTitle%5C%5C%22:%5C%5C%22%E5%85%8D%E8%B4%B9%E6%89%8B%E6%8F%90%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isHighlight%5C%5C%22:false,%5C%5C%22description%5C%5C%22:%7B%5C%5C%22image%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png%5C%5C%22,%5C%5C%22icon%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png%5C%5C%22,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%89%8B%E6%8F%90%E8%A1%8C%E6%9D%8E%E8%AF%B4%E6%98%8E%5C%5C%22,%5C%5C%22desc%5C%5C%22:%5C%5C%22%E6%82%A8%E5%8F%AF%E4%BB%A5%E9%9A%8F%E8%BA%AB%E6%90%BA%E5%B8%A6%E4%B8%8A%E9%A3%9E%E6%9C%BA%E5%AE%A2%E8%88%B1%E5%86%85%E7%9A%84%E8%A1%8C%E6%9D%8E%E7%89%A9%E5%93%81%EF%BC%8C%E7%94%B1%E6%97%85%E5%AE%A2%E8%87%AA%E8%A1%8C%E8%B4%9F%E8%B4%A3%E4%BF%9D%E7%AE%A1%E3%80%82%E5%85%B7%E4%BD%93%E5%B0%BA%E5%AF%B8%E3%80%81%E9%87%8D%E9%87%8F%E3%80%81%E7%B1%BB%E5%9E%8B%E7%AD%89%E4%BB%A5%E5%90%84%E8%88%AA%E7%A9%BA%E5%85%AC%E5%8F%B8%E8%A7%84%E5%AE%9A%E4%B8%BA%E5%87%86%E3%80%82%5C%5C%22%7D%7D,%7B%5C%5C%22baggageDesc%5C%5C%22:%5B%5C%5C%22%E5%B0%BA%E5%AF%B8%E4%B8%8D%E8%B6%85%E8%BF%87">https://gw.alicdn.com/imgextra/i3/O1CN01kLt3m923XsUs6WVif_!!6000000007266-2-tps-280-300.png\\&quot;,\\&quot;largest\\&quot;:\\&quot;55\\&quot;,\\&quot;middle\\&quot;:\\&quot;40\\&quot;,\\&quot;smallest\\&quot;:\\&quot;20\\&quot;},\\&quot;subTitle\\&quot;:\\&quot;免费手提行李\\&quot;,\\&quot;isHighlight\\&quot;:false,\\&quot;description\\&quot;:{\\&quot;image\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png\\&quot;,\\&quot;icon\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png\\&quot;,\\&quot;title\\&quot;:\\&quot;手提行李说明\\&quot;,\\&quot;desc\\&quot;:\\&quot;您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准。\\&quot;}},{\\&quot;baggageDesc\\&quot;:[\\&quot;尺寸不超过</a> 40<em>60</em>100cm\&quot;,\&quot;至多 20公斤/人\&quot;],\&quot;baggageSubContentType\&quot;:1,\&quot;imageDO\&quot;:{\&quot;image\&quot;:\&quot;<a href="https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png%5C%5C%22,%5C%5C%22largest%5C%5C%22:%5C%5C%22100%5C%5C%22,%5C%5C%22middle%5C%5C%22:%5C%5C%2260%5C%5C%22,%5C%5C%22smallest%5C%5C%22:%5C%5C%2240%5C%5C%22%7D,%5C%5C%22subTitle%5C%5C%22:%5C%5C%22%E5%85%8D%E8%B4%B9%E6%89%98%E8%BF%90%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isHighlight%5C%5C%22:false,%5C%5C%22description%5C%5C%22:%7B%5C%5C%22image%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png%5C%5C%22,%5C%5C%22icon%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png%5C%5C%22,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%89%98%E8%BF%90%E8%A1%8C%E6%9D%8E%E8%AF%B4%E6%98%8E%5C%5C%22,%5C%5C%22desc%5C%5C%22:%5C%5C%22%E6%82%A8%E9%9C%80%E8%A6%81%E5%9C%A8%E7%99%BB%E6%9C%BA%E5%89%8D%E5%B0%86%E8%A1%8C%E6%9D%8E%E5%9C%A8%E5%80%BC%E6%9C%BA%E6%9F%9C%E5%8F%B0%E5%8A%9E%E7%90%86%E6%89%98%E8%BF%90%EF%BC%8C%E9%A2%86%E5%8F%96%E6%89%98%E8%BF%90%E5%87%AD%E8%AF%81%EF%BC%8C%E8%AF%A5%E8%A1%8C%E6%9D%8E%E5%9C%A8%E9%A3%9E%E6%9C%BA%E8%B4%A7%E8%88%B1%E4%B8%AD%E9%9A%8F%E9%A3%9E%E6%9C%BA%E5%88%B0%E8%BE%BE%E7%9B%AE%E7%9A%84%E5%9C%B0%EF%BC%8C%E6%8A%B5%E8%BE%BE%E5%90%8E%E6%82%A8%E5%87%AD%E6%89%98%E8%BF%90%E5%87%AD%E8%AF%81%E5%9C%A8%E8%A1%8C%E6%9D%8E%E9%A2%86%E5%8F%96%E5%A4%84%E9%A2%86%E5%8F%96%E3%80%82%5C%5C%22%7D%7D%5D,%5C%5C%22title%5C%5C%22:%5C%5C%22%E6%88%90%E4%BA%BA%E8%A1%8C%E6%9D%8E%5C%5C%22,%5C%5C%22isStruct%5C%5C%22:true,%5C%5C%22ptc%5C%5C%22:%5C%5C%22ADT%5C%5C%22%7D%5D,%5C%5C%22tableHead%5C%5C%22:%5C%5C%22%E9%94%A1%E6%9E%97%E6%B5%A9%E7%89%B9-%E5%8C%97%E4%BA%AC%5C%5C%22,%5C%5C%22tips%5C%5C%22:%7B%5C%5C%22tipsDesc%5C%5C%22:%5C%5C%22%E5%90%84%E4%B8%AA%E5%B0%BA%E5%AF%B8%E7%9A%84%E8%A1%8C%E6%9D%8E%E7%AE%B1%E6%9C%89%E5%A4%9A%E5%A4%A7%EF%BC%9F%5C%5C%22,%5C%5C%22logo%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png%5C%5C%22,%5C%5C%22tipsImage%5C%5C%22:%5C%5C%22https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png%5C%5C%22%7D%7D%5D%7D">https://gw.alicdn.com/imgextra/i1/O1CN013fm4Hf1kc1NlbQ1dV_!!6000000004703-2-tps-280-400.png\\&quot;,\\&quot;largest\\&quot;:\\&quot;100\\&quot;,\\&quot;middle\\&quot;:\\&quot;60\\&quot;,\\&quot;smallest\\&quot;:\\&quot;40\\&quot;},\\&quot;subTitle\\&quot;:\\&quot;免费托运行李\\&quot;,\\&quot;isHighlight\\&quot;:false,\\&quot;description\\&quot;:{\\&quot;image\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01rX7s431t7ddQuCWjK_!!6000000005855-2-tps-1206-768.png\\&quot;,\\&quot;icon\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png\\&quot;,\\&quot;title\\&quot;:\\&quot;托运行李说明\\&quot;,\\&quot;desc\\&quot;:\\&quot;您需要在登机前将行李在值机柜台办理托运，领取托运凭证，该行李在飞机货舱中随飞机到达目的地，抵达后您凭托运凭证在行李领取处领取。\\&quot;}}],\\&quot;title\\&quot;:\\&quot;成人行李\\&quot;,\\&quot;isStruct\\&quot;:true,\\&quot;ptc\\&quot;:\\&quot;ADT\\&quot;}],\\&quot;tableHead\\&quot;:\\&quot;锡林浩特-北京\\&quot;,\\&quot;tips\\&quot;:{\\&quot;tipsDesc\\&quot;:\\&quot;各个尺寸的行李箱有多大？\\&quot;,\\&quot;logo\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png\\&quot;,\\&quot;tipsImage\\&quot;:\\&quot;https://gw.alicdn.com/imgextra/i1/O1CN01X8dK671m3nC7MFAq7_!!6000000004899-2-tps-1050-675.png\\&quot;}}]}</a></para>
                    /// </summary>
                    [NameInMap("baggage_details")]
                    [Validation(Required=false)]
                    public string BaggageDetails { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-07-20 07:00:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>标签</para>
                    /// </summary>
                    [NameInMap("flight_status")]
                    [Validation(Required=false)]
                    public string FlightStatus { get; set; }

                    /// <summary>
                    /// <para>iata_no</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>iata_no</para>
                    /// </summary>
                    [NameInMap("iata_no")]
                    [Validation(Required=false)]
                    public string IataNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>是否重新行程</para>
                    /// </summary>
                    [NameInMap("is_reshop_journey")]
                    [Validation(Required=false)]
                    public bool? IsReshopJourney { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>是否中转</para>
                    /// </summary>
                    [NameInMap("is_transfer")]
                    [Validation(Required=false)]
                    public bool? IsTransfer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>去程</para>
                    /// </summary>
                    [NameInMap("journey_title")]
                    [Validation(Required=false)]
                    public string JourneyTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;refundDetails\&quot;:[{\&quot;refundSubItems\&quot;:[{\&quot;title\&quot;:\&quot;成人\&quot;,\&quot;isStruct\&quot;:true,\&quot;refundSubContents\&quot;:[{\&quot;feeDesc\&quot;:\&quot;￥0/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月6日 07:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月18日 07:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月20日 03:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:1,\&quot;feeRange\&quot;:\&quot;7月20日 03:00 后\&quot;}],\&quot;ptc\&quot;:\&quot;ADT\&quot;}],\&quot;index\&quot;:0,\&quot;title\&quot;:\&quot;退票收费规则\&quot;,\&quot;type\&quot;:0,\&quot;tableHead\&quot;:\&quot;北京-锡林浩特\&quot;,\&quot;extraContents\&quot;:[{\&quot;title\&quot;:\&quot;特殊说明\&quot;,\&quot;content\&quot;:\&quot;改期如有差价需同时收取改期费和差价。来回程一体运价（指来回程票价低于单程票价的两倍）客票部分使用后退票，扣除票面价的1/2来回程一体运价，余额按相应舱位退规办理。来回程一体运价（指来回程票价低于单程票价的两倍）客票部分使用后变更，按1/2来回程一体运价计算变更手续费；如变更后舱位有来回程一体运价，则票价差为1/2来回程一体运价的差额；如变更后舱位没有来回程一体运价，则票价差为变更后舱位单程运价与变更前1/2来回程一体运价的差额。客票自填开之日起，一年内必须开始旅行，自首次旅行开始之日起，一年内运输有效。\&quot;}]},{\&quot;refundSubItems\&quot;:[{\&quot;title\&quot;:\&quot;成人\&quot;,\&quot;isStruct\&quot;:true,\&quot;refundSubContents\&quot;:[{\&quot;feeDesc\&quot;:\&quot;￥0/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月15日 09:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月27日 09:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月29日 05:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:1,\&quot;feeRange\&quot;:\&quot;7月29日 05:30 后\&quot;}],\&quot;ptc\&quot;:\&quot;ADT\&quot;}],\&quot;index\&quot;:1,\&quot;type\&quot;:0,\&quot;tableHead\&quot;:\&quot;锡林浩特-北京\&quot;,\&quot;extraContents\&quot;:[{\&quot;title\&quot;:\&quot;特殊说明\&quot;,\&quot;content\&quot;:\&quot;改期如有差价需同时收取改期费和差价。来回程一体运价（指来回程票价低于单程票价的两倍）客票部分使用后退票，扣除票面价的1/2来回程一体运价，余额按相应舱位退规办理。来回程一体运价（指来回程票价低于单程票价的两倍）客票部分使用后变更，按1/2来回程一体运价计算变更手续费；如变更后舱位有来回程一体运价，则票价差为1/2来回程一体运价的差额；如变更后舱位没有来回程一体运价，则票价差为变更后舱位单程运价与变更前1/2来回程一体运价的差额。客票自填开之日起，一年内必须开始旅行，自首次旅行开始之日起，一年内运输有效。\&quot;}]}],\&quot;changeDetails\&quot;:[{\&quot;refundSubItems\&quot;:[{\&quot;title\&quot;:\&quot;成人\&quot;,\&quot;isStruct\&quot;:true,\&quot;refundSubContents\&quot;:[{\&quot;feeDesc\&quot;:\&quot;￥0/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月6日 07:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月18日 07:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月20日 03:00 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:1,\&quot;feeRange\&quot;:\&quot;7月20日 03:00 后\&quot;}],\&quot;ptc\&quot;:\&quot;ADT\&quot;}],\&quot;index\&quot;:0,\&quot;title\&quot;:\&quot;同舱改期规则\&quot;,\&quot;type\&quot;:1,\&quot;tableHead\&quot;:\&quot;北京-锡林浩特\&quot;,\&quot;extraContents\&quot;:[{\&quot;title\&quot;:\&quot;签转条件\&quot;,\&quot;content\&quot;:\&quot;可签转\&quot;}]},{\&quot;refundSubItems\&quot;:[{\&quot;title\&quot;:\&quot;成人\&quot;,\&quot;isStruct\&quot;:true,\&quot;refundSubContents\&quot;:[{\&quot;feeDesc\&quot;:\&quot;￥0/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月15日 09:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月27日 09:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥32/人\&quot;,\&quot;style\&quot;:0,\&quot;feeRange\&quot;:\&quot;7月29日 05:30 前\&quot;},{\&quot;feeDesc\&quot;:\&quot;￥45/人\&quot;,\&quot;style\&quot;:1,\&quot;feeRange\&quot;:\&quot;7月29日 05:30 后\&quot;}],\&quot;ptc\&quot;:\&quot;ADT\&quot;}],\&quot;index\&quot;:1,\&quot;type\&quot;:1,\&quot;tableHead\&quot;:\&quot;锡林浩特-北京\&quot;},{\&quot;refundSubItems\&quot;:[{\&quot;isStruct\&quot;:false,\&quot;content\&quot;:\&quot;可签转\&quot;}],\&quot;index\&quot;:1,\&quot;type\&quot;:2,\&quot;tableHead\&quot;:\&quot;锡林浩特-北京\&quot;}]}</para>
                    /// </summary>
                    [NameInMap("refund_change_details")]
                    [Validation(Required=false)]
                    public string RefundChangeDetails { get; set; }

                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentList> SegmentList { get; set; }
                    public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA</para>
                        /// </summary>
                        [NameInMap("air_line_code")]
                        [Validation(Required=false)]
                        public string AirLineCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Air China Limited</para>
                        /// </summary>
                        [NameInMap("air_line_english_name")]
                        [Validation(Required=false)]
                        public string AirLineEnglishName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>中国国航</para>
                        /// </summary>
                        [NameInMap("air_line_name")]
                        [Validation(Required=false)]
                        public string AirLineName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>95583</para>
                        /// </summary>
                        [NameInMap("air_line_phone")]
                        [Validation(Required=false)]
                        public string AirLinePhone { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png">https://gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon_url")]
                        [Validation(Required=false)]
                        public string AirlineIconUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>国航</para>
                        /// </summary>
                        [NameInMap("airline_short_name")]
                        [Validation(Required=false)]
                        public string AirlineShortName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>XIL</para>
                        /// </summary>
                        [NameInMap("arr_airport_code")]
                        [Validation(Required=false)]
                        public string ArrAirportCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>锡林浩特机场</para>
                        /// </summary>
                        [NameInMap("arr_airport_name")]
                        [Validation(Required=false)]
                        public string ArrAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>XIL</para>
                        /// </summary>
                        [NameInMap("arr_city_code")]
                        [Validation(Required=false)]
                        public string ArrCityCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>锡林浩特</para>
                        /// </summary>
                        [NameInMap("arr_city_name")]
                        [Validation(Required=false)]
                        public string ArrCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-20 08:25:00</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>航班到达航站楼</para>
                        /// </summary>
                        [NameInMap("arrive_terminal")]
                        [Validation(Required=false)]
                        public string ArriveTerminal { get; set; }

                        /// <summary>
                        /// <para>cabin</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>全价经济舱</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>全价经济舱0.4折</para>
                        /// </summary>
                        [NameInMap("cabin_and_discount")]
                        [Validation(Required=false)]
                        public string CabinAndDiscount { get; set; }

                        /// <summary>
                        /// <para>cabin_class</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>cabin_class_name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>全价经济舱</para>
                        /// </summary>
                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>起飞前45分钟停止办理值机</para>
                        /// </summary>
                        [NameInMap("deadline_text")]
                        [Validation(Required=false)]
                        public string DeadlineText { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("dep_airport_code")]
                        [Validation(Required=false)]
                        public string DepAirportCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>首都国际机场</para>
                        /// </summary>
                        [NameInMap("dep_airport_name")]
                        [Validation(Required=false)]
                        public string DepAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BJS</para>
                        /// </summary>
                        [NameInMap("dep_city_code")]
                        [Validation(Required=false)]
                        public string DepCityCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>北京</para>
                        /// </summary>
                        [NameInMap("dep_city_name")]
                        [Validation(Required=false)]
                        public string DepCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-29</para>
                        /// </summary>
                        [NameInMap("dep_date")]
                        [Validation(Required=false)]
                        public string DepDate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-20 07:00:00</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>航班到达航站楼</para>
                        /// </summary>
                        [NameInMap("depart_terminal")]
                        [Validation(Required=false)]
                        public string DepartTerminal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.4</para>
                        /// </summary>
                        [NameInMap("discount")]
                        [Validation(Required=false)]
                        public double? Discount { get; set; }

                        [NameInMap("flight_change")]
                        [Validation(Required=false)]
                        public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListFlightChange FlightChange { get; set; }
                        public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListFlightChange : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>由于测试原因，本航班计划起飞时间延误至03-15 07:30</para>
                            /// </summary>
                            [NameInMap("change_desc")]
                            [Validation(Required=false)]
                            public string ChangeDesc { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>出发时间延误</para>
                            /// </summary>
                            [NameInMap("change_status")]
                            [Validation(Required=false)]
                            public string ChangeStatus { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>DEP_TIME_DELAY</para>
                            /// </summary>
                            [NameInMap("change_status_code")]
                            [Validation(Required=false)]
                            public string ChangeStatusCode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>新航段信息</para>
                            /// </summary>
                            [NameInMap("new_segment")]
                            [Validation(Required=false)]
                            public object NewSegment { get; set; }

                            [NameInMap("passenger_names")]
                            [Validation(Required=false)]
                            public List<string> PassengerNames { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA1110</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ARJ</para>
                        /// </summary>
                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>时长</para>
                        /// </summary>
                        [NameInMap("fly_duration")]
                        [Validation(Required=false)]
                        public int? FlyDuration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>制造商，如&quot;波音&quot;</para>
                        /// </summary>
                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>无餐食</para>
                        /// </summary>
                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>准点率</para>
                        /// </summary>
                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司简称</para>
                        /// </summary>
                        [NameInMap("operating_air_short_name")]
                        [Validation(Required=false)]
                        public string OperatingAirShortName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司code</para>
                        /// </summary>
                        [NameInMap("operating_airline_code")]
                        [Validation(Required=false)]
                        public string OperatingAirlineCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司英文名称</para>
                        /// </summary>
                        [NameInMap("operating_airline_english_name")]
                        [Validation(Required=false)]
                        public string OperatingAirlineEnglishName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司图标</para>
                        /// </summary>
                        [NameInMap("operating_airline_icon_url")]
                        [Validation(Required=false)]
                        public string OperatingAirlineIconUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司名称</para>
                        /// </summary>
                        [NameInMap("operating_airline_name")]
                        [Validation(Required=false)]
                        public string OperatingAirlineName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航司电话</para>
                        /// </summary>
                        [NameInMap("operating_airline_phone")]
                        [Validation(Required=false)]
                        public string OperatingAirlinePhone { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>共享/承运航班号</para>
                        /// </summary>
                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>小</para>
                        /// </summary>
                        [NameInMap("plane_type")]
                        [Validation(Required=false)]
                        public string PlaneType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>服务费</para>
                        /// </summary>
                        [NameInMap("raise_price")]
                        [Validation(Required=false)]
                        public long? RaisePrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>航段Id</para>
                        /// </summary>
                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>segmentIndex</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        [NameInMap("segment_position")]
                        [Validation(Required=false)]
                        public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListSegmentPosition SegmentPosition { get; set; }
                        public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListSegmentPosition : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("journey_index")]
                            [Validation(Required=false)]
                            public int? JourneyIndex { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("segment_index")]
                            [Validation(Required=false)]
                            public int? SegmentIndex { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停机场</para>
                        /// </summary>
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停到达时间</para>
                        /// </summary>
                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停城市</para>
                        /// </summary>
                        [NameInMap("stop_city")]
                        [Validation(Required=false)]
                        public string StopCity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停城市</para>
                        /// </summary>
                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停出发时间</para>
                        /// </summary>
                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>经停次数</para>
                        /// </summary>
                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>提醒注意</para>
                /// </summary>
                [NameInMap("notice_tips")]
                [Validation(Required=false)]
                public string NoticeTips { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>往返</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public string TripType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("trip_type_code")]
                [Validation(Required=false)]
                public int? TripTypeCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_protocol")]
            [Validation(Required=false)]
            public bool? IsProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isemergency")]
            [Validation(Required=false)]
            public bool? Isemergency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("issendmessage")]
            [Validation(Required=false)]
            public bool? Issendmessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("oil_price")]
            [Validation(Required=false)]
            public long? OilPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017002195370467200</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8500</para>
            /// </summary>
            [NameInMap("order_price")]
            [Validation(Required=false)]
            public long? OrderPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017002195370467137</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailV2ResponseBodyModulePassengerList> PassengerList { get; set; }
            public class FlightOrderDetailV2ResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1991-06-21 00:00:00</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12172819047252004460056</para>
                /// </summary>
                [NameInMap("btrip_user_id")]
                [Validation(Required=false)]
                public string BtripUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>记录对其进行校验不通过的code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>中国大陆</para>
                /// </summary>
                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("credential")]
                [Validation(Required=false)]
                public FlightOrderDetailV2ResponseBodyModulePassengerListCredential Credential { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListCredential : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("birth_date")]
                    [Validation(Required=false)]
                    public string BirthDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("cert_issue_date")]
                    [Validation(Required=false)]
                    public string CertIssueDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>签发地</para>
                    /// </summary>
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>证件号</para>
                    /// </summary>
                    [NameInMap("credential_no")]
                    [Validation(Required=false)]
                    public string CredentialNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>驾照首次获取的时间</para>
                    /// </summary>
                    [NameInMap("drive_licence_first")]
                    [Validation(Required=false)]
                    public string DriveLicenceFirst { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>驾照类型</para>
                    /// </summary>
                    [NameInMap("drive_licence_type")]
                    [Validation(Required=false)]
                    public string DriveLicenceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>持有人国籍</para>
                    /// </summary>
                    [NameInMap("holder_nationality")]
                    [Validation(Required=false)]
                    public string HolderNationality { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>131332</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>身份证核验结果code</para>
                    /// </summary>
                    [NameInMap("id_check_code")]
                    [Validation(Required=false)]
                    public string IdCheckCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>发证国家</para>
                    /// </summary>
                    [NameInMap("issue_country")]
                    [Validation(Required=false)]
                    public string IssueCountry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("credentials")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModulePassengerListCredentials> Credentials { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListCredentials : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>生日</para>
                    /// </summary>
                    [NameInMap("birth_date")]
                    [Validation(Required=false)]
                    public string BirthDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>签发日期</para>
                    /// </summary>
                    [NameInMap("cert_issue_date")]
                    [Validation(Required=false)]
                    public string CertIssueDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>签发地</para>
                    /// </summary>
                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>证件号</para>
                    /// </summary>
                    [NameInMap("credential_no")]
                    [Validation(Required=false)]
                    public string CredentialNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>驾照首次获取的时间</para>
                    /// </summary>
                    [NameInMap("drive_licence_first")]
                    [Validation(Required=false)]
                    public string DriveLicenceFirst { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>驾照类型</para>
                    /// </summary>
                    [NameInMap("drive_licence_type")]
                    [Validation(Required=false)]
                    public string DriveLicenceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>到期时间</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>持有人国籍</para>
                    /// </summary>
                    [NameInMap("holder_nationality")]
                    [Validation(Required=false)]
                    public string HolderNationality { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>131332</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>身份证核验结果code</para>
                    /// </summary>
                    [NameInMap("id_check_code")]
                    [Validation(Required=false)]
                    public string IdCheckCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>发证国家</para>
                    /// </summary>
                    [NameInMap("issue_country")]
                    [Validation(Required=false)]
                    public string IssueCountry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:17800000001@163.com">17800000001@163.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>san</para>
                /// </summary>
                [NameInMap("en_first_name")]
                [Validation(Required=false)]
                public string EnFirstName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhang</para>
                /// </summary>
                [NameInMap("en_last_name")]
                [Validation(Required=false)]
                public string EnLastName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("english_name")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_complete")]
                [Validation(Required=false)]
                public bool? IsComplete { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_frequently")]
                [Validation(Required=false)]
                public bool? IsFrequently { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>备注信息</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17800000001</para>
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试乘机人</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("oneself")]
                [Validation(Required=false)]
                public bool? Oneself { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试乘机人</para>
                /// </summary>
                [NameInMap("order_name")]
                [Validation(Required=false)]
                public string OrderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("out_passenger_id")]
                [Validation(Required=false)]
                public string OutPassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17800000001</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("sheng_pi_pinyin")]
                [Validation(Required=false)]
                public string ShengPiPinyin { get; set; }

                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

                [NameInMap("tickets")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModulePassengerListTickets> Tickets { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListTickets : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>出票渠道</para>
                    /// </summary>
                    [NameInMap("channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>行程 title</para>
                    /// </summary>
                    [NameInMap("journey_title")]
                    [Validation(Required=false)]
                    public string JourneyTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OPEN_FOR_USE</para>
                    /// </summary>
                    [NameInMap("open_ticket_status")]
                    [Validation(Required=false)]
                    public string OpenTicketStatus { get; set; }

                    /// <summary>
                    /// <para>pcc/office</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pcc/office</para>
                    /// </summary>
                    [NameInMap("pcc")]
                    [Validation(Required=false)]
                    public string Pcc { get; set; }

                    [NameInMap("segment_open_ticket_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderDetailV2ResponseBodyModulePassengerListTicketsSegmentOpenTicketList> SegmentOpenTicketList { get; set; }
                    public class FlightOrderDetailV2ResponseBodyModulePassengerListTicketsSegmentOpenTicketList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public int? OpenTicketStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>不需要验真.</para>
                    /// </summary>
                    [NameInMap("ticket_auth_memo")]
                    [Validation(Required=false)]
                    public string TicketAuthMemo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ticket_auth_status")]
                    [Validation(Required=false)]
                    public int? TicketAuthStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>444-2023062999</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4500</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>出票成功</para>
                    /// </summary>
                    [NameInMap("ticket_status")]
                    [Validation(Required=false)]
                    public string TicketStatus { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>312312</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>key :passengerId</para>
            /// <para>value :segmentId</para>
            /// </summary>
            [NameInMap("passenger_segment_map")]
            [Validation(Required=false)]
            public Dictionary<string, string> PassengerSegmentMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:03:59</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4500</para>
            /// </summary>
            [NameInMap("saleprice")]
            [Validation(Required=false)]
            public long? Saleprice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendcpsms")]
            [Validation(Required=false)]
            public bool? Sendcpsms { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_service_fee_price")]
            [Validation(Required=false)]
            public long? TotalServiceFeePrice { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5F4ACF5-5677-1515-9999-ABBB5E668032</para>
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
        /// <para>210bc60a16917251281873772dac41</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
