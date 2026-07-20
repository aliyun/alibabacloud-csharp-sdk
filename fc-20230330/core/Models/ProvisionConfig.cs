// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ProvisionConfig : TeaModel {
        /// <summary>
        /// <para>The target number of provisioned instances at the current time. If a metric-based or scheduled auto scaling policy is in effect, the value of this parameter is the number of provisioned instances as calculated by the policy. Otherwise, the value is the default number of provisioned instances when all auto scaling policies become invalid.</para>
        /// <remarks>
        /// <para> Comparison between this parameter and defaultTarget\
        /// Assume that after the number of provisioned instances is set to 1, a scheduled auto scaling policy is added, and this auto scaling policy increases the number of provisioned instances during a specified time period to 5.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>During the time period when the scheduled policy <b>takes effect</b>, the value of the target parameter is 5, while the value of the defaultTarget parameter is 1.</para>
        /// </description></item>
        /// <item><description><para>When the scheduled policy <b>is ineffective</b>, both the target value and defaultTarget value are 1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateGPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateGPU { get; set; }

        /// <summary>
        /// <para>public</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>public</para>
        /// 
        /// <b>Example:</b>
        /// <para>image not found</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <para>public</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("defaultTarget")]
        [Validation(Required=false)]
        public long? DefaultTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:124:functions/myFunction/prod</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <para>public</para>
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledAction> ScheduledActions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicy> TargetTrackingPolicies { get; set; }

    }

}
