// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the certificate expires. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-31T09:42:28Z</para>
        /// </summary>
        [NameInMap("CertExpireTime")]
        [Validation(Required=false)]
        public string CertExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>648****-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourCertName</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate authority (CA) that issued the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DigiCert Inc</para>
        /// </summary>
        [NameInMap("CertOrg")]
        [Validation(Required=false)]
        public string CertOrg { get; set; }

        /// <summary>
        /// <para>The top-level domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The content of the encryption certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--BEGIN CERTIFICATE-----***-----END CERTIFICATE--</para>
        /// </summary>
        [NameInMap("EncryptCertificate")]
        [Validation(Required=false)]
        public string EncryptCertificate { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7C69682-7F88-40DD-A198-10D0309E439D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The domain name on the additional certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***.example.com</para>
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// <para>The content of the signature certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--BEGIN CERTIFICATE-----***-----END CERTIFICATE--</para>
        /// </summary>
        [NameInMap("SignCertificate")]
        [Validation(Required=false)]
        public string SignCertificate { get; set; }

    }

}
