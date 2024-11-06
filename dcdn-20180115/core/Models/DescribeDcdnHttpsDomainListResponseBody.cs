// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnHttpsDomainListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the certificate.</para>
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnHttpsDomainListResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnHttpsDomainListResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// <para>The returned primary domain name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                /// <summary>
                /// <para>The time at which the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-26 14:45:09</para>
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The time at which the certificate became effective.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-26 14:45:09</para>
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// <para>The status of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ok</b>: The certificate is working as expected.</description></item>
                /// <item><description><b>mismatch</b>: The certificate does not match the specified domain name.</description></item>
                /// <item><description><b>expired</b>: The certificate has expired.</description></item>
                /// <item><description><b>expire_soon</b>: The certificate is about to expire.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mismatch</para>
                /// </summary>
                [NameInMap("CertStatus")]
                [Validation(Required=false)]
                public string CertStatus { get; set; }

                /// <summary>
                /// <para>The type of the certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cas</b>: a certificate that is purchased by using Certificate Management Service</description></item>
                /// <item><description><b>upload</b>: a custom certificate that you upload</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>upload</para>
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The time at which the certificate was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-08 18:33:16</para>
                /// </summary>
                [NameInMap("CertUpdateTime")]
                [Validation(Required=false)]
                public string CertUpdateTime { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>*.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5E8DF64-7175-4186-9B06-F002C0BBD0C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
