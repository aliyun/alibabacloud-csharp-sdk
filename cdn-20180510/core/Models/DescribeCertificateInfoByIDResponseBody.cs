// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCertificateInfoByIDResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the certificate.</para>
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
                /// <para>The time at which the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2098-02-08 08:02:07 +0000 UTC</para>
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1644xx</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_cert</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The type of the certificate.</para>
                /// <list type="bullet">
                /// <item><description>free: a free certificate</description></item>
                /// <item><description>cas: a certificate purchased by using Certificate Management Service</description></item>
                /// <item><description>upload: a user-uploaded certificate</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cas</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The time when the certificate became effective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-21 08:02:07 +0000 UTC</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The domain names that use the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;example.com&quot;]</para>
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// <para>The content of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE-----\nxxx-----END CERTIFICATE-----\n</para>
                /// </summary>
                [NameInMap("HttpsCrt")]
                [Validation(Required=false)]
                public string HttpsCrt { get; set; }

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
