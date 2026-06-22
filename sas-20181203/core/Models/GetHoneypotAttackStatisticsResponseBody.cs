// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The statistics information data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotAttackStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotAttackStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The list of statistics information.</para>
            /// </summary>
            [NameInMap("HoneypotAttackStatistics")]
            [Validation(Required=false)]
            public List<GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics> HoneypotAttackStatistics { get; set; }
            public class GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics : TeaModel {
                /// <summary>
                /// <para>The count of the statistics value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// <para>The statistics value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112.168.1.**</para>
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// <para>The type of attack source statistics information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TOP_ATTACKED_AGENT</b>: the top 5 probes by number of attacks.</description></item>
            /// <item><description><b>TOP_ATTACKED_IP</b>: the top 5 IP addresses by number of attacks.</description></item>
            /// <item><description><b>ATTACK_EVENT_TYPE</b>: the intrusion event type.</description></item>
            /// <item><description><b>ATTACK_HONEYPOT_TYPE</b>: the type of the compromised honeypot.</description></item>
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
        /// <para>The HTTP status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FACC60A-3FE4-5F49-9184-50730C8B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
