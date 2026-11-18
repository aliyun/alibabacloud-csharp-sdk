// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateActionPlanRequest : TeaModel {
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
        /// <para>The resource allocation specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard</description></item>
        /// <item><description>Dedicated: dedicated. To use this value, you must be added to the whitelist.</description></item>
        /// <item><description>Economic: economy. To use this value, you must be added to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("AllocationSpec")]
        [Validation(Required=false)]
        public string AllocationSpec { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-vm-rYfypJKwlN9Y</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The desired resource capacity for the execution plan. If ResourceType is set to VCpuCapacity, this parameter specifies the expected number of vCPUs to maintain, such as 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public double? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>The scheduling interval of the execution plan. Unit: minutes. Valid values: 10 to 10080. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// <para>The computing power level. This parameter takes effect only when the resource type is set to Economic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General: general-purpose</description></item>
        /// <item><description>Performance: performance-optimized</description></item>
        /// </list>
        /// <para>Default value: General.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The prolog script. The script must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("PrologScript")]
        [Validation(Required=false)]
        public string PrologScript { get; set; }

        /// <summary>
        /// <para>The list of region-specific resource configurations for the runtime environment of the execution plan.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<CreateActionPlanRequestRegions> Regions { get; set; }
        public class CreateActionPlanRequestRegions : TeaModel {
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
            /// <para>The list of security groups available for the execution plan in the region. You can specify 0 to 5 security groups.</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The list of security group IDs. You can call the <a href="https://api.aliyun.com/document/Ecs/2014-05-26/DescribeSecurityGroups">DescribeSecurityGroups</a> operation to query available security groups.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The list of vSwitches available for the execution plan in the region. You can specify 0 to 5 vSwitches.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The type of the target resource for the execution plan. Valid values:</para>
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
        /// <para>The list of resource configurations for the runtime environment of the execution plan. You can specify 1 to 10 resource configurations.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateActionPlanRequestResources> Resources { get; set; }
        public class CreateActionPlanRequestResources : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores in the runtime environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public double? Cores { get; set; }

            /// <summary>
            /// <para>The memory size of the runtime environment. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public double? Memory { get; set; }

        }

        /// <summary>
        /// <para>The script used to run the job. The script must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

    }

}
