// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayDomainShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6209108-cn-hangzhou</para>
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
        /// <para>Specifies whether to enable <c>HTTP/2</c>.</para>
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
        /// <para>The ID of the domain name that you want to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MustHttps")]
        [Validation(Required=false)]
        public bool? MustHttps { get; set; }

        /// <summary>
        /// <para>The type of the protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTPS</description></item>
        /// <item><description>HTTP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("TlsCipherSuitesConfigJSON")]
        [Validation(Required=false)]
        public string TlsCipherSuitesConfigJSONShrink { get; set; }

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

    }

}
