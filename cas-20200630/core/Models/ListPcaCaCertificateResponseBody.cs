// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListPcaCaCertificateResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListPcaCaCertificateResponseBodyList> List { get; set; }
        public class ListPcaCaCertificateResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1ef78be5-******-b5ef0f0eba3d</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Example Co., Ltd.</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1ef78be5-******-b5ef0f0eba3d</para>
            /// </summary>
            [NameInMap("IssuerIdentifier")]
            [Validation(Required=false)]
            public string IssuerIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cas_deposit-cn-******</para>
            /// </summary>
            [NameInMap("PrivateCaInstanceId")]
            [Validation(Required=false)]
            public string PrivateCaInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrivateCaRegionId")]
            [Validation(Required=false)]
            public string PrivateCaRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>166********</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
