// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                [NameInMap("CertOrg")]
                [Validation(Required=false)]
                public string CertOrg { get; set; }

                [NameInMap("CertRegion")]
                [Validation(Required=false)]
                public string CertRegion { get; set; }

                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("CertUpdateTime")]
                [Validation(Required=false)]
                public string CertUpdateTime { get; set; }

                [NameInMap("DomainCnameStatus")]
                [Validation(Required=false)]
                public string DomainCnameStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ServerCertificate")]
                [Validation(Required=false)]
                public string ServerCertificate { get; set; }

                [NameInMap("ServerCertificateStatus")]
                [Validation(Required=false)]
                public string ServerCertificateStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1E43DC-9E51-4771-82C0-7D5ECEB547A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
