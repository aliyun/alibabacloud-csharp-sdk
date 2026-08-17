// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateActionPlanShrinkRequest : TeaModel {
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
        /// <list type="bullet">
        /// <item><description><para>Standard: Standard.</para>
        /// </description></item>
        /// <item><description><para>Dedicated: Dedicated. This type is available only to users in the whitelist.</para>
        /// </description></item>
        /// <item><description><para>Economic: Economy. This type is available only to users in the whitelist.</para>
        /// </description></item>
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
        /// <para>The desired size of the resource for the execution plan. For example, if you set ResourceType to VcpuCapacity, this parameter specifies the number of vCPUs that you want to maintain for the execution plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public double? DesiredCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// <para>The computing power level. This parameter is valid only when you set AllocationSpec to Economic. The following types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>General: General-purpose.</para>
        /// </description></item>
        /// <item><description><para>Performance: Compute-optimized.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: General</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The pre-execution script. The script must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("PrologScript")]
        [Validation(Required=false)]
        public string PrologScript { get; set; }

        /// <summary>
        /// <para>A list of regional resource configurations for the runtime environment of the execution plan.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string RegionsShrink { get; set; }

        /// <summary>
        /// <para>The type of resource for the execution target. The value can be the vCPU capacity or the number of executor nodes. Valid values:</para>
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
        /// <para>A list of resource configurations for the runtime environment of the execution plan. You can specify 1 to 10 resource configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string ResourcesShrink { get; set; }

        /// <summary>
        /// <para>The script to run the job. The script must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bHMgLWFsCmxzIC1hbGggfCB3YyAtbA==</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

    }

}
