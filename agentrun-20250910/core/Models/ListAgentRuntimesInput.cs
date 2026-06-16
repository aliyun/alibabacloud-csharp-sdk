// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimesInput : TeaModel {
        /// <summary>
        /// <para>Filters the results by agent runtime name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// <para>The page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the results by status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY,CREATING</para>
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>按系统标签过滤</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ecs:tag1,acs:ecs:tag2</para>
        /// </summary>
        [NameInMap("systemTags")]
        [Validation(Required=false)]
        public List<string> SystemTags { get; set; }

    }

}
