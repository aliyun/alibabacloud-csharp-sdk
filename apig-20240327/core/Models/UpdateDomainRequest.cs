// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateDomainRequest : TeaModel {
        [NameInMap("caCertIdentifier")]
        [Validation(Required=false)]
        public string CaCertIdentifier { get; set; }

        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>Set the HTTPS protocol type, whether to enable forced HTTPS redirection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// <para>HTTP/2 settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("http2Option")]
        [Validation(Required=false)]
        public string Http2Option { get; set; }

        /// <summary>
        /// <para>The protocol type supported by the domain.</para>
        /// <list type="bullet">
        /// <item><description>HTTP: Supports only HTTP protocol.</description></item>
        /// <item><description>HTTPS: Supports only HTTPS protocol.</description></item>
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
        /// <para>TLS Cipher Suite Configuration.</para>
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

    }

}
