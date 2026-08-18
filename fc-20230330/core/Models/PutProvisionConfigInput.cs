// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutProvisionConfigInput : TeaModel {
        /// <summary>
        /// <para>Specifies whether to always allocate CPU. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// <para>Specifies whether to always allocate GPU. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alwaysAllocateGPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateGPU { get; set; }

        /// <summary>
        /// <para>The default minimum number of provisioned instances. Valid values: 0 to 10000.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no metric-based auto elastic policy or scheduled elastic policy is configured, the current minimum number of instances equals the minimum number of instances you configured.</description></item>
        /// <item><description>If you configured multiple elastic policies for the minimum number of instances, the system calculates the minimum number of instances triggered by each policy and uses the maximum value among the elastic policies that are effective at the current time as the current minimum number of instances.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("defaultTarget")]
        [Validation(Required=false)]
        public long? DefaultTarget { get; set; }

        /// <summary>
        /// <para>The scheduled scaling configuration.</para>
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledAction> ScheduledActions { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is no longer recommended. Use the defaultTarget parameter instead.</notice>
        /// The target number of provisioned resources. Valid values: 0 to 10000.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Target { get; set; }

        /// <summary>
        /// <para>The metric-based scaling policy configuration.</para>
        /// </summary>
        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicy> TargetTrackingPolicies { get; set; }

    }

}
