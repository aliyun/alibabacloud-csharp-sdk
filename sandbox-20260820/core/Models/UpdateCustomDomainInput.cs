// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateCustomDomainInput : TeaModel {
        /// <summary>
        /// <para>The new HTTPS certificate configuration for the domain name. When specified, this overwrites the existing configuration.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The new description of the custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Entry domain name for the sandbox production environment</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new TLS protocol configuration for the domain name. When specified, this overwrites the existing configuration.</para>
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

    }

}
