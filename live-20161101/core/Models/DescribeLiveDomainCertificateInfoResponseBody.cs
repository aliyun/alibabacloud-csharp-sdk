// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate information.</para>
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeLiveDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeLiveDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// <para>The streaming domain or ingest domain that matches the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                /// <summary>
                /// <para>The expiration time of the certificate. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-06-03T22:03:39Z</para>
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// <para>The validity period of the certificate.</para>
                /// <list type="bullet">
                /// <item><description>If the validity period is greater than 12 months, XX years XX months is displayed. For example, 2 years 3 months indicates that the validity period is 2 years and 3 months.</description></item>
                /// <item><description>If the validity period is less than 12 months, XX months is displayed. For example, 3 months indicates that the validity period is 3 months.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3 months</para>
                /// </summary>
                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cert-****</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The certificate authority (CA) that issued the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Let\&quot;s Encrypt</para>
                /// </summary>
                [NameInMap("CertOrg")]
                [Validation(Required=false)]
                public string CertOrg { get; set; }

                /// <summary>
                /// <para>The type of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>free</b>: a free certificate (for testing)</description></item>
                /// <item><description><b>cas</b>: a certificate that is purchased from Certificate Management Service</description></item>
                /// <item><description><b>upload</b>: a custom certificate that you uploaded</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cas</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The streaming domain or ingest domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The status of HTTPS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: HTTPS is enabled.</description></item>
                /// <item><description><b>off</b>: HTTPS is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                /// <summary>
                /// <para>The public key of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourSSLPub</para>
                /// </summary>
                [NameInMap("SSLPub")]
                [Validation(Required=false)]
                public string SSLPub { get; set; }

                /// <summary>
                /// <para>The status of the free certificate that is used for testing. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: The certificate is effective.</description></item>
                /// <item><description><b>checking</b>: The system is checking whether the domain name is mapped to the CNAME that is assigned by ApsaraVideo Live.</description></item>
                /// <item><description><b>cname_error</b>: The domain name is not mapped to the CNAME that is assigned by ApsaraVideo Live.</description></item>
                /// <item><description><b>domain_invalid</b>: The domain name contains invalid characters.</description></item>
                /// <item><description><b>unsupport_wildcard</b>: The domain name is a wildcard domain name, which is not supported.</description></item>
                /// <item><description><b>applying</b>: The certificate is in the application progress.</description></item>
                /// <item><description><b>failed</b>: The application for the certificate failed.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The <b>Status</b> parameter is valid only if the certificate is a free certificate for testing. If the certificate is not a free certificate for testing, an empty value is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1E43DC-9E51-4771-82C0-7D5ECEB547A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
