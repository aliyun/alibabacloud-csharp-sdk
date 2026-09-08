// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAgentSummaryReportsSinceMidnightRequest : TeaModel {
        /// <summary>
        /// <para>Filter by a list of agent IDs, with up to 100 IDs.</para>
        /// <remarks>
        /// <para>If the agent ID list is not empty, the system directly queries based on the provided agent ID list. In this case, the pageSize and pageNumber parameters are invalid, and the data is returned directly. For example, if the request parameter is pageNumber = 3, the response parameter will also be pageNumber = 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;agent1@ccc-test&quot;, &quot;agent2@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public string AgentIds { get; set; }

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
        /// <para>Page number, ranging from 1 to 100. Optional. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, ranging from 1 to 100. Optional. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter by skill group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
