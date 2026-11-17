// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DeleteEventsRequest : TeaModel {
        /// <summary>
        /// <para>The JSON request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DeleteEventsRequestBody Body { get; set; }
        public class DeleteEventsRequestBody : TeaModel {
            /// <summary>
            /// <para>A list of 1 to 100 unique event IDs. Only events owned by the current session are deleted.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("eventIds")]
            [Validation(Required=false)]
            public List<string> EventIds { get; set; }

            /// <summary>
            /// <para>The scope for precise session targeting.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public DeleteEventsRequestBodyScope Scope { get; set; }
            public class DeleteEventsRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>The business agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The ID of the precisely targeted session.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The business team ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team-001</para>
                /// </summary>
                [NameInMap("teamId")]
                [Validation(Required=false)]
                public string TeamId { get; set; }

                /// <summary>
                /// <para>The business user ID. This is not the platform tenant identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
