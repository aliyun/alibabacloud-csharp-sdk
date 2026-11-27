// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ModifyCapacityReservationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a dry run request without reserving resources. The system checks required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request. After the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the Application Load Balancing instance. Before you configure a capacity reservation, the instance must have at least one listener in the Running state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-iv9gj3spak6fbj****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The minimum reserved load balancing capacity.</para>
        /// </summary>
        [NameInMap("MinimumLoadBalancerCapacity")]
        [Validation(Required=false)]
        public ModifyCapacityReservationRequestMinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }
        public class ModifyCapacityReservationRequestMinimumLoadBalancerCapacity : TeaModel {
            /// <summary>
            /// <para>The number of LCUs reserved per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public int? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to cancel the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Cancels the capacity reservation.</description></item>
        /// <item><description><b>false</b> (default): Does not cancel the capacity reservation. You do not need to specify this parameter when you create or modify a capacity reservation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResetCapacityReservation")]
        [Validation(Required=false)]
        public bool? ResetCapacityReservation { get; set; }

    }

}
