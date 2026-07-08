// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateCloudResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
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
        public CreateCloudResourceRequestListen Listen { get; set; }
        public class CreateCloudResourceRequestListen : TeaModel {
            /// <summary>
            /// <para>The list of certificate IDs.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateCloudResourceRequestListenCertificates> Certificates { get; set; }
            public class CreateCloudResourceRequestListenCertificates : TeaModel {
                /// <summary>
                /// <para>The certificate type for the HTTPS protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>default</b>: default certificate.</para>
                /// </description></item>
                /// <item><description><para><b>extension</b>: extended certificate.</para>
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
                /// <para>The ID of the certificate to add.</para>
                /// <remarks>
                /// <para>You can call <a href="https://help.aliyun.com/document_detail/2718120.html">DescribeResourceInstanceCerts</a> to query the IDs of all SSL certificates associated with the cloud service instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

            }

            /// <summary>
            /// <para>The type of cipher suite to add. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: strong cipher suites. This value is valid only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: custom cipher suites.</para>
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
            /// <para>The specific custom cipher suites to add. This parameter is used only when <b>CipherSuite</b> is set to <b>99</b>.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Specifies whether TLS 1.3 is supported. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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
            /// <para>Specifies whether to enable HTTP/2. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): HTTP/2 is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>The port of the cloud service connected to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>http</b>: HTTP.</description></item>
            /// <item><description><b>https</b>: HTTPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the cloud service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1*****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The cloud service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clb4</b>: Layer 4 CLB.</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: ECS.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: NLB.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clb4</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud service.</para>
            /// <remarks>
            /// <para>This parameter is required when the instance ID to be connected has not been synchronized to WAF.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The TLS version to add. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tlsv1</b></description></item>
            /// <item><description><b>tlsv1.1</b></description></item>
            /// <item><description><b>tlsv1.2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

        }

        /// <summary>
        /// <para>The UID that indicates the resource ownership.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The forwarding configuration.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public CreateCloudResourceRequestRedirect Redirect { get; set; }
        public class CreateCloudResourceRequestRedirect : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable persistent connections. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Persistent connections are enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Persistent connections are not enabled.</para>
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
            /// <para>The number of requests that can reuse a persistent connection. Valid values: 60 to 1000.</para>
            /// <remarks>
            /// <para>After persistent connections are enabled, this parameter specifies how many requests can reuse a persistent connection.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The idle timeout period for persistent connections. Valid values: 10 to 3600. Default value: 3600. Unit: seconds.</para>
            /// <remarks>
            /// <para>Specifies how long an idle persistent connection can remain open before it is released.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The maximum request body size. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>Only Ultimate Edition is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>The read timeout period. Unit: seconds.
            /// Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The value of this parameter is in the format of [<b>{&quot;k&quot;:&quot;<em>key</em>&quot;,&quot;v&quot;:&quot;<em>value</em>&quot;}</b>], where <b><em>key</em></b> specifies the custom request header field and <b><em>value</em></b> specifies the value of the field.</para>
            /// <remarks>
            /// <para>If the custom header field already exists in the request, the system overwrites the value of the field with the specified traffic mark value.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<CreateCloudResourceRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class CreateCloudResourceRequestRedirectRequestHeaders : TeaModel {
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
            /// <para>The write timeout period. Unit: seconds.
            /// Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the originating IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No Layer 7 proxy is deployed in front of WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom header field that you specify as the client IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The list of custom header fields used to obtain the client IP address, in the format of [<b>&quot;header1&quot;,&quot;header2&quot;,...</b>].</para>
            /// <remarks>
            /// <para>This parameter is required only when <b>XffHeaderMode</b> is set to 2, which indicates that WAF reads the value of a custom header field as the client IP address.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            /// <summary>
            /// <para>Specifies whether to use X-Forward-For-Proto to pass the protocol used by WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The protocol used by WAF is passed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The protocol used by WAF is not passed.</para>
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
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
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
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags. A maximum of 20 tags can be specified.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCloudResourceRequestTag> Tag { get; set; }
        public class CreateCloudResourceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
