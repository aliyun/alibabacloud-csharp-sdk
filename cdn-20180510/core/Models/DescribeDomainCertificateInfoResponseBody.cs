// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the certificate.</para>
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
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
                /// <para>The unit of the validity period of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>months</b></description></item>
                /// <item><description><b>years</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>months</para>
                /// </summary>
                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The name of the certificate authority (CA) that issued the certificate.</para>
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
                /// <para>The time when the certificate became effective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-06-03T22:03:39Z</para>
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// <para>The type of the certificate.</para>
                /// <list type="bullet">
                /// <item><description><b>free</b>: a free certificate</description></item>
                /// <item><description><b>cas</b>: a certificate that is purchased by using Certificate Management Service</description></item>
                /// <item><description><b>upload</b>: a custom certificate that you upload</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>free</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The time at which the certificate was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-06-03T22:03:39Z</para>
                /// </summary>
                [NameInMap("CertUpdateTime")]
                [Validation(Required=false)]
                public string CertUpdateTime { get; set; }

                /// <summary>
                /// <para>The CNAME status of the domain name.</para>
                /// <list type="bullet">
                /// <item><description><b>ok</b>: The domain name points to the CNAME assigned by Alibaba Cloud CDN.</description></item>
                /// <item><description><b>cname_error</b>: An error occurred and the domain name cannot point to the CNAME.</description></item>
                /// <item><description><b>op_domain_cname_error</b> : An error occurred to the CNAME of the top-level domain. The domain name cannot point to the CNAME.</description></item>
                /// <item><description><b>unsupport_wildcard</b>: The wildcard domain name is not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("DomainCnameStatus")]
                [Validation(Required=false)]
                public string DomainCnameStatus { get; set; }

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
                /// <para>The public key of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdadaxxxx</para>
                /// </summary>
                [NameInMap("ServerCertificate")]
                [Validation(Required=false)]
                public string ServerCertificate { get; set; }

                /// <summary>
                /// <para>The status of HTTPS.</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("ServerCertificateStatus")]
                [Validation(Required=false)]
                public string ServerCertificateStatus { get; set; }

                /// <summary>
                /// <para>The status of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b>: The certificate has taken effect.</description></item>
                /// <item><description><b>checking</b>: The system is checking whether the domain name is using Alibaba Cloud CDN.</description></item>
                /// <item><description><b>cname_error</b>: No valid CNAME record has been added for the domain name.</description></item>
                /// <item><description><b>top_domain_cname_error</b>: No valid CNAME record has been added for the top-level domain.</description></item>
                /// <item><description><b>domain_invalid</b>: The domain name contains invalid characters.</description></item>
                /// <item><description><b>unsupport_wildcard</b>: The domain name is a wildcard domain name. Wildcard domain names are not supported.</description></item>
                /// <item><description><b>applying</b>: The certificate application is in progress.</description></item>
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
