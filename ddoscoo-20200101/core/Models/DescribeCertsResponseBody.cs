// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate information.</para>
        /// </summary>
        [NameInMap("Certs")]
        [Validation(Required=false)]
        public List<DescribeCertsResponseBodyCerts> Certs { get; set; }
        public class DescribeCertsResponseBodyCerts : TeaModel {
            /// <summary>
            /// <para>The global certificate ID. The value is a string that consists of the certificate ID and the region ID, separated by a hyphen (-). For example, if the certificate ID is \<c>123\\</c> and the region is \<c>cn-hangzhou\\</c>, the value of \<c>CertIdentifier\\</c> is \<c>123-cn-hangzhou\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>126345-ap-southeast-1</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The domain name that is associated with the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Common")]
            [Validation(Required=false)]
            public string Common { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is associated with the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The certificate is associated with the domain name.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The certificate is not associated with the domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DomainRelated")]
            [Validation(Required=false)]
            public bool? DomainRelated { get; set; }

            /// <summary>
            /// <para>The expiration date of the certificate. The value is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-12</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The certification authority (CA) that issued the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Symantec</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testcert</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The issuance date of the certificate. The value is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-12</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
