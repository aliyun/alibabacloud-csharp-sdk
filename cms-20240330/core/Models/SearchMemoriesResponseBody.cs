// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SearchMemoriesResponseBody : TeaModel {
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<SearchMemoriesResponseBodyRelations> Relations { get; set; }
        public class SearchMemoriesResponseBodyRelations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("relationship")]
            [Validation(Required=false)]
            public string Relationship { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>todo_open_dingoj06pvqfeayy3lkr</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("results")]
        [Validation(Required=false)]
        public List<SearchMemoriesResponseBodyResults> Results { get; set; }
        public class SearchMemoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("actorId")]
            [Validation(Required=false)]
            public string ActorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>972772996913709056</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1762773128968</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d791bf27236c5532056a13279baad3517042bb8d5b1bdb02e7871fa632debffe</para>
            /// </summary>
            [NameInMap("hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>019ca1e5-7307-7d50-b943-5e628326a8ed</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>My name is Zhang San and I live in Hangzhou.</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13.21</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1764902557784</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
