// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDoSEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The DDoS attack events.</para>
        /// </summary>
        [NameInMap("DDoSEvents")]
        [Validation(Required=false)]
        public List<DescribeDDoSEventsResponseBodyDDoSEvents> DDoSEvents { get; set; }
        public class DescribeDDoSEventsResponseBodyDDoSEvents : TeaModel {
            /// <summary>
            /// <para>The bandwidth of attack traffic. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// <para>The time when the DDoS attack stopped. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <item><description><b>defense</b>: traffic scrubbing events</description></item>
            /// <item><description><b>blackhole</b>: blackhole filtering events</description></item>
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
            /// <para>The packet forwarding rate of attack traffic. Unit: packets per second (pps).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// <para>The region from which the attack was launched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: a region in the Chinese mainland</description></item>
            /// <item><description><b>alb-ap-northeast-1-gf-x</b>: Japan (Tokyo)</description></item>
            /// <item><description><b>alb-ap-southeast-gf-x</b>: Singapore</description></item>
            /// <item><description><b>alb-cn-hongkong-gf-x</b>: Hong Kong (China)</description></item>
            /// <item><description><b>alb-eu-central-1-gf-x</b>: Germany (Frankfurt)</description></item>
            /// <item><description><b>alb-us-west-1-gf-x</b>: US (Silicon Valley)</description></item>
            /// </list>
            /// <remarks>
            /// <para>The values except <b>cn</b> are returned only when <b>RegionId</b> is set to <b>ap-southeast-1</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the DDoS attack started. The value is a UNIX timestamp. Unit: seconds.</para>
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
        /// <para>The total number of returned attack events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
