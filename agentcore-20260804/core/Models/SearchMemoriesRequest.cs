// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class SearchMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The semantic retrieval request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SearchMemoriesRequestBody Body { get; set; }
        public class SearchMemoriesRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable reranking. Default value: true.</para>
            /// </summary>
            [NameInMap("enableRerank")]
            [Validation(Required=false)]
            public bool? EnableRerank { get; set; }

            /// <summary>
            /// <para>The string key-value metadata for exact matching. A maximum of 16 keys are supported. Each key can be up to 64 characters in length, and each value can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The minimum relevance score. Default value: 0.2. Valid values: 0 to 1. If both minScore and minSimilarity are specified, the results are filtered based on the AND logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("minScore")]
            [Validation(Required=false)]
            public float? MinScore { get; set; }

            /// <summary>
            /// <para>The minimum similarity score. Default value: 0.3. Valid values: 0 to 1. If both minSimilarity and minScore are specified, the results are filtered based on the AND logic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("minSimilarity")]
            [Validation(Required=false)]
            public float? MinSimilarity { get; set; }

            /// <summary>
            /// <para>The query text for retrieval, up to 8,192 characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>What sports does the user like?</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The retrieval scope. UserId, AgentId, and SessionId are all optional.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public SearchMemoriesRequestBodyScope Scope { get; set; }
            public class SearchMemoriesRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>The agent ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with an agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The session ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The business team ID defined by the caller. If provided, it cannot be empty and can be up to 128 UTF-8 bytes in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team-001</para>
                /// </summary>
                [NameInMap("teamId")]
                [Validation(Required=false)]
                public string TeamId { get; set; }

                /// <summary>
                /// <para>The user ID. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*). This field is not returned if the memory is not associated with a user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of results to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("topK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            /// <summary>
            /// <para>The list of memory content types. Supported types include semantic, skill, user_profile, and session_summary. If omitted or left as an empty array, no type restriction is applied.</para>
            /// </summary>
            [NameInMap("types")]
            [Validation(Required=false)]
            public List<string> Types { get; set; }

        }

    }

}
