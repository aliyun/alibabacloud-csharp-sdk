// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QuerySharesToUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E1E63-B337-44F8-8C22-6F00DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns a list of works authorized to the user.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySharesToUserListResponseBodyResult> Result { get; set; }
        public class QuerySharesToUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp of the creation time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1530078690000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Remarks on the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of the test report</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Information about the directory where the work is located.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QuerySharesToUserListResponseBodyResultDirectory Directory { get; set; }
            public class QuerySharesToUserListResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The ID of the directory where the resource is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f7f6e22b-83be-47fd-b49d-9ca686a9****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chart Report</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The path ID of the directory where the resource is located.</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The path name of the directory where the resource is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Level -1 Directory /Level -2 Directory</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account to which the modifier belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13855265****@163.com</para>
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <para>The timestamp of the modification time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1530078690000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The UserID of the work owner in Quickbi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74f5527216d14e9892245320ebf2****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the work owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w****@aliyun.com</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>Security policies for collaborative authorization of works. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: private</description></item>
            /// <item><description>12: Authorize specified members</description></item>
            /// <item><description>1 or 11: Authorize all workspace members</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If you use legacy permissions, the return value is 1.</para>
            /// </description></item>
            /// <item><description><para>If you use the new permissions, the return value is 11.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

            /// <summary>
            /// <para>The publishing status of the report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unpublished</description></item>
            /// <item><description>1: published</description></item>
            /// <item><description>2: modified but not published</description></item>
            /// <item><description>3: unpublished</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Third-party embedding status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No embedding is enabled.</description></item>
            /// <item><description>1: Embed is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThirdPartAuthFlag")]
            [Validation(Required=false)]
            public int? ThirdPartAuthFlag { get; set; }

            /// <summary>
            /// <para>The name of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test report</para>
            /// </summary>
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// <para>The type of the work. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: BI portal</description></item>
            /// <item><description>PAGE: Dashboard</description></item>
            /// <item><description>FULLPAGE: full-screen dashboards</description></item>
            /// <item><description>REPORT: workbook</description></item>
            /// <item><description>dashboardOfflineQuery: self-service data retrieval</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATAFORM</para>
            /// </summary>
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            /// <summary>
            /// <para>The ID of the operations report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>97f7f4c1-543a-4069-8e8d-a56cfcd6****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the report belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5f86ad2-ef53-4c51-8720-162ecfdb****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the report belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Return to Professional Edition</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

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
