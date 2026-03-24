// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMemoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>Relations</para>
        /// </summary>
        [NameInMap("relations")]
        [Validation(Required=false)]
        public List<GetMemoriesResponseBodyRelations> Relations { get; set; }
        public class GetMemoriesResponseBodyRelations : TeaModel {
            /// <summary>
            /// <para>Destination</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <para>Relation</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("relationship")]
            [Validation(Required=false)]
            public string Relationship { get; set; }

            /// <summary>
            /// <para>Source</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_namespace/RegistryModule-test2153b9f3-0be6-455e-9efd-05fd31f62885/alicloud</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return value</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<GetMemoriesResponseBodyResults> Results { get; set; }
        public class GetMemoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Actor ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_session_001</para>
            /// </summary>
            [NameInMap("actorId")]
            [Validation(Required=false)]
            public string ActorId { get; set; }

            /// <summary>
            /// <para>Agent ID of the application</para>
            /// 
            /// <b>Example:</b>
            /// <para>980565235819266048</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_user_001</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1747623093939</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Memory hash value</para>
            /// 
            /// <b>Example:</b>
            /// <para>73ad89f2d56c2f8615e5dd0cef7b4c41c074277c91fa0e31fc5b41802c0481f2</para>
            /// </summary>
            [NameInMap("hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <para>Memory ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>019ca1e5-7307-7d50-b943-5e628326a8ed</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Memory</para>
            /// 
            /// <b>Example:</b>
            /// <para>My name is Zhang San and I live in Hangzhou.</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>Metadata</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>Message initiator role</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Run ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-965a0b00cb42a43b</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>Similarity score</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.12</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752825865045</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>User ID</para>
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
