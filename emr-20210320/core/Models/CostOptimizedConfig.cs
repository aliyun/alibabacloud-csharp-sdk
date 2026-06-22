// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CostOptimizedConfig : TeaModel {
        /// <summary>
        /// <para>The minimum number of pay-as-you-go instances that are required for the node group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, pay-as-you-go instances are preferentially created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The percentage of pay-as-you-go instances among the instances that exceed the number specified by the OnDemandBaseCapacity parameter for the node group. Valid values: 0 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("OnDemandPercentageAboveBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandPercentageAboveBaseCapacity { get; set; }

        /// <summary>
        /// <para>The number of instance types that are specified. Preemptible instances of multiple instance types that are provided at the lowest price are evenly created in the scaling group. Valid values: 0 to 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

    }

}
