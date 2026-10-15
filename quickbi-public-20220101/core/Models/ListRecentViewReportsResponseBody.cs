// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListRecentViewReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRecentViewReportsResponseBodyResult Result { get; set; }
        public class ListRecentViewReportsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The notice indicating that pagination parameters (such as TotalNum) returned by this API will be deprecated soon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The pagination parameters such as TotalNum returned by this API will be deprecated soon. If you are using them, modify your code promptly</para>
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
                /// <para>Indicates whether the queried user has added the work to favorites.</para>
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
                /// <para>The timestamp when the work was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the queried user has edit permissions on the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasEditAuth")]
                [Validation(Required=false)]
                public bool? HasEditAuth { get; set; }

                /// <summary>
                /// <para>Indicates whether the queried user has view permissions on the work.</para>
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
                /// <para>TestReport</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
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
                /// <para>The publish status of the work. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Unpublished.</description></item>
                /// <item><description>1: Published.</description></item>
                /// <item><description>2: Modified and saved but not published.</description></item>
                /// <item><description>3: Offline.</description></item>
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
                /// <item><description>DATAPRODUCT: data portal</description></item>
                /// <item><description>PAGE: dashboard</description></item>
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
                /// <para>The number of times the work has been accessed.</para>
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
                /// <para>TestWorkspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <list type="bullet">
            /// <item><description>Default value: 10.</description></item>
            /// <item><description>Maximum value: 100.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
