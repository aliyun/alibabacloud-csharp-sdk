// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListAssetCountResponseBody : TeaModel {
        [NameInMap("AssetCountList")]
        [Validation(Required=false)]
        public List<ListAssetCountResponseBodyAssetCountList> AssetCountList { get; set; }
        public class ListAssetCountResponseBodyAssetCountList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("AliyunAssetCount")]
            [Validation(Required=false)]
            public long? AliyunAssetCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("CertificateCount")]
            [Validation(Required=false)]
            public int? CertificateCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1767680115423</para>
            /// </summary>
            [NameInMap("CountDate")]
            [Validation(Required=false)]
            public long? CountDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("DomainAssetCount")]
            [Validation(Required=false)]
            public int? DomainAssetCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("MultiCloudAssetCount")]
            [Validation(Required=false)]
            public long? MultiCloudAssetCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public long? Points { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
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
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
