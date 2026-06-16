// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the scaling activity.</para>
        /// <para>If this parameter is set to <c>CapacityChange</c>, the scaling activity only adjusts the desired capacity of the scaling group without immediately adding or removing instances.</para>
        /// <para>This setting only affects scaling groups with a configured desired capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CapacityChange</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <para>The scaling plan result returned when ExecutionMode is set to PlanOnly.</para>
        /// </summary>
        [NameInMap("PlanResult")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentResponseBodyPlanResult PlanResult { get; set; }
        public class ScaleWithAdjustmentResponseBodyPlanResult : TeaModel {
            /// <summary>
            /// <para>The resource allocation details in the scaling plan result.</para>
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
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Prepaid</b>: subscription</para>
                /// </description></item>
                /// <item><description><para><b>PostPaid</b>: pay-as-you-go</para>
                /// </description></item>
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
                /// <para>The spot strategy of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NoSpot: A pay-as-you-go instance.</para>
                /// </description></item>
                /// <item><description><para>SpotWithPriceLimit: A spot instance with a user-specified price limit.</para>
                /// </description></item>
                /// <item><description><para>SpotAsPriceGo: A spot instance where the system automatically bids based on the current market price.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The availability zone ID.</para>
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
        /// <para>The request ID.</para>
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
