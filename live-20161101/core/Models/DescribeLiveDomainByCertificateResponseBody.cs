// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainByCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the certificate.</para>
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainByCertificateResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeLiveDomainByCertificateResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainByCertificateResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeLiveDomainByCertificateResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the SSL certificate is obsolete. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>yes</b></description></item>
                /// <item><description><b>no</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>yes</para>
                /// </summary>
                [NameInMap("CertCaIsLegacy")]
                [Validation(Required=false)]
                public string CertCaIsLegacy { get; set; }

                /// <summary>
                /// <para>The time at which the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nov 29 00:00:00 2016 GMT</para>
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the SSL certificate is expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>yes</b></description></item>
                /// <item><description><b>no</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>yes</para>
                /// </summary>
                [NameInMap("CertExpired")]
                [Validation(Required=false)]
                public string CertExpired { get; set; }

                /// <summary>
                /// <para>The effective time of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nov 29 23:59:59 2017 GMT</para>
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// <para>The name of the SSL certificate owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>owner</para>
                /// </summary>
                [NameInMap("CertSubjectCommonName")]
                [Validation(Required=false)]
                public string CertSubjectCommonName { get; set; }

                /// <summary>
                /// <para>The type of the certificate. Valid values: <b>RSA</b>, <b>DSA</b>, and <b>ECDSA</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RSA</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The list of domain names. If a value is returned, the value matches the SSL certificate. Multiple domain names are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com,aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// <para>The domain names (DNS fields) that match the SSL certificate. Multiple domain names are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.example.com,aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainNames")]
                [Validation(Required=false)]
                public string DomainNames { get; set; }

                /// <summary>
                /// <para>The certificate authority (CA) that issued the SSL certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C=US, O=Symantec Corporation, OU=Symantec Trust Network, OU=Domain Validated SSL, CN=Symantec Basic DV SSL CA - G1</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASAF2FDS-12SADSA-DDSAE3D-DSADCD4C-CDADS2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
