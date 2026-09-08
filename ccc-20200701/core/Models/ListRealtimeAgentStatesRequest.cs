// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeAgentStatesRequest : TeaModel {
        /// <summary>
        /// <para>List of agent IDs, formatted as a JSON array string. The array can contain up to 20 elements. This parameter is optional and defaults to empty, which matches all agents under the current instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;agent1@ccc-test&quot;, &quot;agent2@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public string AgentIdList { get; set; }

        /// <summary>
        /// <para>Perform fuzzy matching by agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>Filters by a list of call types. The value is a string in JSON array format, where each array element is a call type. This parameter is optional and defaults to empty, which matches all call types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Inbound&quot;, &quot;Outbound&quot;]</para>
        /// </summary>
        [NameInMap("CallTypeList")]
        [Validation(Required=false)]
        public string CallTypeList { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Media type. The default is Audio. Other options include Chat (text), Video, and ALL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUDIO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>Filters agents who are in outbound-only mode. This parameter is optional and defaults to empty, which means no filtering by outbound-only mode is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutboundScenario")]
        [Validation(Required=false)]
        public bool? OutboundScenario { get; set; }

        /// <summary>
        /// <para>Page number, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Performs fuzzy filtering based on the full or partial agent display name, agent ID, or agent extension number. This parameter is optional and defaults to empty, which means no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Filter by skill group ID. This parameter is optional and defaults to empty, which means no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <para>Filters by a list of statuses. This parameter is optional and defaults to empty, which matches all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ACW&quot;, &quot;Dialing&quot;]</para>
        /// </summary>
        [NameInMap("StateList")]
        [Validation(Required=false)]
        public string StateList { get; set; }

        /// <summary>
        /// <para>Filter by work mode list. This parameter is optional and defaults to empty, which means all work modes are matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;OFFICE_PHONE&quot;,&quot;ON_SITE&quot;]</para>
        /// </summary>
        [NameInMap("WorkModeList")]
        [Validation(Required=false)]
        public string WorkModeList { get; set; }

    }

}
