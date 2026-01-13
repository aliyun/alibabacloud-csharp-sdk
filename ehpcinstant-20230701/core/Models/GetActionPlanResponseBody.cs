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
        /// <para>The type of the resource.</para>
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
        /// <para>The time when the execution plan was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The expected scale of resources for the execution plan. If the ResourceType parameter is set to VcpuCapacity, the execution plan is expected to have 10000 vCPUs.</para>
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
        /// <para>The computing power level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The pre-processing script. Base64 encoding is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("PrologScript")]
        [Validation(Required=false)]
        public string PrologScript { get; set; }

        /// <summary>
        /// <para>The list of resource configurations in the region where the execution plan runs.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyRegions> Regions { get; set; }
        public class GetActionPlanResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region ID of the instance.</para>
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
            /// <para>The list of VSwitches available for the execution plan in the region.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Target resource type: the capacity of vCPUs or the number of execution nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VCpuCapacity</description></item>
        /// <item><description>ExecutorCapacity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VCpuCapacity</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of resource configurations of the execution plan runtime environment.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<GetActionPlanResponseBodyResources> Resources { get; set; }
        public class GetActionPlanResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The number of CPUs in the running environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public float? Cores { get; set; }

            /// <summary>
            /// <para>The memory size of the running environment. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        /// <summary>
        /// <para>The status of the execution plan. The possible values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Active Instant tasks are dynamically managed only when the execution plan is in the Active state.</description></item>
        /// <item><description>Inactive Instant tasks are no longer managed by execution plans in the Inactive state.</description></item>
        /// <item><description>Deleting You cannot modify the parameters of an execution plan in this state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The size of the resources currently managed by the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCapacity")]
        [Validation(Required=false)]
        public float? TotalCapacity { get; set; }

        /// <summary>
        /// <para>The time when the execution plan was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-10 18:28:05</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
