// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UploadUserCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The content of the certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIF...... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The content of the encryption certificate in PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICDzCCA***
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("EncryptCert")]
        [Validation(Required=false)]
        public string EncryptCert { get; set; }

        /// <summary>
        /// <para>The private key of the encryption certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN EC PRIVATE KEY-----
        /// MHcCAQEEI****
        /// -----END EC PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("EncryptPrivateKey")]
        [Validation(Required=false)]
        public string EncryptPrivateKey { get; set; }

        /// <summary>
        /// <para>The private key of the certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICDzCCAbagAw****
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The name of the certificate. The name can contain up to 128 characters in length. The name can contain all types of characters, such as letters, digits, and underscores (_).</para>
        /// <remarks>
        /// <para> The name must be unique within an Alibaba Cloud account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cert-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>the resource group id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae****vty</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The content of the signing certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICDzCCAbagAw****
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SignCert")]
        [Validation(Required=false)]
        public string SignCert { get; set; }

        /// <summary>
        /// <para>The private key of the signing certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN EC PRIVATE KEY-----
        /// MHcCAQEEILR****
        /// -----END EC PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

    }

}
