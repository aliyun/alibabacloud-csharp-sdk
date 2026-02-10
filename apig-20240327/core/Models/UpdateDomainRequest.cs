// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The CA certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("caCertIdentifier")]
        [Validation(Required=false)]
        public string CaCertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The client CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIFBTCCAu2gAwIBAgIUORLpYPGSFD1YOP6PMbE7Wd/mpTQwDQYJKoZIhvcNAQEL
        /// BQAwE************************************************2VwVOJ2gqX3
        /// YuGaxvIbDy0iQJ1GMerPRyzJTeVEtdIKT29u0PdFRr4KZWom35qX7G4=
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("clientCACert")]
        [Validation(Required=false)]
        public string ClientCACert { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forcible HTTPS redirection. If protocol is set to HTTPS, forceHttps is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// <para>The HTTP/2 configuration.</para>
        /// <para>Enumerated values:</para>
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
        /// <para>Specifies whether to enable mutual TLS (mTLS) authentication.</para>
        /// </summary>
        [NameInMap("mTLSEnabled")]
        [Validation(Required=false)]
        public bool? MTLSEnabled { get; set; }

        /// <summary>
        /// <para>The protocol type to be supported by the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The cipher suite configuration.</para>
        /// </summary>
        [NameInMap("tlsCipherSuitesConfig")]
        [Validation(Required=false)]
        public TlsCipherSuitesConfig TlsCipherSuitesConfig { get; set; }

        /// <summary>
        /// <para>The maximum TLS version. Up to TLS 1.3 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS 1.3</para>
        /// </summary>
        [NameInMap("tlsMax")]
        [Validation(Required=false)]
        public string TlsMax { get; set; }

        /// <summary>
        /// <para>The minimum TLS version. Down to TLS 1.0 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS 1.0</para>
        /// </summary>
        [NameInMap("tlsMin")]
        [Validation(Required=false)]
        public string TlsMin { get; set; }

    }

}
