// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosAllEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The DDoS attack events.</para>
        /// </summary>
        [NameInMap("AttackEvents")]
        [Validation(Required=false)]
        public List<DescribeDDosAllEventListResponseBodyAttackEvents> AttackEvents { get; set; }
        public class DescribeDDosAllEventListResponseBodyAttackEvents : TeaModel {
            /// <summary>
            /// <para>The source location or region from which the attack was initiated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: Chinese mainland</description></item>
            /// <item><description><b>alb-cn-hongkong-gf-2</b>: China (Hongkong)</description></item>
            /// <item><description><b>alb-us-west-1-gf-2</b>: US (Silicon Valley)</description></item>
            /// <item><description><b>alb-ap-northeast-1-gf-1</b>: Japan (Tokyo)</description></item>
            /// <item><description><b>alb-ap-southeast-gf-1</b>: Singapore</description></item>
            /// <item><description><b>alb-eu-central-1-gf-1</b>: Germany (Frankfurt)</description></item>
            /// <item><description><b>alb-eu-central-1-gf-1</b> or <b>selb-eu-west-1-gf-1a</b>: UK (London)</description></item>
            /// <item><description><b>alb-us-east-gf-1</b>: US (Virginia)</description></item>
            /// <item><description><b>CT-yundi</b>: China (Hongkong) This value is returned only for Anti-DDoS Premium instances of the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>The time when the DDoS attack stopped. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634546030</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The type of the DDoS attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web-cc</b>: resource exhaustion attacks</description></item>
            /// <item><description><b>cc</b>: connection flood attacks</description></item>
            /// <item><description><b>defense</b>: DDoS attacks that trigger traffic scrubbing</description></item>
            /// <item><description><b>blackhole</b>: DDoS attacks that trigger blackhole filtering</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cc</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The attacked object. The attacked object varies based on the attack event type. The following list describes different attacked objects of different attack event types:</para>
            /// <list type="bullet">
            /// <item><description>If <b>EventType</b> is set to <b>web-cc</b>, the value of this parameter indicates the domain name of the attacked website.</description></item>
            /// <item><description>If <b>EventType</b> is set to <b>cc</b>, the value of this parameter indicates the IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
            /// <item><description>If <b>EventType</b> is set to <b>defense</b> or <b>blackhole</b>, the value of this parameter indicates the IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The peak bandwidth of the attack traffic. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101899</para>
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public long? Mbps { get; set; }

            /// <summary>
            /// <para>The attacked port.</para>
            /// <remarks>
            /// <para>If <b>EventType</b> is set to <b>web-cc</b>, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The peak packet forwarding rate of attack traffic. Unit: packets per second (pps).</para>
            /// 
            /// <b>Example:</b>
            /// <para>9664270</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// <para>The time when the DDoS attack started. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634543764</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D83ED5-28CB-5683-9CF7-AECE521F3005</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DDoS attack events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
