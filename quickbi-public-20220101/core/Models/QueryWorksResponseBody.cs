// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksResponseBody : TeaModel {
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
        /// <para>The details of the data work.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksResponseBodyResult Result { get; set; }
        public class QueryWorksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The third-party embedding status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Embedding is not enabled.</description></item>
            /// <item><description>1: Embedding is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Auth3rdFlag")]
            [Validation(Required=false)]
            public int? Auth3rdFlag { get; set; }

            /// <summary>
            /// <para>The description of the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remark</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The folder to which the data work belongs.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryWorksResponseBodyResultDirectory Directory { get; set; }
            public class QueryWorksResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test folder</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of the folder IDs, separated by forward slashes (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of the folder names, separated by forward slashes (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test folder</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The global parameter array.</para>
            /// </summary>
            [NameInMap("GlobalParamVoList")]
            [Validation(Required=false)]
            public List<QueryWorksResponseBodyResultGlobalParamVoList> GlobalParamVoList { get; set; }
            public class QueryWorksResponseBodyResultGlobalParamVoList : TeaModel {
                /// <summary>
                /// <para>The field type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enum: Enumeration.</description></item>
                /// <item><description>string: Text.</description></item>
                /// <item><description>number: Numeric value.</description></item>
                /// <item><description>datetime: Date and time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The alias of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lastQueryAt</para>
                /// </summary>
                [NameInMap("ParamAlias")]
                [Validation(Required=false)]
                public string ParamAlias { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lastQueryAt</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            /// <summary>
            /// <para>The millisecond-level timestamp when the data work was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The millisecond-level timestamp when the data work was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the user who updated the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <para>The Quick BI user ID of the data work owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9187a612aa474e2a8ac1414d5529****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the data work owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>Indicates whether the data work is public.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicFlag")]
            [Validation(Required=false)]
            public bool? PublicFlag { get; set; }

            /// <summary>
            /// <para>The expiration date for public access to the report, represented as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721366354000</para>
            /// </summary>
            [NameInMap("PublicInvalidTime")]
            [Validation(Required=false)]
            public long? PublicInvalidTime { get; set; }

            /// <summary>
            /// <para>The security policy for collaborative authorization of the data work. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Private.</description></item>
            /// <item><description>12: Authorized to specified members.</description></item>
            /// <item><description>1 or 11: Authorized to all workspace members.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you use the legacy permissions, the value 1 is returned.</description></item>
            /// <item><description>If you use the new permissions, the value 11 is returned.</description></item>
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
            /// <para>The status of the report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unpublished.</description></item>
            /// <item><description>1: Published.</description></item>
            /// <item><description>2: Modified but unpublished.</description></item>
            /// <item><description>3: Offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The name of the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test report</para>
            /// </summary>
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// <para>The type of the data work to query. Leave this parameter empty to query all types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: Data portal.</description></item>
            /// <item><description>PAGE: Dashboard.</description></item>
            /// <item><description>FULLPAGE: Full-screen dashboard.</description></item>
            /// <item><description>REPORT: Workbook.</description></item>
            /// <item><description>dashboardOfflineQuery: Self-service data retrieval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAGE</para>
            /// </summary>
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            /// <summary>
            /// <para>The ID of the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the data work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87c6b145-090c-43e1-9426-8f93be23****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the data work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test workspace</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
