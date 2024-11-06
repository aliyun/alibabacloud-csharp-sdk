// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the certificate.</para>
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// <para>The domain name that matches the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                /// <summary>
                /// <para>The time at which the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-06-03T22:03:39Z</para>
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9002448</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The validity period of the certificate. Unit: <b>months</b> or <b>years</b>.</para>
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
                /// <para>cert-example.com</para>
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
                /// <para>The region where the certificate is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertRegion")]
                [Validation(Required=false)]
                public string CertRegion { get; set; }

                /// <summary>
                /// <para>The type of the certificate.</para>
                /// <list type="bullet">
                /// <item><description><b>cas</b>: a certificate that is purchased by using Certificates Management Service</description></item>
                /// <item><description><b>upload</b>: a custom certificate that you upload</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cas</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
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
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
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
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("SSLPub")]
                [Validation(Required=false)]
                public string SSLPub { get; set; }

                /// <summary>
                /// <para>The status of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: The certificate has taken effect.</description></item>
                /// <item><description><b>checking</b>: The system is checking whether the domain name is using Dynamic Route for CDN (DCDN).</description></item>
                /// <item><description><b>cname_error</b>: The domain name is not using DCDN.</description></item>
                /// <item><description><b>domain_invalid</b>: The domain name contains invalid characters.</description></item>
                /// <item><description><b>unsupport_wildcard</b>: The wildcard domain name is not supported.</description></item>
                /// <item><description><b>applying</b>: Certificate application is in progress.</description></item>
                /// <item><description><b>get_token_timeout</b>: The certificate application request has timed out.</description></item>
                /// <item><description><b>check_token_timeout</b>: The verification has timed out.</description></item>
                /// <item><description><b>get_cert_timeout</b>: The request to obtain the certificate has timed out.</description></item>
                /// <item><description><b>failed</b>: The certificate application request failed.</description></item>
                /// </list>
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
