// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. Omit this parameter in the first request. For subsequent requests, use the returned token as is, and keep the workspace, agent, instance, and maxResults unchanged. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The value must be the same as the input parameter used when calling ListSandboxes to obtain the sandboxId. If this parameter is omitted or left empty, the latest running unit of the agent is queried. If this parameter is specified, the service endpoint must belong to the agent and the target type must be AGENT_VERSION. Otherwise, Resource.NotFound is returned. If the service endpoint is not DEFAULT and is not running independently, ServiceEndpointTargetNotReady is returned. If the sandboxId does not belong to the specified running unit, Sandbox.NotFound is returned instead of an empty list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>se-7f3a92c1</para>
        /// </summary>
        [NameInMap("serviceEndpointId")]
        [Validation(Required=false)]
        public string ServiceEndpointId { get; set; }

    }

}
