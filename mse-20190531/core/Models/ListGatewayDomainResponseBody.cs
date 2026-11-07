// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The node data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayDomainResponseBodyData> Data { get; set; }
        public class ListGatewayDomainResponseBodyData : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> The expiration time of the certificate. Go to the domain name details page to view the information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2031-03-30 02:35:12</para>
            /// </summary>
            [NameInMap("CertBeforeDate")]
            [Validation(Required=false)]
            public string CertBeforeDate { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3452-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The route remark (Ingress).</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public ListGatewayDomainResponseBodyDataComment Comment { get; set; }
            public class ListGatewayDomainResponseBodyDataComment : TeaModel {
                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether WAF protection is enabled for the domain name.</para>
            /// </summary>
            [NameInMap("EnableWaf")]
            [Validation(Required=false)]
            public bool? EnableWaf { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The time when the domain name record was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2031-03-30 02:35:12</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the domain name record was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2031-03-30 02:35:12</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>open</c>: HTTP/2 is enabled.</description></item>
            /// <item><description><c>close</c>: HTTP/2 is disabled.</description></item>
            /// <item><description><c>globalConfig</c>: The global configuration is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>close</para>
            /// </summary>
            [NameInMap("Http2")]
            [Validation(Required=false)]
            public string Http2 { get; set; }

            /// <summary>
            /// <para>The domain name ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>243</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is managed.</para>
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is forced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MustHttps")]
            [Validation(Required=false)]
            public bool? MustHttps { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The domain name status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unpublished</description></item>
            /// <item><description>2: publishing</description></item>
            /// <item><description>3: published</description></item>
            /// <item><description>4: editing</description></item>
            /// <item><description>5: taking offline</description></item>
            /// <item><description>6: unavailable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the gateway supports WAF protection.</para>
            /// </summary>
            [NameInMap("SupportWaf")]
            [Validation(Required=false)]
            public bool? SupportWaf { get; set; }

            /// <summary>
            /// <para>The TLS cipher suite configuration, including the configuration type and the list of cipher suite names.</para>
            /// </summary>
            [NameInMap("TlsCipherSuitesConfig")]
            [Validation(Required=false)]
            public ListGatewayDomainResponseBodyDataTlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }
            public class ListGatewayDomainResponseBodyDataTlsCipherSuitesConfig : TeaModel {
                /// <summary>
                /// <para>The TLS encrypt cipher suite configuration type. DEFAULT indicates the default configurations, and CUSTOM indicates a custom configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>The list of TLS cipher suite names.</para>
                /// </summary>
                [NameInMap("TlsCipherSuites")]
                [Validation(Required=false)]
                public List<string> TlsCipherSuites { get; set; }

            }

            /// <summary>
            /// <para>The maximum TLS version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.3</para>
            /// </summary>
            [NameInMap("TlsMax")]
            [Validation(Required=false)]
            public string TlsMax { get; set; }

            /// <summary>
            /// <para>The minimum TLS version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.0</para>
            /// </summary>
            [NameInMap("TlsMin")]
            [Validation(Required=false)]
            public string TlsMin { get; set; }

            /// <summary>
            /// <para>The source type of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Op: created in the console</description></item>
            /// <item><description>Ingress: created by MSE Ingress</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Op</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F5D8E93-CA66-57F1-8BCF-A223E11B6B91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
