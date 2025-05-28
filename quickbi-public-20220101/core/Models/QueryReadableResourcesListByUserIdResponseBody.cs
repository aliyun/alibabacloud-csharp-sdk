// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryReadableResourcesListByUserIdResponseBody : TeaModel {
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
        /// <para>The list of works that the user has permission to view.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryReadableResourcesListByUserIdResponseBodyResult> Result { get; set; }
        public class QueryReadableResourcesListByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The timestamp of the creation time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611023338000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Remarks on the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory structure in which the work is located.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryReadableResourcesListByUserIdResponseBodyResultDirectory Directory { get; set; }
            public class QueryReadableResourcesListByUserIdResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The ID of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e4276ea5-b232-4fb1-8f0f-efcee4a2****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test directory</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of the directory ID, which is separated with \&quot;/\&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e4276ea5-b232-4fb1-8f0f-efcee4a2****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of the directory name, which is separated with \&quot;/\&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test directory</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account to which the modifier belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Li Si</para>
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <para>The timestamp of the modification time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611023338000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The Quick BI UserID of the work owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tom</para>
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
            /// <para>The status of the report. Valid values:</para>
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
            /// <item><description>0: The embed service is not enabled.</description></item>
            /// <item><description>1: Embed is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ThirdPartAuthFlag")]
            [Validation(Required=false)]
            public int? ThirdPartAuthFlag { get; set; }

            /// <summary>
            /// <para>The name of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Company Region Table</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAGE</para>
            /// </summary>
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            /// <summary>
            /// <para>The ID of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03366b16-69ce-43c8-b782-56c2f6ec****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89713491-cb4f-4579-b889-e82c35f1****</para>
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
