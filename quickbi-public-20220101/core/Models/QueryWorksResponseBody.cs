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
            /// <para>The remarks of the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Remarks</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory to which the data work belongs.</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryWorksResponseBodyResultDirectory Directory { get; set; }
            public class QueryWorksResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <para>The ID of the directory to which the data work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The directory name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestDirectory</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The hierarchical path of the directory IDs, separated by a forward slash (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>The hierarchical path of the directory names, separated by a forward slash (/).</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestDirectory</para>
                /// </summary>
                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <para>The array of global parameters.</para>
            /// </summary>
            [NameInMap("GlobalParamVoList")]
            [Validation(Required=false)]
            public List<QueryWorksResponseBodyResultGlobalParamVoList> GlobalParamVoList { get; set; }
            public class QueryWorksResponseBodyResultGlobalParamVoList : TeaModel {
                /// <summary>
                /// <para>The field type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enum: enumeration</description></item>
                /// <item><description>string: text</description></item>
                /// <item><description>number: numeric</description></item>
                /// <item><description>datetime: date</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The parameter alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lastQueryAt</para>
                /// </summary>
                [NameInMap("ParamAlias")]
                [Validation(Required=false)]
                public string ParamAlias { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
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
            /// <para>The timestamp when the data work was created, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the data work was last modified, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the user who last modified the data work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John</para>
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <para>The Quick BI UserID of the data work owner.</para>
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
            /// <para>John</para>
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
            /// <para>The expiration date for the public access of the report. This value is a UNIX timestamp in milliseconds.</para>
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
            /// <item><description>If you use the legacy permission model, the return value is 1.</description></item>
            /// <item><description>If you use the new permission model, the return value is 11.</description></item>
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
            /// <para>The report status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Unpublished.</description></item>
            /// <item><description>1: Published.</description></item>
            /// <item><description>2: Modified but not published.</description></item>
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
            /// <para>TestReport</para>
            /// </summary>
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// <para>The type of the data work. Leave this parameter empty to query all types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: data portal</description></item>
            /// <item><description>PAGE: dashboard</description></item>
            /// <item><description>FULLPAGE: full-screen dashboard</description></item>
            /// <item><description>REPORT: workbook</description></item>
            /// <item><description>dashboardOfflineQuery: custom query</description></item>
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
            /// <para>TestWorkspace</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

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
