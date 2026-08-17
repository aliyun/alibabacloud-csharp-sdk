// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetActionPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-hz036ubmx2qmw93k****</para>
        /// </summary>
        [NameInMap("ActionPlanId")]
        [Validation(Required=false)]
        public string ActionPlanId { get; set; }

        /// <summary>
        /// <para>Name of the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestActionPlan</para>
        /// </summary>
        [NameInMap("ActionPlanName")]
        [Validation(Required=false)]
        public string ActionPlanName { get; set; }

        /// <summary>
        /// <para>Resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("AllocationSpec")]
        [Validation(Required=false)]
        public string AllocationSpec { get; set; }

        /// <summary>
        /// <para>ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-vm-rYfypJKwlN9Y</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Time when the execution plan was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Target resource size for the execution plan. If ResourceType is VCpuCapacity, this value represents the target vCPU count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public float? DesiredCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// <para>Computing power level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>Prologue script. Must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("PrologScript")]
        [Validation(Required=false)]
        public string PrologScript { get; set; }

        /// <summary>
        /// <para>List of region-specific resource configurations for the execution plan\&quot;s runtime environment.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyRegions> Regions { get; set; }
        public class GetActionPlanResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>List of security groups available to the execution plan in this region.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>List of vSwitches available to the execution plan in this region.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Type of target resource for the execution plan. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>VCpuCapacity: vCPU capacity</para>
        /// </description></item>
        /// <item><description><para>ExecutorCapacity: number of executor nodes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VCpuCapacity</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>List of resource configurations for the execution plan\&quot;s runtime environment.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyResources> Resources { get; set; }
        public class GetActionPlanResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>Number of CPUs in the runtime environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public float? Cores { get; set; }

            /// <summary>
            /// <para>Memory size in the runtime environment, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        /// <summary>
        /// <para>Status of the execution plan. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>Active: The execution plan is active and dynamically manages Instant jobs.</para>
        /// </description></item>
        /// <item><description><para>Inactive: The execution plan is inactive and no longer manages Instant jobs.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The execution plan is being deleted. You cannot modify parameters during this state.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Current resource size managed by the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCapacity")]
        [Validation(Required=false)]
        public float? TotalCapacity { get; set; }

        /// <summary>
        /// <para>Last time the execution plan was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
