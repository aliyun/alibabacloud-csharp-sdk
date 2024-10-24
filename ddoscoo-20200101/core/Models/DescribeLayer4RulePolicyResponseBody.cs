// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeLayer4RulePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The port of the origin server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022</para>
        /// </summary>
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public int? BackendPort { get; set; }

        /// <summary>
        /// <para>The mode that is used to forward service traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the default mode. In this mode, Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the origin IP address that you specified when you created the port forwarding rule. You can call the <a href="https://help.aliyun.com/document_detail/157482.html">CreateNetworkRules</a> operation to create a port forwarding rule.</description></item>
        /// <item><description>1: the origin redundancy mode. In this mode, Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary or secondary origin servers. You can call the <a href="https://help.aliyun.com/document_detail/312684.html">ConfigLayer4RulePolicy</a> operation to configure IP addresses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BakMode")]
        [Validation(Required=false)]
        public string BakMode { get; set; }

        /// <summary>
        /// <para>The origin server that is used to receive service traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.</description></item>
        /// <item><description><b>2</b>: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentIndex")]
        [Validation(Required=false)]
        public int? CurrentIndex { get; set; }

        /// <summary>
        /// <para>The type of the protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>udp</para>
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// <para>The forwarding port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosDip-sg-4hr2b3l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the primary origin server, including the IP addresses, forwarding protocol, and forwarding port.</para>
        /// </summary>
        [NameInMap("PriRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodyPriRealServers> PriRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodyPriRealServers : TeaModel {
            /// <summary>
            /// <para>The origin server that is used to receive service traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.</description></item>
            /// <item><description><b>2</b>: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
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
            /// <para>2020</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosDip-sg-4hr2b3l****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The IP address of the primary origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.2.1</para>
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E46CC51-36BE-1100-B14C-DAF8381B8F73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the secondary origin server, including the IP addresses, forwarding protocol, and forwarding port.</para>
        /// </summary>
        [NameInMap("SecRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodySecRealServers> SecRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodySecRealServers : TeaModel {
            /// <summary>
            /// <para>The origin server that is used to receive service traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.</description></item>
            /// <item><description><b>2</b>: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
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
            /// <para>2020</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosDip-sg-4hr2b3l****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The IP address of the secondary origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.2.3</para>
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

    }

}
