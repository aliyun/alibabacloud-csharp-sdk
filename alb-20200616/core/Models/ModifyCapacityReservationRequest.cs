// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ModifyCapacityReservationRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a token from your client and make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the system uses the RequestId as the ClientToken. The RequestId of each API request is different.</para>
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
        /// <item><description><para><b>true</b>: Sends a check request but does not reserve any resources. The system checks the request for required parameters, format, and service limits. If the check fails, an error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. After the request passes the check, an HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-iv9gj3spak6fbj****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The minimum LCU value to reserve.</para>
        /// </summary>
        [NameInMap("MinimumLoadBalancerCapacity")]
        [Validation(Required=false)]
        public ModifyCapacityReservationRequestMinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }
        public class ModifyCapacityReservationRequestMinimumLoadBalancerCapacity : TeaModel {
            /// <summary>
            /// <para>The number of LCUs to reserve per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public int? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to cancel the LCU reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Cancels the LCU reservation.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not cancel the LCU reservation. You do not need to specify this parameter when creating or updating an LCU reservation.</para>
        /// </description></item>
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
