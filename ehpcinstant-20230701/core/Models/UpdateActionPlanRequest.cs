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
        /// <para>The expected resource scale of the execution plan. If ResourceType is set to VcpuCapacity, this field indicates that the execution plan expects to maintain 10,000 vCPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public float? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the execution plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the execution plan.</para>
        /// </description></item>
        /// <item><description><para>false: Disables the execution plan.</para>
        /// <remarks>
        /// <para>Notice: After the execution plan is disabled, already created Instant jobs are no longer automatically managed by the execution plan.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// <para>The scheduling interval of the execution plan. Unit: minutes. Valid values: 10 to 10080. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

    }

}
