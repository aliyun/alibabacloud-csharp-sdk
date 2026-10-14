// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address and line information of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// </summary>
        [NameInMap("InstanceDetails")]
        [Validation(Required=false)]
        public List<DescribeInstanceDetailsResponseBodyInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseBodyInstanceDetails : TeaModel {
            /// <summary>
            /// <para>The IP information of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// </summary>
            [NameInMap("EipInfos")]
            [Validation(Required=false)]
            public List<DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfos> EipInfos { get; set; }
            public class DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfos : TeaModel {
                /// <summary>
                /// <para>Indicates whether a custom certificate is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CertConfigured")]
                [Validation(Required=false)]
                public bool? CertConfigured { get; set; }

                /// <summary>
                /// <para>The Anti-DDoS Pro and Anti-DDoS Premium IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203.117.XX.XX</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// <para>The IP forwarding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>fnat</b>: The IP versions of the origin server and the client are the same. IPv4 client requests are forwarded to IPv4 origin servers, and IPv6 client requests are forwarded to IPv6 origin servers.</description></item>
                /// <item><description><b>v6tov4</b>: IPv6 client requests are forwarded to IPv4 origin servers.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>fnat</para>
                /// </summary>
                [NameInMap("IpMode")]
                [Validation(Required=false)]
                public string IpMode { get; set; }

                /// <summary>
                /// <para>The IP protocol version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Ipv4</b>: IPv4.</description></item>
                /// <item><description><b>Ipv6</b>: IPv6.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ipv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether TLS 1.3 is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Ssl13Enabled")]
                [Validation(Required=false)]
                public bool? Ssl13Enabled { get; set; }

                /// <summary>
                /// <para>The status of the Anti-DDoS Pro and Anti-DDoS Premium IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>expired</b>: Expired.</description></item>
                /// <item><description><b>defense</b>: Cleaning.</description></item>
                /// <item><description><b>blackhole</b>: Black Hole Activated.</description></item>
                /// <item><description><b>punished</b>: Penalized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The custom TLS version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tls1.2</para>
                /// </summary>
                [NameInMap("TlsVersion")]
                [Validation(Required=false)]
                public string TlsVersion { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2eibz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The protection line of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coop-line-001</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C814429-21A5-4673-827E-FDD19DC75681</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
