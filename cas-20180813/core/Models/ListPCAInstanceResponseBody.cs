// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20180813.Models
{
    public class ListPCAInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PCAInstanceList")]
        [Validation(Required=false)]
        public List<ListPCAInstanceResponseBodyPCAInstanceList> PCAInstanceList { get; set; }
        public class ListPCAInstanceResponseBodyPCAInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qingqitest</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1efb82eb-19e5-620f-bdaa-11cc6cb2a720</para>
            /// </summary>
            [NameInMap("CaIdentifier")]
            [Validation(Required=false)]
            public string CaIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CertCount")]
            [Validation(Required=false)]
            public long? CertCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-09T10:05:18</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1ef3fefc-8065-60de-871e-d15cf842aab6</para>
            /// </summary>
            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IssuedCertCount")]
            [Validation(Required=false)]
            public long? IssuedCertCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RelateStatus")]
            [Validation(Required=false)]
            public bool? RelateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShareFlag")]
            [Validation(Required=false)]
            public int? ShareFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Trial")]
            [Validation(Required=false)]
            public string Trial { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EECA10D5-BD0F-4EF1-B3EA-B4578E5C6F8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
