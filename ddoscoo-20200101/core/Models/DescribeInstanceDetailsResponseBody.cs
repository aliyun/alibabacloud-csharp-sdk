// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address and ISP line information about the Anti-DDoS Proxy instance.</para>
        /// </summary>
        [NameInMap("InstanceDetails")]
        [Validation(Required=false)]
        public List<DescribeInstanceDetailsResponseBodyInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseBodyInstanceDetails : TeaModel {
            /// <summary>
            /// <para>The IP address information about the Anti-DDoS Proxy instance.</para>
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
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203.117.XX.XX</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <para>The type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// <para>The IP address-based forwarding mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>fnat</b>: Requests from IPv4 addresses are forwarded to origin servers that use IPv4 addresses and requests from IPv6 addresses are forwarded to origin servers that use IPv6 addresses.</description></item>
                /// <item><description><b>v6tov4</b>: All requests are forwarded to origin servers that use IPv4 addresses.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>fnat</para>
                /// </summary>
                [NameInMap("IpMode")]
                [Validation(Required=false)]
                public string IpMode { get; set; }

                /// <summary>
                /// <para>The IP version of the protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Ipv4</b>: IPv4</description></item>
                /// <item><description><b>Ipv6</b>: IPv6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ipv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the TLS 1.3 version is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Ssl13Enabled")]
                [Validation(Required=false)]
                public bool? Ssl13Enabled { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: indicates that the instance is normal.</description></item>
                /// <item><description><b>expired</b>: indicates that the instance expired.</description></item>
                /// <item><description><b>defense</b>: indicates that traffic scrubbing is performed on the asset that is protected by the instance.</description></item>
                /// <item><description><b>blackhole</b>: indicates that blackhole filtering is triggered for the asset that is protected by the instance.</description></item>
                /// <item><description><b>punished</b>: indicates that the instance is in penalty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The Transport Layer Security (TLS) version that is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tls1.2</para>
                /// </summary>
                [NameInMap("TlsVersion")]
                [Validation(Required=false)]
                public string TlsVersion { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2eibz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The protection line of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coop-line-001</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C814429-21A5-4673-827E-FDD19DC75681</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
