// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListFavoriteReportsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListFavoriteReportsResponseBodyResult Result { get; set; }
        public class ListFavoriteReportsResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListFavoriteReportsResponseBodyResultData> Data { get; set; }
            public class ListFavoriteReportsResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Favorite")]
                [Validation(Required=false)]
                public bool? Favorite { get; set; }

                [NameInMap("FavoriteDate")]
                [Validation(Required=false)]
                public string FavoriteDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1640088615000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasEditAuth")]
                [Validation(Required=false)]
                public bool? HasEditAuth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasViewAuth")]
                [Validation(Required=false)]
                public bool? HasViewAuth { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1365*****238860</para>
                /// </summary>
                [NameInMap("OwnerNum")]
                [Validation(Required=false)]
                public string OwnerNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public int? PublishStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>977c7698-<b><b>-</b></b>-****-44b7304d20fc</para>
                /// </summary>
                [NameInMap("TreeId")]
                [Validation(Required=false)]
                public string TreeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PAGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>523793cb-<b><b>-</b></b>-****-aa71c65ffa39</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
