// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetActionPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-hz036ubmx2qmw93k****</para>
        /// </summary>
        [NameInMap("ActionPlanId")]
        [Validation(Required=false)]
        public string ActionPlanId { get; set; }

        /// <summary>
        /// <para>The name of the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestActionPlan</para>
        /// </summary>
        [NameInMap("ActionPlanName")]
        [Validation(Required=false)]
        public string ActionPlanName { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("AllocationSpec")]
        [Validation(Required=false)]
        public string AllocationSpec { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-vm-rYfypJKwlN9Y</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The time when the execution plan was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The desired resource capacity of the execution plan. If ResourceType is set to VcpuCapacity, this field indicates that the execution plan expects to maintain 10,000 vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public float? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>The scheduling interval of the execution plan. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// <para>The computing power level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The preprocessing script. The script must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("PrologScript")]
        [Validation(Required=false)]
        public string PrologScript { get; set; }

        /// <summary>
        /// <para>The list of regional resource configurations for the runtime environment of the execution plan.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyRegions> Regions { get; set; }
        public class GetActionPlanResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of security groups available for the execution plan in the region.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The list of vSwitches available for the execution plan in the region.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the target resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>VCpuCapacity: vCPU capacity</para>
        /// </description></item>
        /// <item><description><para>ExecutorCapacity: number of execution nodes</para>
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
        /// <para>The list of resource configurations for the runtime environment of the execution plan.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyResources> Resources { get; set; }
        public class GetActionPlanResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The number of CPUs in the runtime environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public float? Cores { get; set; }

            /// <summary>
            /// <para>The memory size of the runtime environment. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        /// <summary>
        /// <para>The status of the execution plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Active: The execution plan is active. Only active execution plans dynamically manage instant tasks.</para>
        /// </description></item>
        /// <item><description><para>Inactive: The execution plan is inactive. Inactive execution plans no longer manage instant tasks.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The execution plan is being deleted. You cannot modify the parameters of an execution plan in this state.</para>
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
        /// <para>The current resource capacity managed by the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCapacity")]
        [Validation(Required=false)]
        public float? TotalCapacity { get; set; }

        /// <summary>
        /// <para>The time when the execution plan was last modified. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
