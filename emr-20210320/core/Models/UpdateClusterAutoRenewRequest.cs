// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateClusterAutoRenewRequest : TeaModel {
        /// <summary>
        /// <para>The list of ECS instances for which to enable auto-renewal. This parameter takes effect only when RenewAllInstances is not set to true.</para>
        /// </summary>
        [NameInMap("AutoRenewInstances")]
        [Validation(Required=false)]
        public List<AutoRenewInstance> AutoRenewInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>false: Disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ClusterAutoRenew")]
        [Validation(Required=false)]
        public bool? ClusterAutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration for the cluster. This parameter takes effect only when ClusterAutoRenew is set to true.
        /// If ClusterAutoRenewDurationUnit is set to Month, the valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, and 36. If ClusterAutoRenewDurationUnit is set to Year, the valid values are 1, 2, and 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterAutoRenewDuration")]
        [Validation(Required=false)]
        public int? ClusterAutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("ClusterAutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string ClusterAutoRenewDurationUnit { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-d6661c71139a****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for all ECS instances in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables auto-renewal for all ECS instances in the cluster. The default auto-renewal duration is one month.</para>
        /// </description></item>
        /// <item><description><para>false: Does not enable auto-renewal for all ECS instances in the cluster. You can specify the ECS instances for which to enable auto-renewal in the AutoRenewInstances parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("RenewAllInstances")]
        [Validation(Required=false)]
        public bool? RenewAllInstances { get; set; }

    }

}
