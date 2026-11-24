// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UserCertificate : TeaModel {
        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-aabbccdd</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The certificate content in PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIID...****
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The certificate description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal network application access certificate</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain names for which the certificate is valid.</para>
        /// </summary>
        [NameInMap("DnsNames")]
        [Validation(Required=false)]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1734492686</para>
        /// </summary>
        [NameInMap("ExpTimeUnix")]
        [Validation(Required=false)]
        public long? ExpTimeUnix { get; set; }

        /// <summary>
        /// <para>The creation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1734523812</para>
        /// </summary>
        [NameInMap("GmtCreateUnix")]
        [Validation(Required=false)]
        public long? GmtCreateUnix { get; set; }

        /// <summary>
        /// <para>The update timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1734523812</para>
        /// </summary>
        [NameInMap("GmtModifiedUnix")]
        [Validation(Required=false)]
        public long? GmtModifiedUnix { get; set; }

        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Certificate 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The PEM private key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----
        /// MIIE...****
        /// -----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
