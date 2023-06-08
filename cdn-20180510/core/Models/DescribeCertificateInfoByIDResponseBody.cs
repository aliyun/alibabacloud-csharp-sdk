// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCertificateInfoByIDResponseBody : TeaModel {
        /// <summary>
        /// The information about the certificate.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeCertificateInfoByIDResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeCertificateInfoByIDResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeCertificateInfoByIDResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeCertificateInfoByIDResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// The time at which the certificate expires.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The ID of the certificate.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// The name of the certificate.
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// The type of the certificate.
                /// 
                /// *   free: a free certificate
                /// *   cas: a certificate purchased by using Certificate Management Service
                /// *   upload: a user-uploaded certificate
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The time when the certificate became effective.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The domain names that use the certificate.
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// The content of the certificate.
                /// </summary>
                [NameInMap("HttpsCrt")]
                [Validation(Required=false)]
                public string HttpsCrt { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
