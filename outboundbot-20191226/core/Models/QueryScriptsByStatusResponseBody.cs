// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryScriptsByStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scenarios.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public QueryScriptsByStatusResponseBodyScripts Scripts { get; set; }
        public class QueryScriptsByStatusResponseBodyScripts : TeaModel {
            /// <summary>
            /// <para>The list of scenarios.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryScriptsByStatusResponseBodyScriptsList> List { get; set; }
            public class QueryScriptsByStatusResponseBodyScriptsList : TeaModel {
                /// <summary>
                /// <para>The version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579055782000</para>
                /// </summary>
                [NameInMap("AppliedVersion")]
                [Validation(Required=false)]
                public string AppliedVersion { get; set; }

                /// <summary>
                /// <para>The debug status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLISHED</para>
                /// </summary>
                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                /// <summary>
                /// <para>The debug version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01bb2df2-a273-42bb-a214-d3c626b13296</para>
                /// </summary>
                [NameInMap("DebugVersion")]
                [Validation(Required=false)]
                public string DebugVersion { get; set; }

                /// <summary>
                /// <para>The industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通用</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Indicates whether the debug version is a draft.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                /// <summary>
                /// <para>Indicates whether the version is a draft.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                /// <summary>
                /// <para>The scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>电销</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The script description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售话术</para>
                /// </summary>
                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fa0e21e9-caab-4629-9121-1e341243d599</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The scenario name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售话术</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The status of the application version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>DRAFTED</b>: The script is a draft.</para>
                /// </description></item>
                /// <item><description><para><b>INITIALIZE_IN_PROGRESS</b>: The script is being initialized.</para>
                /// </description></item>
                /// <item><description><para><b>PUBLISHED</b>: The script is published.</para>
                /// </description></item>
                /// <item><description><para><b>PUBLISH_IN_PROGRESS</b>: The script is being published.</para>
                /// </description></item>
                /// <item><description><para><b>ROLLBACK_IN_PROGRESS</b>: The script is being rolled back.</para>
                /// </description></item>
                /// <item><description><para><b>EXAMINE_IN_PROGRESS</b>: The script is pending approval.</para>
                /// </description></item>
                /// <item><description><para><b>PUBLISHED_AND_EXAMINE_IN_PROGRESS</b>: The script is published and pending approval.</para>
                /// </description></item>
                /// <item><description><para><b>PUBLISH_FAILED</b>: The script failed to be published.</para>
                /// </description></item>
                /// <item><description><para><b>ROLLBACK_FAILED</b>: The script failed to be rolled back.</para>
                /// </description></item>
                /// <item><description><para><b>IMPORT_IN_PROGRESS</b>: The script is being imported.</para>
                /// </description></item>
                /// <item><description><para><b>IMPORT_FAILED</b>: The script failed to be imported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLISHED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the script was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579055782000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
