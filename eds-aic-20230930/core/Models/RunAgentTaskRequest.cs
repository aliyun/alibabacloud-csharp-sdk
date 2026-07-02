// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Mobile node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The list of Mobile node IDs. A maximum of 100 nodes are supported per request.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum number of execution steps for the task to prevent infinite loops. Valid values: 30 to 1000. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxSteps")]
        [Validation(Required=false)]
        public int? MaxSteps { get; set; }

        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<RunAgentTaskRequestTargets> Targets { get; set; }
        public class RunAgentTaskRequestTargets : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("TaskConfigId")]
        [Validation(Required=false)]
        public string TaskConfigId { get; set; }

        /// <summary>
        /// <para>The task timeout period in seconds. Valid values: 300 to 3600. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The user instruction in natural language. The Agent performs operations based on this instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Download DingTalk from App Store</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
