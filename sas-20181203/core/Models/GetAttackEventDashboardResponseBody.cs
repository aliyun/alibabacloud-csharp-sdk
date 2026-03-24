// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackEventDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code, <b>200</b> indicates success, any other value indicates failure. The caller can use this field to determine the reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttackEventDashboardResponseBodyData Data { get; set; }
        public class GetAttackEventDashboardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("AttackAllCount")]
            [Validation(Required=false)]
            public int? AttackAllCount { get; set; }

            /// <summary>
            /// <para>List of attack counts by attacked asset.</para>
            /// </summary>
            [NameInMap("AttackInstanceTopCount")]
            [Validation(Required=false)]
            public List<GetAttackEventDashboardResponseBodyDataAttackInstanceTopCount> AttackInstanceTopCount { get; set; }
            public class GetAttackEventDashboardResponseBodyDataAttackInstanceTopCount : TeaModel {
                /// <summary>
                /// <para>The count of the statistics value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>Statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;internetIp\&quot;:\&quot;101.37.86.<b>\&quot;,\&quot;instanceName\&quot;:\&quot;na</b>me\&quot;,\&quot;intranetIp\&quot;:\&quot;10.1.0.*\&quot;}</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// <para>List of attack counts by attack type.</para>
            /// </summary>
            [NameInMap("AttackTypeTopCount")]
            [Validation(Required=false)]
            public List<GetAttackEventDashboardResponseBodyDataAttackTypeTopCount> AttackTypeTopCount { get; set; }
            public class GetAttackEventDashboardResponseBodyDataAttackTypeTopCount : TeaModel {
                /// <summary>
                /// <para>Count of statistical values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>Statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHP Webshell Upload</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// <para>List of attack counts by hour.</para>
            /// </summary>
            [NameInMap("LatestTimeHourCount")]
            [Validation(Required=false)]
            public List<GetAttackEventDashboardResponseBodyDataLatestTimeHourCount> LatestTimeHourCount { get; set; }
            public class GetAttackEventDashboardResponseBodyDataLatestTimeHourCount : TeaModel {
                /// <summary>
                /// <para>Count of statistical values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>Statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1752642000000</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// <para>List of attack counts by source IP.</para>
            /// </summary>
            [NameInMap("SrcIpTopCount")]
            [Validation(Required=false)]
            public List<GetAttackEventDashboardResponseBodyDataSrcIpTopCount> SrcIpTopCount { get; set; }
            public class GetAttackEventDashboardResponseBodyDataSrcIpTopCount : TeaModel {
                /// <summary>
                /// <para>Count of statistical values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>Statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140.205.11.**</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP response status code, 200 indicates that the request was sent successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success</description></item>
        /// <item><description><b>false</b>: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
