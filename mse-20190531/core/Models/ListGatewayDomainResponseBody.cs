// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayDomainResponseBodyData> Data { get; set; }
        public class ListGatewayDomainResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the certificate expires.</para>
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
            /// <para>The route comment. This parameter is returned only in ingress scenarios.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public ListGatewayDomainResponseBodyDataComment Comment { get; set; }
            public class ListGatewayDomainResponseBodyDataComment : TeaModel {
                /// <summary>
                /// <para>The route status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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
            /// <para>The time when the domain name was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2031-03-30 02:35:12</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the domain name was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2031-03-30 02:35:12</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether <c>HTTP/2</c> is enabled.</para>
            /// <list type="bullet">
            /// <item><description><c>open</c>: <c>HTTP/2</c> is enabled.</description></item>
            /// <item><description><c>close</c>: <c>HTTP/2</c> is disabled.</description></item>
            /// <item><description><c>globalConfig</c>: Global configurations are used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>close</para>
            /// </summary>
            [NameInMap("Http2")]
            [Validation(Required=false)]
            public string Http2 { get; set; }

            /// <summary>
            /// <para>The ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>243</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is forcefully used.</para>
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
            /// <para>The state of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unpublished</description></item>
            /// <item><description>2: publishing</description></item>
            /// <item><description>3: published</description></item>
            /// <item><description>4: editing</description></item>
            /// <item><description>5: unpublishing</description></item>
            /// <item><description>6: unavailable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TlsCipherSuitesConfig")]
            [Validation(Required=false)]
            public ListGatewayDomainResponseBodyDataTlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }
            public class ListGatewayDomainResponseBodyDataTlsCipherSuitesConfig : TeaModel {
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                [NameInMap("TlsCipherSuites")]
                [Validation(Required=false)]
                public List<string> TlsCipherSuites { get; set; }

            }

            /// <summary>
            /// <para>The maximum version of Transport Layer Security (TLS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.3</para>
            /// </summary>
            [NameInMap("TlsMax")]
            [Validation(Required=false)]
            public string TlsMax { get; set; }

            /// <summary>
            /// <para>The minimum version of TLS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.0</para>
            /// </summary>
            [NameInMap("TlsMin")]
            [Validation(Required=false)]
            public string TlsMin { get; set; }

            /// <summary>
            /// <para>The type of the domain name source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Op: console</description></item>
            /// <item><description>Ingress: MSE Ingress</description></item>
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
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F5D8E93-CA66-57F1-8BCF-A223E11B6B91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
