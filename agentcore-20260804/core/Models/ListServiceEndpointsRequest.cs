// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListServiceEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target agent used to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-123456</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The version number of the target agent used to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("agentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The collaboration component type used to filter the results. Valid values: MATRIX_CLIENT, MATRIX_FEDERATION, and ELEMENT_WEB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ELEMENT_WEB</para>
        /// </summary>
        [NameInMap("collaborationComponent")]
        [Validation(Required=false)]
        public string CollaborationComponent { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on a single page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The cursor used to query the next page. Do not specify this parameter in the first call. In subsequent calls, specify the nextToken value returned in the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6YWdlbnRjb3JlLnNlcnZpY2UtZW5kcG9pbnQubGlzdDoyMA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The workspace resource binding ID of the target collaboration component used to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wrb-123456</para>
        /// </summary>
        [NameInMap("resourceBindingId")]
        [Validation(Required=false)]
        public string ResourceBindingId { get; set; }

        /// <summary>
        /// <para>The service endpoint status used to filter the results. Valid values: CREATING, READY, UPDATING, DEGRADED, DISABLED, and DELETING.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The target type used to filter the results. Valid values: AGENT_VERSION and TEAM_COLLABORATION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT_VERSION</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
