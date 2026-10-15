// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CustomDomainResp : TeaModel {
        /// <summary>
        /// <para>The HTTPS certificate configuration used by the domain name.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The time when the domain name was created. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755676800000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Domain name for the sandbox preview environment</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox.example.com</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The TLS protocol configuration used by the domain name.</para>
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        /// <summary>
        /// <para>The time when the domain name was last updated. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755763200000</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
