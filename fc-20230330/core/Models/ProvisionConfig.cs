// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ProvisionConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to always allocate CPU to function instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// <para>Specifies whether to always allocate GPU to function instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateGPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateGPU { get; set; }

        /// <summary>
        /// <para>The actual number of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>The error message when provisioned instance creation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image not found</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <para>The default number of resources when all metric-based scaling policies and scheduled scaling policies are inactive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("defaultTarget")]
        [Validation(Required=false)]
        public long? DefaultTarget { get; set; }

        /// <summary>
        /// <para>The resource descriptor of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:124:functions/myFunction/prod</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <para>The scheduled scaling policy configurations.</para>
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledAction> ScheduledActions { get; set; }

        /// <summary>
        /// <para>The current target number of resources. If a metric-based scaling policy or scheduled scaling policy exists, this value is the number of resources calculated by the policy. Otherwise, it is the default number of provisioned instances.</para>
        /// <remarks>
        /// <para>What is the difference between target and defaultTarget?\
        /// Assume that the number of provisioned instances is configured as 1, and then a scheduled scaling policy is added to set the number of provisioned instances to 5 during a specific time period.</para>
        /// <list type="bullet">
        /// <item><description>During the <b>active period</b> of the scheduled scaling policy, target and defaultTarget are 5 and 1, respectively.</description></item>
        /// <item><description>During the <b>inactive period</b> of the scheduled scaling policy, both target and defaultTarget are 1.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        /// <summary>
        /// <para>The metric-based scaling policy configurations.</para>
        /// </summary>
        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicy> TargetTrackingPolicies { get; set; }

    }

}
