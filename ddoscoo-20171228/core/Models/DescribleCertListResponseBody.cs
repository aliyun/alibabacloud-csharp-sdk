// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribleCertListResponseBody : TeaModel {
        [NameInMap("CertList")]
        [Validation(Required=false)]
        public List<DescribleCertListResponseBodyCertList> CertList { get; set; }
        public class DescribleCertListResponseBodyCertList : TeaModel {
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Common")]
            [Validation(Required=false)]
            public string Common { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DomainRelated")]
            [Validation(Required=false)]
            public bool? DomainRelated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-09-23</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DigiCert Inc</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-09-24</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
