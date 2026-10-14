// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class SearchContextRequest : TeaModel {
        /// <summary>
        /// <para>The structured filter conditions. The key is the field name, and the value is the expected matching value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;alice&quot;}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>Specifies whether to structurally format the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("formatted")]
        [Validation(Required=false)]
        public bool? Formatted { get; set; }

        /// <summary>
        /// <para>Specifies whether to include memories with sourceState=inactive. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeInactive")]
        [Validation(Required=false)]
        public bool? IncludeInactive { get; set; }

        /// <summary>
        /// <para>The maximum number of returned results, which corresponds to the Top-N similarity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The retrieval query text. Natural language is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recent user preferences</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The retrieval options used to control the retrieval strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>semantic</para>
        /// </summary>
        [NameInMap("retrievalOption")]
        [Validation(Required=false)]
        public string RetrievalOption { get; set; }

        /// <summary>
        /// <para>The recall scope. If a field with the same name conflicts with the filter, a 400 ScopeFilterConflict error is returned.</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public SearchContextRequestScope Scope { get; set; }
        public class SearchContextRequestScope : TeaModel {
            /// <summary>
            /// <para>Agent Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>sales-copilot</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm-service</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run-001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-10001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The similarity threshold. Results with a similarity score lower than this value are filtered out. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
