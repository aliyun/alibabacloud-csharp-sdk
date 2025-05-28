// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListRecentViewReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query results are returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRecentViewReportsResponseBodyResult Result { get; set; }
        public class ListRecentViewReportsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Attention</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Attention")]
            [Validation(Required=false)]
            public string Attention { get; set; }

            /// <summary>
            /// <para>The list of queried works.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListRecentViewReportsResponseBodyResultData> Data { get; set; }
            public class ListRecentViewReportsResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Queries whether the user has collected the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Favorite")]
                [Validation(Required=false)]
                public bool? Favorite { get; set; }

                /// <summary>
                /// <para>The timestamp when the work was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1496651577000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The timestamp when the work was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The query user has the editing rights of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasEditAuth")]
                [Validation(Required=false)]
                public bool? HasEditAuth { get; set; }

                /// <summary>
                /// <para>The query user has the permission to view the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasViewAuth")]
                [Validation(Required=false)]
                public bool? HasViewAuth { get; set; }

                /// <summary>
                /// <para>The timestamp when the work was last accessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1642067498000</para>
                /// </summary>
                [NameInMap("LatestViewTime")]
                [Validation(Required=false)]
                public string LatestViewTime { get; set; }

                /// <summary>
                /// <para>The name of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test report</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The UserID of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1365*****238860</para>
                /// </summary>
                [NameInMap("OwnerNum")]
                [Validation(Required=false)]
                public string OwnerNum { get; set; }

                /// <summary>
                /// <para>The publication status of the work. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: unpublished</description></item>
                /// <item><description>1: published</description></item>
                /// <item><description>2: modified and saved but not published.</description></item>
                /// <item><description>3: unpublished</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public int? PublishStatus { get; set; }

                /// <summary>
                /// <para>The ID of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>977c7698-<b><b>-</b></b>-****-44b7304d20fc</para>
                /// </summary>
                [NameInMap("TreeId")]
                [Validation(Required=false)]
                public string TreeId { get; set; }

                /// <summary>
                /// <para>The type of the work. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATAPRODUCT: BI portal</description></item>
                /// <item><description>PAGE: Dashboard</description></item>
                /// <item><description>REPORT: workbook</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PAGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The number of times the work was accessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public long? ViewCount { get; set; }

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
                /// <para>Test Workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 10.</description></item>
            /// <item><description>Maximum of 100 articles</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
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
