// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class UpdateActionPlanRequest : TeaModel {
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
        /// <para>The expected scale of resources for the execution plan. If the ResourceType parameter is set to VcpuCapacity, the execution plan is expected to have 10000 vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public float? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>Whether to enable the execution plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the execution plan.</para>
        /// </description></item>
        /// <item><description><para>false: The execution plan is disabled.</para>
        /// <para>**</para>
        /// <para><b>Note:</b> After an execution plan is disabled, the created Instant jobs are not automatically managed by the execution plan.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

    }

}
