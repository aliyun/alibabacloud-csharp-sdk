// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDomainResponseBodyData Data { get; set; }
        public class GetDomainResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Encryption algorithm name</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>CA certificate identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>876****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("caCertIdentifier")]
            [Validation(Required=false)]
            public string CaCertIdentifier { get; set; }

            /// <summary>
            /// <para>Certificate Identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>645****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("certIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>Certificate name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cert</para>
            /// </summary>
            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>Client CA Cert</para>
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
            /// <para>Where it was created from.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Console</para>
            /// </summary>
            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            /// <summary>
            /// <para>Creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Whether it is the default domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            /// <summary>
            /// <para>Domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cq1m3utlhtgvgkv7sitg</para>
            /// </summary>
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>Setting for HTTPS protocol type, whether to enable forced HTTPS redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("forceHttps")]
            [Validation(Required=false)]
            public bool? ForceHttps { get; set; }

            /// <summary>
            /// <para>HTTP/2 setting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("http2Option")]
            [Validation(Required=false)]
            public string Http2Option { get; set; }

            /// <summary>
            /// <para>Certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>true</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("mTLSEnabled")]
            [Validation(Required=false)]
            public bool? MTLSEnabled { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc.com</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Certificate expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("notAfterTimstamp")]
            [Validation(Required=false)]
            public long? NotAfterTimstamp { get; set; }

            /// <summary>
            /// <para>Certificate effective time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("notBeforeTimestamp")]
            [Validation(Required=false)]
            public long? NotBeforeTimestamp { get; set; }

            /// <summary>
            /// <para>The protocol types supported by the domain.</para>
            /// <list type="bullet">
            /// <item><description>HTTP: Supports only HTTP protocol.</description></item>
            /// <item><description>HTTPS: Supports only HTTPS protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzvlxzgo5b4si</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>All domain names bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.com</para>
            /// </summary>
            [NameInMap("sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The array of domain related resource information</para>
            /// </summary>
            [NameInMap("statisticsInfo")]
            [Validation(Required=false)]
            public GetDomainResponseBodyDataStatisticsInfo StatisticsInfo { get; set; }
            public class GetDomainResponseBodyDataStatisticsInfo : TeaModel {
                /// <summary>
                /// <para>The array of related resource infomations.</para>
                /// </summary>
                [NameInMap("resourceStatistics")]
                [Validation(Required=false)]
                public List<ResourceStatistic> ResourceStatistics { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public string TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The TLS cipher suites config.</para>
            /// </summary>
            [NameInMap("tlsCipherSuitesConfig")]
            [Validation(Required=false)]
            public TlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }

            /// <summary>
            /// <para>Maximum TLS protocol version, supports up to TLS 1.3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.3</para>
            /// </summary>
            [NameInMap("tlsMax")]
            [Validation(Required=false)]
            public string TlsMax { get; set; }

            /// <summary>
            /// <para>Minimum TLS protocol version, supports down to TLS 1.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS 1.0</para>
            /// </summary>
            [NameInMap("tlsMin")]
            [Validation(Required=false)]
            public string TlsMin { get; set; }

            /// <summary>
            /// <para>Update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updatetimestamp")]
            [Validation(Required=false)]
            public long? Updatetimestamp { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, used for tracing the API call chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ACFC7A7-45A9-58CF-B2D5-765B60254695</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
