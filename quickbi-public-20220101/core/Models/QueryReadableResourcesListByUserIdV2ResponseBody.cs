// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryReadableResourcesListByUserIdV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C********05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the query result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryReadableResourcesListByUserIdV2ResponseBodyResult> Result { get; set; }
        public class QueryReadableResourcesListByUserIdV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Timestamp of creation in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611023338000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Work remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdas</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory structure where the work is located.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryReadableResourcesListByUserIdV2ResponseBodyResultDirectory Directory { get; set; }
            public class QueryReadableResourcesListByUserIdV2ResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The ID of the directory to which it belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3eecab7-618d-4f9f-*****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the directory to which it belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdas</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of directory IDs, separated by『/』.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88b680****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of directory names, separated by『/』.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdas/safas</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>Alibaba Cloud account name of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdas</para>
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <para>Timestamp of the last modification in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1530078690000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The UserID of the work owner in Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud account name of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdas</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>Security policy for collaborative work. Values: - 0: Private - 12: Authorize specific members - 1 or 11: Authorize all space members</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you are using the old version of permissions, the return value is 1. - If you are using the new version of permissions, the return value is 11.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

            /// <summary>
            /// <para>Report status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unpublished</description></item>
            /// <item><description>1: Published</description></item>
            /// <item><description>2: Modified but not published</description></item>
            /// <item><description>3: Offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Third-party embedding status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>0: Embedding not enabled</description></item>
            /// <item><description>1: Embedding enabled</description></item>
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
            /// <para>asdas</para>
            /// </summary>
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// <para>Work type. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: Data Portal</description></item>
            /// <item><description>PAGE: Dashboard</description></item>
            /// <item><description>REPORT: Spreadsheet</description></item>
            /// <item><description>dashboardOfflineQuery: Self-service Data Extraction</description></item>
            /// <item><description>SCREEN: Data Wall</description></item>
            /// <item><description>DATAFORM: Data Entry</description></item>
            /// <item><description>ANALYSIS: Ad-hoc Analysis</description></item>
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
            /// <para>ccd3428c-<b><b>-</b></b>-a608-26bae29dffee</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>ID of the workspace to which the work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5f86ad2-ef53-4c51-8720-162ecfdb****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdas</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
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
