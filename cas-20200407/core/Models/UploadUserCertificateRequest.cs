// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UploadUserCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The content of a non-SM certificate in PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIF...... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The content of the SM encryption certificate in PEM format. This parameter is invalid if Cert and Key are not empty.</para>
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
        /// <para>The content of the private key of the SM encryption certificate in PEM format. This parameter is invalid if Cert and Key are not empty.</para>
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
        /// <para>The private key of a non-SM certificate in PEM format.</para>
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
        /// <para>The custom name of the certificate. The name can be up to 63 characters long and can contain letters, digits, and underscores (_).</para>
        /// <remarks>
        /// <para>Certificate names must be unique for each user.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae****vty</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The content of the SM signing certificate in PEM format. This parameter is invalid if Cert and Key are not empty.</para>
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
        /// <para>The content of the private key of the SM signing certificate in PEM format. This parameter is invalid if Cert and Key are not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN EC PRIVATE KEY-----
        /// MHcCAQEEILR****
        /// -----END EC PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UploadUserCertificateRequestTags> Tags { get; set; }
        public class UploadUserCertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
