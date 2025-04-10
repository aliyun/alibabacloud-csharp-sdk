// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer4RulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed configuration of port forwarding rules, including the forwarding port, forwarding protocol, and origin server addresses, etc.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulesResponseBodyListeners> Listeners { get; set; }
        public class DescribeLayer4RulesResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The origin server port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            /// <summary>
            /// <para>The origin mode. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Indicates the default origin mode.</description></item>
            /// <item><description><b>1</b>: Indicates the primary/backup origin mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BakMode")]
            [Validation(Required=false)]
            public int? BakMode { get; set; }

            /// <summary>
            /// <para>The currently effective origin server type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Indicates that the primary origin server settings are in effect (DDoS protection forwards business traffic to the primary origin server IP address).</description></item>
            /// <item><description><b>2</b>: Indicates that the backup origin server settings are in effect (DDoS protection forwards business traffic to the backup origin server IP address).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            /// <summary>
            /// <para>The IP address of the DDoS protection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.XX.XX</para>
            /// </summary>
            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the DDoS protection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2ay9b****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule was automatically created. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Indicates that the rule was automatically created by DDoS protection.</description></item>
            /// <item><description><b>false</b>: Indicates that the rule was manually created by you.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            /// <summary>
            /// <para>Payload rule module switch. Values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled</description></item>
            /// <item><description>0: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PayloadRuleEnable")]
            [Validation(Required=false)]
            public long? PayloadRuleEnable { get; set; }

            /// <summary>
            /// <para>The type of forwarding protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Traffic diversion switch. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> Off.</description></item>
            /// <item><description><b>1</b> On.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProxyEnable")]
            [Validation(Required=false)]
            public int? ProxyEnable { get; set; }

            /// <summary>
            /// <para>Traffic diversion status. Values:</para>
            /// <list type="bullet">
            /// <item><description>on: Diversion is effective</description></item>
            /// <item><description>off: Diversion is ineffective</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The list of origin server IP addresses.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// <para>The remarks for the port forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("UsTimeout")]
            [Validation(Required=false)]
            public DescribeLayer4RulesResponseBodyListenersUsTimeout UsTimeout { get; set; }
            public class DescribeLayer4RulesResponseBodyListenersUsTimeout : TeaModel {
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                [NameInMap("RsTimeout")]
                [Validation(Required=false)]
                public long? RsTimeout { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>949919A2-6636-1444-9213-AB27DD88AAA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
