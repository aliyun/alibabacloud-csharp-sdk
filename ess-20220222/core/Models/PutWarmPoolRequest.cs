// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class PutWarmPoolRequest : TeaModel {
        /// <summary>
        /// <para>The capacity options for the warm pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CapacityOptions")]
        [Validation(Required=false)]
        public PutWarmPoolRequestCapacityOptions CapacityOptions { get; set; }
        public class PutWarmPoolRequestCapacityOptions : TeaModel {
            /// <summary>
            /// <para>The expected number of instances to be warmed. The system maintains the sum of the current number of instances in the scaling group and the number of instances in the warm pool at this value. Instances that exceed the current number of instances in the scaling group are scaled out into the warm pool in advance. When traffic peaks occur, instances can be quickly added from the warm pool, avoiding the wait time caused by creating instances on demand.</para>
            /// <para>Default value: the maximum number of instances in the scaling group, which is specified by <c>MaxSize</c>.</para>
            /// <remarks>
            /// <para>The value of <c>DesiredGroupPreparedCapacity</c> must be less than or equal to the maximum number of instances in the scaling group, which is specified by <c>MaxSize</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DesiredGroupPreparedCapacity")]
            [Validation(Required=false)]
            public int? DesiredGroupPreparedCapacity { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the warm pool. The system always keeps at least this number of warmed instances in the warm pool to ensure that instances can be quickly added from the warm pool during scale-out.</para>
            /// <para>Default value: 0.</para>
            /// <remarks>
            /// <para>The value of <c>MinCapacity</c> must be less than or equal to the value of <c>DesiredGroupPreparedCapacity</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public int? MinCapacity { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must ensure that it is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance reclaim policy.</para>
        /// </summary>
        [NameInMap("InstanceReusePolicy")]
        [Validation(Required=false)]
        public PutWarmPoolRequestInstanceReusePolicy InstanceReusePolicy { get; set; }
        public class PutWarmPoolRequestInstanceReusePolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether instances are reclaimed to the warm pool when the scaling group scales in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Instances are reclaimed to the warm pool.</description></item>
            /// <item><description>false: Instances are not reclaimed to the warm pool.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReuseOnScaleIn")]
            [Validation(Required=false)]
            public bool? ReuseOnScaleIn { get; set; }

        }

        /// <summary>
        /// <para>The state of instances in the warm pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The instances are in the running state. This state allows faster scale-out, but you are charged for the full cost of the instances.</description></item>
        /// <item><description>Stopped: The instances are in the economical mode. You are charged only for resources such as cloud disks, elastic IP addresses (EIPs), and snapshots of the instances. However, instance startup may fail during scale-out due to insufficient inventory.</description></item>
        /// </list>
        /// <para>Default value: Stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("PoolState")]
        [Validation(Required=false)]
        public string PoolState { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1fo0dbtsbmqa9h****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
