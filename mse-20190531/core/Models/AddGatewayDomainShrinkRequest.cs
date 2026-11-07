// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayDomainShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese. This is the default value.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The content of the CA certificate.</para>
        /// </summary>
        [NameInMap("CaCertIdentifier")]
        [Validation(Required=false)]
        public string CaCertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6828169-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-86575c0bc9f04ecfbacb92b8e392****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTP/2. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>open</c>: Enables HTTP/2.</description></item>
        /// <item><description><c>close</c>: Disables HTTP/2.</description></item>
        /// <item><description><c>globalConfig</c>: Uses the global configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>close</para>
        /// </summary>
        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mTLS.</para>
        /// </summary>
        [NameInMap("MtlsEnabled")]
        [Validation(Required=false)]
        public bool? MtlsEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTPS.</para>
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
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>HTTP</c></description></item>
        /// <item><description><c>HTTPS</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The TLS cipher suite configuration.</para>
        /// </summary>
        [NameInMap("TlsCipherSuitesConfigJSON")]
        [Validation(Required=false)]
        public string TlsCipherSuitesConfigJSONShrink { get; set; }

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

    }

}
