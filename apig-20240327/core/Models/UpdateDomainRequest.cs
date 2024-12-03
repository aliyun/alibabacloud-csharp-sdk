// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateDomainRequest : TeaModel {
        /// <summary>
        /// <para>Cloud Shield CA certificate identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123455-cn-hangzhou</para>
        /// </summary>
        [NameInMap("caCertIndentifier")]
        [Validation(Required=false)]
        public string CaCertIndentifier { get; set; }

        /// <summary>
        /// <para>Cloud Shield certificate identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123458-cn-hangzhou</para>
        /// </summary>
        [NameInMap("certIndentifier")]
        [Validation(Required=false)]
        public string CertIndentifier { get; set; }

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
