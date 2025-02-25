// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerOriginStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>List of origin statuses under the load balancer.</para>
        /// </summary>
        [NameInMap("OriginStatus")]
        [Validation(Required=false)]
        public List<ListLoadBalancerOriginStatusResponseBodyOriginStatus> OriginStatus { get; set; }
        public class ListLoadBalancerOriginStatusResponseBodyOriginStatus : TeaModel {
            /// <summary>
            /// <para>ID of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99874066052****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public long? LoadBalancerId { get; set; }

            /// <summary>
            /// <para>ID of the origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99750209487****</para>
            /// </summary>
            [NameInMap("OriginId")]
            [Validation(Required=false)]
            public long? OriginId { get; set; }

            /// <summary>
            /// <para>ID of the source address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99750209487****</para>
            /// </summary>
            [NameInMap("PoolId")]
            [Validation(Required=false)]
            public long? PoolId { get; set; }

            /// <summary>
            /// <para>The origin pool to which the source belongs, under this load balancer. Only \&quot;default_pool\&quot; (default address pool) will be displayed; other types will return an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default_pool</para>
            /// </summary>
            [NameInMap("PoolType")]
            [Validation(Required=false)]
            public string PoolType { get; set; }

            /// <summary>
            /// <para>Reason for the probe failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP connection error</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Status of the origin:</para>
            /// <list type="bullet">
            /// <item><description>Healthy(healthy): The probe result is available.</description></item>
            /// <item><description>Unhealthy(unhealthy): The probe result is unavailable.</description></item>
            /// <item><description>Unknown(unknown): Unknown, the monitor has not yet probed.</description></item>
            /// <item><description>Undetected(undetected): The load balancer to which the origin belongs is not bound to a monitor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Request ID, used for tracking the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
