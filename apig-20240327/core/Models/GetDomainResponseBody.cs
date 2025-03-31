// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDomainResponseBodyData Data { get; set; }
        public class GetDomainResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The encryption algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The CA certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>876****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("caCertIdentifier")]
            [Validation(Required=false)]
            public string CaCertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>645****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("certIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cert</para>
            /// </summary>
            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The client CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----
            /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/mpTQwDQYJKoZIhvcNAQEL
            /// BxSbrGeJ8i0576Gn7Qezyho9abZOUhGaPeoB
            /// AIHWWl428uUSG/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            /// yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy+ZMJ8r4swA4swHwYDVR0jBBgwFoAU
            /// qroVyYKk7ylhcSn+ZMJ8r4swA4swDwYDVR0TAQH/BAUwAwEB/zANBgkqhkiG9w0B
            /// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx=
            /// -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("clientCACert")]
            [Validation(Required=false)]
            public string ClientCACert { get; set; }

            /// <summary>
            /// <para>The creation source.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Console</description></item>
            /// <item><description>Ingress</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Console</para>
            /// </summary>
            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is the default domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>The ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cq1m3utlhtgvgkv7sitg</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>Indicates whether forcible HTTPS redirection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("forceHttps")]
            [Validation(Required=false)]
            public bool? ForceHttps { get; set; }

            /// <summary>
            /// <para>The HTTP/2 configuration.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GlobalConfig</description></item>
            /// <item><description>Close</description></item>
            /// <item><description>Open</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("http2Option")]
            [Validation(Required=false)]
            public string Http2Option { get; set; }

            /// <summary>
            /// <para>The certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>Indicates whether mutual authentication is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("mTLSEnabled")]
            [Validation(Required=false)]
            public bool? MTLSEnabled { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc.com</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("notAfterTimstamp")]
            [Validation(Required=false)]
            public long? NotAfterTimstamp { get; set; }

            /// <summary>
            /// <para>The time when the certificate started to take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("notBeforeTimestamp")]
            [Validation(Required=false)]
            public long? NotBeforeTimestamp { get; set; }

            /// <summary>
            /// <para>The supported protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP: Only HTTP is supported.</description></item>
            /// <item><description>HTTPS: Only HTTPS is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzvlxzgo5b4si</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>All domain names that are bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The information about online resources.</para>
            /// </summary>
            [NameInMap("statisticsInfo")]
            [Validation(Required=false)]
            public GetDomainResponseBodyDataStatisticsInfo StatisticsInfo { get; set; }
            public class GetDomainResponseBodyDataStatisticsInfo : TeaModel {
                /// <summary>
                /// <para>The resource statistics.</para>
                /// </summary>
                [NameInMap("resourceStatistics")]
                [Validation(Required=false)]
                public List<ResourceStatistic> ResourceStatistics { get; set; }

                /// <summary>
                /// <para>The total number of resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public string TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The cipher suite configuration.</para>
            /// </summary>
            [NameInMap("tlsCipherSuitesConfig")]
            [Validation(Required=false)]
            public TlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }

            /// <summary>
            /// <para>The maximum version of the TLS protocol. Up to TLS 1.3 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.3</para>
            /// </summary>
            [NameInMap("tlsMax")]
            [Validation(Required=false)]
            public string TlsMax { get; set; }

            /// <summary>
            /// <para>The minimum version of the TLS protocol. Down to TLS 1.0 is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.0</para>
            /// </summary>
            [NameInMap("tlsMin")]
            [Validation(Required=false)]
            public string TlsMin { get; set; }

            /// <summary>
            /// <para>The update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updatetimestamp")]
            [Validation(Required=false)]
            public long? Updatetimestamp { get; set; }

        }

        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to trace the API call link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ACFC7A7-45A9-58CF-B2D5-765B60254695</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
