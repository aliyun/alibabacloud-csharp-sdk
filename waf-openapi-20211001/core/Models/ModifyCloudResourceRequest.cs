// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyCloudResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud resource that is added to WAF.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2839876.html">CreateCloudResource</a> to add a cloud resource. The resource ID is included in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-***-80-clb7</para>
        /// </summary>
        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The listener configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyCloudResourceRequestListen Listen { get; set; }
        public class ModifyCloudResourceRequestListen : TeaModel {
            /// <summary>
            /// <para>The certificate information.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ModifyCloudResourceRequestListenCertificates> Certificates { get; set; }
            public class ModifyCloudResourceRequestListenCertificates : TeaModel {
                /// <summary>
                /// <para>The type of the certificate for the HTTPS protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>default</b>: a default certificate.</para>
                /// </description></item>
                /// <item><description><para><b>extension</b>: an extension certificate.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

            }

            /// <summary>
            /// <para>The type of the cipher suite to add. This parameter applies only when you use the HTTPS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: adds all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: adds strong cipher suites. This value is available only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: adds custom cipher suites.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. This parameter applies only when you use the HTTPS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: TLS 1.3 is supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: TLS 1.3 is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTP/2 is enabled. This parameter applies only when you use the HTTPS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables HTTP/2.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables HTTP/2.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The listening port of the cloud service instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            [Obsolete]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>http</b>: HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>https</b>: HTTPS.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the cloud service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-***</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceInstanceId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clb4</b>: Layer 4 Classic Load Balancer (CLB).</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clb7</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The Transport Layer Security (TLS) version. This parameter applies only when you use the HTTPS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tlsv1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.2</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1.2</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

        }

        /// <summary>
        /// <para>The forwarding configuration.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public ModifyCloudResourceRequestRedirect Redirect { get; set; }
        public class ModifyCloudResourceRequestRedirect : TeaModel {
            /// <summary>
            /// <para>Indicates whether persistent connections are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): enables persistent connections.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables persistent connections.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            /// <summary>
            /// <para>The maximum number of requests that can be served through one persistent connection. Valid values: 60 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period for an idle persistent connection. Valid values: 10 to 3600. Default value: 3600. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The maximum size of a request body. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>The read timeout period. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The custom header fields used to mark traffic that is processed by WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyCloudResourceRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyCloudResourceRequestRedirectRequestHeaders : TeaModel {
                /// <summary>
                /// <para>The custom request header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the custom request header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The write timeout period. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the real IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: WAF obtains the real IP address of the client from the request. Use this value when no Layer 7 proxy resides before WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom header field as the client IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields that are used to obtain the client IP address.</para>
            /// <remarks>
            /// <para>This parameter is required only when <b>XffHeaderMode</b> is set to <b>2</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-Forwarded-Proto header is used to pass the protocol used by WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): passes the protocol.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not pass the protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
