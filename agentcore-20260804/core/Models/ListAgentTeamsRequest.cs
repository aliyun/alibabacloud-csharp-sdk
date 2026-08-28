// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentTeamsRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters for querying the agent team list.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ListAgentTeamsRequestBody Body { get; set; }
        public class ListAgentTeamsRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of agent IDs for which to query team information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("agentIds")]
            [Validation(Required=false)]
            public List<string> AgentIds { get; set; }

        }

    }

}
