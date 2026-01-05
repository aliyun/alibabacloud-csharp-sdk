// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ModifyCapacityReservationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-iv9gj3spak6fbj****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("MinimumLoadBalancerCapacity")]
        [Validation(Required=false)]
        public ModifyCapacityReservationRequestMinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }
        public class ModifyCapacityReservationRequestMinimumLoadBalancerCapacity : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public int? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResetCapacityReservation")]
        [Validation(Required=false)]
        public bool? ResetCapacityReservation { get; set; }

    }

}
