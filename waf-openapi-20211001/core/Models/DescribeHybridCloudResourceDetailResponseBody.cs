// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourceDetailResponseBody : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeHybridCloudResourceDetailResponseBodyDomain Domain { get; set; }
        public class DescribeHybridCloudResourceDetailResponseBodyDomain : TeaModel {
            /// <summary>
            /// <para>CNAME</para>
            /// 
            /// <b>Example:</b>
            /// <para>kdmqyi3ck7xogegxpiyfpb0fj21mgkxn.****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>www.*****.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>31323</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourceDetailResponseBodyDomainListen Listen { get; set; }
            public class DescribeHybridCloudResourceDetailResponseBodyDomainListen : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>19312542-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CipherSuite")]
                [Validation(Required=false)]
                public int? CipherSuite { get; set; }

                [NameInMap("CustomCiphers")]
                [Validation(Required=false)]
                public List<string> CustomCiphers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableTLSv3")]
                [Validation(Required=false)]
                public bool? EnableTLSv3 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExclusiveIp")]
                [Validation(Required=false)]
                public bool? ExclusiveIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttps")]
                [Validation(Required=false)]
                public bool? FocusHttps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Http2Enabled")]
                [Validation(Required=false)]
                public bool? Http2Enabled { get; set; }

                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public List<long?> HttpPorts { get; set; }

                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public List<long?> HttpsPorts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IPv6Enabled")]
                [Validation(Required=false)]
                public bool? IPv6Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>share</para>
                /// </summary>
                [NameInMap("ProtectionResource")]
                [Validation(Required=false)]
                public string ProtectionResource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tlsv1</para>
                /// </summary>
                [NameInMap("TLSVersion")]
                [Validation(Required=false)]
                public string TLSVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("XffHeaderMode")]
                [Validation(Required=false)]
                public int? XffHeaderMode { get; set; }

                [NameInMap("XffHeaders")]
                [Validation(Required=false)]
                public List<string> XffHeaders { get; set; }

            }

            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourceDetailResponseBodyDomainRedirect Redirect { get; set; }
            public class DescribeHybridCloudResourceDetailResponseBodyDomainRedirect : TeaModel {
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CnameEnabled")]
                [Validation(Required=false)]
                public bool? CnameEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttpBackend")]
                [Validation(Required=false)]
                public bool? FocusHttpBackend { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public bool? Keepalive { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iphash</para>
                /// </summary>
                [NameInMap("Loadbalance")]
                [Validation(Required=false)]
                public string Loadbalance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourceDetailResponseBodyDomainRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourceDetailResponseBodyDomainRedirectRequestHeaders : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>L2x1ZmZ5L2NvcmUvYXBwcy9tLnl1bmR1bi53YWYuMS9wbHVnaW5z</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9506360478730</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public bool? Retry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;backupRs\&quot;:[],\&quot;location\&quot;:\&quot;v3-test\&quot;,\&quot;locationId\&quot;:1148,\&quot;rs\&quot;:[\&quot;39.98.217.197\&quot;,\&quot;2.2.2.2\&quot;]}]</para>
                /// </summary>
                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public string RoutingRules { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SniEnabled")]
                [Validation(Required=false)]
                public bool? SniEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eew111</para>
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-***aby</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1046011128270720</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
