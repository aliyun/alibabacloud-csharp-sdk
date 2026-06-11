// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SearchMemoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of relationships.</para>
        /// </summary>
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<SearchMemoriesResponseBodyRelations> Relations { get; set; }
        public class SearchMemoriesResponseBodyRelations : TeaModel {
            /// <summary>
            /// <para>The destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>The relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("relationship")]
            [Validation(Required=false)]
            public string Relationship { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_open_dingoj06pvqfeayy3lkr</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of search results.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<SearchMemoriesResponseBodyResults> Results { get; set; }
        public class SearchMemoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The actor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("actorId")]
            [Validation(Required=false)]
            public string ActorId { get; set; }

            /// <summary>
            /// <para>The agent ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>972772996913709056</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1762773128968</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The memory hash value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d791bf27236c5532056a13279baad3517042bb8d5b1bdb02e7871fa632debffe</para>
            /// </summary>
            [NameInMap("hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <para>The memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>019ca1e5-7307-7d50-b943-5e628326a8ed</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The memory content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My name is Zhang San and I live in Hangzhou.</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;<b>strategy_type</b>&quot;:&quot;Fact&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The sender\&quot;s role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The similarity score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13.21</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1764902557784</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
