// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupRequest : TeaModel {
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("FlashSmsExtras")]
        [Validation(Required=false)]
        public string FlashSmsExtras { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;emptyNumberIgnore\&quot;:true,\&quot;inArrearsIgnore\&quot;:true,\&quot;outOfServiceIgnore\&quot;:true}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;maxAttemptsPerDay\&quot;:1,\&quot;name\&quot;:\&quot;fa16dc2e-f778-44ab-8f25-54b7901df82a\&quot;,\&quot;startTime\&quot;:1640157314127,\&quot;endTime\&quot;:1640160914127,\&quot;minAttemptInterval\&quot;:10}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
