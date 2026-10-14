// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDoSEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of DDoS attack events.</para>
        /// </summary>
        [NameInMap("DDoSEvents")]
        [Validation(Required=false)]
        public List<DescribeDDoSEventsResponseBodyDDoSEvents> DDoSEvents { get; set; }
        public class DescribeDDoSEventsResponseBodyDDoSEvents : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the attack traffic. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// <para>The time when the attack ended. This is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583933330</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The type of the attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>defense</b>: scrubbing events.</para>
            /// </description></item>
            /// <item><description><para><b>blackhole</b>: blackhole filtering events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blackhole</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The attacked IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.132</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The attacked port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of the attack traffic. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// <para>The source location of the attack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn</b>: the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>alb-ap-northeast-1-gf-x</b>: Japan.</para>
            /// </description></item>
            /// <item><description><para><b>alb-ap-southeast-gf-x</b>: Singapore.</para>
            /// </description></item>
            /// <item><description><para><b>alb-cn-hongkong-gf-x</b>: Hong Kong (China).</para>
            /// </description></item>
            /// <item><description><para><b>alb-eu-central-1-gf-x</b>: Germany.</para>
            /// </description></item>
            /// <item><description><para><b>alb-us-west-1-gf-x</b>: US (West).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Values other than <b>cn</b> are available only for the Anti-DDoS Premium service, for which the <b>RegionId</b> is <b>ap-southeast-1</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the attack started. This is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583933277</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CA72AF5-1795-4350-8C77-50A448A2F334</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of attack events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
