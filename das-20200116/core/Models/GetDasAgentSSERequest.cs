// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasAgentSSERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent to use. This parameter is optional. If you do not specify this parameter, the service uses the default agent. You can provide the ID of an agent that was generated when you enabled the DAS Agent service or that you manually created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-472T0DxtmjIxxxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Specify the instance ID in the Query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The natural language query for the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Are there any issues or abnormalities with my instance rm-xxx?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The session ID, which must be in the UUID format. This parameter is optional. If you do not provide a session ID, the service creates a new session. To continue an existing conversation, use the same session ID in subsequent requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
