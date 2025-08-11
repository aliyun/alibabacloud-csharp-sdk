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
        /// <para>If <c>ActivityType</c> is set to <c>CapacityChange</c>, only the expected number of instances is changed during the scaling activity specified by ScalingActivityId and no scale-out is triggered.</para>
        /// <para>This parameter is applicable to only scaling groups that have an expected number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CapacityChange</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <para>The elastic planning result returned when the ExecutionMode is set to PlanOnly.</para>
        /// </summary>
        [NameInMap("PlanResult")]
        [Validation(Required=false)]
        public ScaleWithAdjustmentResponseBodyPlanResult PlanResult { get; set; }
        public class ScaleWithAdjustmentResponseBodyPlanResult : TeaModel {
            /// <summary>
            /// <para>The resource allocation information in the elastic planning result.</para>
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
                /// <para>The spot policy of instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instances are created as pay-as-you-go instances.</description></item>
                /// <item><description>SpotWithPriceLimit: The instances are created as spot instances for which you can specify the maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instances are spot instances for which the market price at the time of purchase is automatically used as the bid price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
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
