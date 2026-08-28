// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListServiceEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by target agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-123456</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Filters by target agent version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("agentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Filters by collaboration component type. Valid values: MATRIX_CLIENT, MATRIX_FEDERATION, ELEMENT_WEB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ELEMENT_WEB</para>
        /// </summary>
        [NameInMap("collaborationComponent")]
        [Validation(Required=false)]
        public string CollaborationComponent { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Valid values: 1 to 100. If this parameter is not specified, 20 records are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. Do not specify this parameter for the first request. For subsequent requests, specify the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6YWdlbnRjb3JlLnNlcnZpY2UtZW5kcG9pbnQubGlzdDoyMA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters by the workspace resource binding ID of the target collaboration component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wrb-123456</para>
        /// </summary>
        [NameInMap("resourceBindingId")]
        [Validation(Required=false)]
        public string ResourceBindingId { get; set; }

        /// <summary>
        /// <para>Filters by service endpoint status. Valid values: CREATING, READY, UPDATING, DEGRADED, DISABLED, DELETING.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters by target type. Valid values: AGENT_VERSION, TEAM_COLLABORATION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT_VERSION</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
