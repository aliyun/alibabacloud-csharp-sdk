// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnCertificateSigningRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The Common Name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The content of the CSR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----\nMIIC/zCCAecCAQAwZTELMAkGA1UEBhMCQ04xCzAJBgNVBAgTAlpKMQswCQYDVQQH</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The MD5 hash value of the certificate public key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>629bf4fd8104eda171135bcb0f77a10b</para>
        /// </summary>
        [NameInMap("PubMd5")]
        [Validation(Required=false)]
        public string PubMd5 { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
