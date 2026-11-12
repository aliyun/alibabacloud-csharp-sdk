// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ImportAgentJobsRequest : TeaModel {
        /// <summary>
        /// <para>agentname</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027179f-20b1-4e0b-841b-d86f2bc7ebf7</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The strategy for synchronizing scheduled tasks. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>1: Migrates both the content and the scheduling time of local scheduled tasks from the agent to the cloud.  </description></item>
        /// <item><description>2: Migrates only the scheduling time to the cloud. When the scheduled time arrives, the platform notifies the agent, and the agent executes the task based on the local task content. The task content is always retained locally.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MigrateStrategy")]
        [Validation(Required=false)]
        public int? MigrateStrategy { get; set; }

    }

}
