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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
                /// <para>The type of the certificate for the HTTPS protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>default</b>: the default certificate.</para>
                /// </description></item>
                /// <item><description><para><b>extension</b>: the additional certificate.</para>
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
                /// <para>Call <a href="https://help.aliyun.com/document_detail/2718120.html">DescribeResourceInstanceCerts</a> to query the IDs of all SSL certificates that are associated with the cloud product instance.</para>
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
            /// <item><description><para><b>1</b>: Adds all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Adds strong cipher suites. You can select this value only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: Adds custom cipher suites.</para>
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
            /// <para>The custom cipher suites to add. This parameter is used only when <b>CipherSuite</b> is set to <b>99</b>.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Specifies whether to support TLS 1.3. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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

            /// <summary>
            /// <para>The port of the cloud product that is added to WAF.</para>
            /// <para>This parameter is required.</para>
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

            /// <summary>
            /// <para>The ID of the cloud product instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1*****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the cloud product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clb4</b>: Layer 4 CLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: Layer 7 CLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB) instance.</para>
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
            /// <para>The region ID of the cloud product.</para>
            /// <remarks>
            /// <para>This parameter is required if the ID of the instance that you want to add has not been synchronized to WAF.</para>
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
            /// <item><description><para><b>tlsv1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.2</b></para>
            /// </description></item>
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
        /// <para>The Alibaba Cloud account ID of the resource owner.</para>
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
            /// <para>The number of requests that can be reused in a persistent connection. Valid values: 60 to 1000.</para>
            /// <remarks>
            /// <para>The number of requests that are reused over a persistent connection.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period for an idle persistent connection. Valid values: 10 to 3600. Default value: 3600. Unit: seconds.</para>
            /// <remarks>
            /// <para>The period of time after which an idle persistent connection is released.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The maximum size of a request body. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>This feature is available only for the WAF Ultimate edition.</para>
            /// </remarks>
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
            /// <para>The value of this parameter is in the \<c>[**{&quot;k&quot;:&quot;*****key*****&quot;,&quot;v&quot;:&quot;*****value*****&quot;}**]\\</c> format. <em><b>key</b></em> indicates the custom request header field. <em><b>value</b></em> indicates the value of the field.</para>
            /// <remarks>
            /// <para>If the custom header field already exists in the request, the system overwrites the value of the custom header field with the specified value.</para>
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
            /// <item><description><para><b>0</b>: No Layer 7 proxy is deployed before WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value of the XFF header field to obtain the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom header field to obtain the client IP address.</para>
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
            /// <para>The list of custom header fields that are used to obtain the client IP address. The value is in the \<c>[**&quot;header1&quot;,&quot;header2&quot;,...**]\\</c> format.</para>
            /// <remarks>
            /// <para>This parameter is required only when <b>XffHeaderMode</b> is set to 2, which indicates that WAF reads the value of a custom header field to obtain the client IP address.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the X-Forwarded-Proto header to pass the WAF protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): passes the WAF protocol.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not pass the WAF protocol.</para>
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
        /// <para>The region where the WAF instance resides. Valid values:</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags. You can add up to 20 tags.</para>
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
