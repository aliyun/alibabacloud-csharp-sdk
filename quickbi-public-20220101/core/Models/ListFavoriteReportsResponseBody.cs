// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListFavoriteReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the query result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListFavoriteReportsResponseBodyResult Result { get; set; }
        public class ListFavoriteReportsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of works queried.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListFavoriteReportsResponseBodyResultData> Data { get; set; }
            public class ListFavoriteReportsResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Indicates whether the user has favorited the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Favorite")]
                [Validation(Required=false)]
                public bool? Favorite { get; set; }

                /// <summary>
                /// <para>The timestamp when the work was favorited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640088615000</para>
                /// </summary>
                [NameInMap("FavoriteDate")]
                [Validation(Required=false)]
                public string FavoriteDate { get; set; }

                /// <summary>
                /// <para>Timestamp of the work creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640088615000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Timestamp of the work modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the user has edit permission for the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasEditAuth")]
                [Validation(Required=false)]
                public bool? HasEditAuth { get; set; }

                /// <summary>
                /// <para>Check if the user has the permission to view the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasViewAuth")]
                [Validation(Required=false)]
                public bool? HasViewAuth { get; set; }

                /// <summary>
                /// <para>Name of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud account name of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>UserID of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1365*****238860</para>
                /// </summary>
                [NameInMap("OwnerNum")]
                [Validation(Required=false)]
                public string OwnerNum { get; set; }

                /// <summary>
                /// <para>Publication status of the work. Value range:</para>
                /// <list type="bullet">
                /// <item><description>0: Not published</description></item>
                /// <item><description>1: Published</description></item>
                /// <item><description>2: Saved with modifications, not published</description></item>
                /// <item><description>3: Offline</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public int? PublishStatus { get; set; }

                /// <summary>
                /// <para>Work ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>977c7698-<b><b>-</b></b>-****-44b7304d20fc</para>
                /// </summary>
                [NameInMap("TreeId")]
                [Validation(Required=false)]
                public string TreeId { get; set; }

                /// <summary>
                /// <para>Type of the work. Value range:</para>
                /// <list type="bullet">
                /// <item><description>DATAPRODUCT: Data Portal</description></item>
                /// <item><description>PAGE: Dashboard</description></item>
                /// <item><description>REPORT: Spreadsheet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PAGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>523793cb-<b><b>-</b></b>-****-aa71c65ffa39</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Number of rows per page set when requesting the interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
