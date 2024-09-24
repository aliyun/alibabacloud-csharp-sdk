// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code that is returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotAttackStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotAttackStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The statistics details.</para>
            /// </summary>
            [NameInMap("HoneypotAttackStatistics")]
            [Validation(Required=false)]
            public List<GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics> HoneypotAttackStatistics { get; set; }
            public class GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics : TeaModel {
                /// <summary>
                /// <para>The number of times the value is counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>The statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112.168.1.**</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// <para>The type of the attack source statistics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TOP_ATTACKED_AGENT</b>: the top five probes that are attacked the most frequently.</description></item>
            /// <item><description><b>TOP_ATTACKED_IP</b>: the top five IP addresses that are attacked the most frequently.</description></item>
            /// <item><description><b>ATTACK_EVENT_TYPE</b>: the type of the intrusion event.</description></item>
            /// <item><description><b>ATTACK_HONEYPOT_TYPE</b>: the type of the attacked honeypot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TOP_ATTACKED_IP</para>
            /// </summary>
            [NameInMap("StatisticsType")]
            [Validation(Required=false)]
            public string StatisticsType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FACC60A-3FE4-5F49-9184-50730C8B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
