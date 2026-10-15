// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateCustomDomainInput : TeaModel {
        /// <summary>
        /// <para>The certificate configuration for the domain name.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The description of the custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产环境云沙箱自定义域名</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The TLS configuration for the domain name.</para>
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

    }

}
