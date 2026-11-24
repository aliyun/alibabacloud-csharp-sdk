// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the scaling activity. If <c>ActivityType</c> is <c>CapacityChange</c>, the scaling activity corresponding to the returned <c>ScalingActivityId</c> only modifies the expected number of instances in the scaling group and does not immediately execute scale-out or scale-in. Applicable scope: scaling groups with the expected number of instances configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CapacityChange</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <para>The elastic planning results returned when ExecutionMode is set to PlanOnly.</para>
        /// </summary>
        [NameInMap("PlanResult")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentResponseBodyPlanResult PlanResult { get; set; }
        public class ScaleWithAdjustmentResponseBodyPlanResult : TeaModel {
            /// <summary>
            /// <para>The resource allocation information in the elastic planning results.</para>
            /// </summary>
            [NameInMap("ResourceAllocations")]
            [Validation(Required=false)]
            public List<ScaleWithAdjustmentResponseBodyPlanResultResourceAllocations> ResourceAllocations { get; set; }
            public class ScaleWithAdjustmentResponseBodyPlanResultResourceAllocations : TeaModel {
                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Prepaid</b>: subscription.</description></item>
                /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.u1-c1m8.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The preemption policy for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: regular pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: spot instance with a maximum price limit.</description></item>
                /// <item><description>SpotAsPriceGo: spot instance whose price is automatically set by the system based on the current market price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asa-bp175o6f6ego3r2j****</para>
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
