// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeElasticStrengthResponseBody : TeaModel {
        /// <summary>
        /// <para>The elastic strength of the current scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Strong: high elastic strength.</para>
        /// </description></item>
        /// <item><description><para>Medium: medium elastic strength.</para>
        /// </description></item>
        /// <item><description><para>Weak: weak elastic strength.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Strong</para>
        /// </summary>
        [NameInMap("ElasticStrength")]
        [Validation(Required=false)]
        public string ElasticStrength { get; set; }

        /// <summary>
        /// <para>An array of elastic strength details, returned when the API call targets multiple scaling groups.</para>
        /// </summary>
        [NameInMap("ElasticStrengthModels")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyElasticStrengthModels> ElasticStrengthModels { get; set; }
        public class DescribeElasticStrengthResponseBodyElasticStrengthModels : TeaModel {
            /// <summary>
            /// <para>The elastic strength of the current scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Strong: high elastic strength.</para>
            /// </description></item>
            /// <item><description><para>Medium: medium elastic strength.</para>
            /// </description></item>
            /// <item><description><para>Weak: weak elastic strength.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Strong</para>
            /// </summary>
            [NameInMap("ElasticStrength")]
            [Validation(Required=false)]
            public string ElasticStrength { get; set; }

            /// <summary>
            /// <para>Details of the resource pools within the scaling group.</para>
            /// </summary>
            [NameInMap("ResourcePools")]
            [Validation(Required=false)]
            public List<DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools> ResourcePools { get; set; }
            public class DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools : TeaModel {
                /// <summary>
                /// <para>The error code returned when the elastic strength is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceTypesOrDiskTypesNotSupported</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The elastic strength of the resource pool, which is based on its inventory health and current stock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Strong: high elastic strength.</para>
                /// </description></item>
                /// <item><description><para>Medium: medium elastic strength.</para>
                /// </description></item>
                /// <item><description><para>Weak: weak elastic strength.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Strong</para>
                /// </summary>
                [NameInMap("ElasticStrength")]
                [Validation(Required=false)]
                public string ElasticStrength { get; set; }

                /// <summary>
                /// <para>The instance type of the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.r7.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The inventory health.</para>
                /// </summary>
                [NameInMap("InventoryHealth")]
                [Validation(Required=false)]
                public DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePoolsInventoryHealth InventoryHealth { get; set; }
                public class DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePoolsInventoryHealth : TeaModel {
                    /// <summary>
                    /// <para>The adequacy score.</para>
                    /// <para>Valid values: 0 to 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AdequacyScore")]
                    [Validation(Required=false)]
                    public int? AdequacyScore { get; set; }

                    /// <summary>
                    /// <para>The health score.</para>
                    /// <list type="bullet">
                    /// <item><description><para>A score from 5 to 6 indicates high confidence in supply.</para>
                    /// </description></item>
                    /// <item><description><para>A score from 1 to 4 indicates that supply is not guaranteed. Consider making on-demand reservations.</para>
                    /// </description></item>
                    /// <item><description><para>A score from -3 to 0 indicates a supply health alert. Consider using a different instance type.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>The health score is calculated using the formula: <c>HealthScore</c> = <c>AdequacyScore</c> + <c>SupplyScore</c> - <c>HotScore</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("HealthScore")]
                    [Validation(Required=false)]
                    public int? HealthScore { get; set; }

                    /// <summary>
                    /// <para>The hot score.</para>
                    /// <para>Valid values: 0 to 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("HotScore")]
                    [Validation(Required=false)]
                    public int? HotScore { get; set; }

                    /// <summary>
                    /// <para>The supply score.</para>
                    /// <para>Valid values: 0 to 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SupplyScore")]
                    [Validation(Required=false)]
                    public int? SupplyScore { get; set; }

                }

                /// <summary>
                /// <para>The error message returned when the elastic strength is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The instanceTypes or diskTypes are not supported.</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The availability of the resource pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Available: The resource pool is available.</para>
                /// </description></item>
                /// <item><description><para>Unavailable: The resource pool is unavailable. This can occur if the instance type is not deployed in the zone, has insufficient inventory, or does not meet other constraints.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The elastic strength of the resource pool.&gt;Warning:  This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public double? Strength { get; set; }

                /// <summary>
                /// <para>The VSwitches in the zone of the resource pool.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The zone ID of the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The scaling group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-wz98mnj7nblv9gc****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The total elastic strength of the scaling group. The strength is the sum of scores from all configured instance type and zone combinations. Each combination is scored from 0 (low strength) to 1 (high strength) based on resource availability.&gt;Warning:  This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("TotalStrength")]
            [Validation(Required=false)]
            public double? TotalStrength { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of resource pools. This parameter is returned when the API call targets a single scaling group.</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyResourcePools> ResourcePools { get; set; }
        public class DescribeElasticStrengthResponseBodyResourcePools : TeaModel {
            /// <summary>
            /// <para>The error code returned when the elastic strength is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMG_NOT_SUPPORTED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The elastic strength of the resource pool, which is based on its inventory health and current stock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Strong: high elastic strength.</para>
            /// </description></item>
            /// <item><description><para>Medium: medium elastic strength.</para>
            /// </description></item>
            /// <item><description><para>Weak: weak elastic strength.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Medium</para>
            /// </summary>
            [NameInMap("ElasticStrength")]
            [Validation(Required=false)]
            public string ElasticStrength { get; set; }

            /// <summary>
            /// <para>The instance type of the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c7t.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The inventory health.</para>
            /// </summary>
            [NameInMap("InventoryHealth")]
            [Validation(Required=false)]
            public DescribeElasticStrengthResponseBodyResourcePoolsInventoryHealth InventoryHealth { get; set; }
            public class DescribeElasticStrengthResponseBodyResourcePoolsInventoryHealth : TeaModel {
                /// <summary>
                /// <para>The adequacy score.</para>
                /// <para>Valid values: 0 to 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AdequacyScore")]
                [Validation(Required=false)]
                public int? AdequacyScore { get; set; }

                /// <summary>
                /// <para>The health score.</para>
                /// <list type="bullet">
                /// <item><description><para>A score from 5 to 6 indicates high confidence in supply.</para>
                /// </description></item>
                /// <item><description><para>A score from 1 to 4 indicates that supply is not guaranteed. Consider making on-demand reservations.</para>
                /// </description></item>
                /// <item><description><para>A score from -3 to 0 indicates a supply health alert. Consider using a different instance type.</para>
                /// </description></item>
                /// </list>
                /// <para>The health score is calculated using the formula: <c>HealthScore</c> = <c>AdequacyScore</c> + <c>SupplyScore</c> - <c>HotScore</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HealthScore")]
                [Validation(Required=false)]
                public int? HealthScore { get; set; }

                /// <summary>
                /// <para>The hot score.</para>
                /// <para>Valid values: 0 to 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HotScore")]
                [Validation(Required=false)]
                public int? HotScore { get; set; }

                /// <summary>
                /// <para>The supply score.</para>
                /// <para>Valid values: 0 to 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SupplyScore")]
                [Validation(Required=false)]
                public int? SupplyScore { get; set; }

            }

            /// <summary>
            /// <para>The error message returned when the elastic strength is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instanceType does not support the image in the configuration.</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The availability of the resource pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Available: The resource pool is available.</para>
            /// </description></item>
            /// <item><description><para>Unavailable: The resource pool is unavailable. This can occur if the instance type is not deployed in the zone, has insufficient inventory, or does not meet other constraints.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The elastic strength of the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Strength")]
            [Validation(Required=false)]
            public double? Strength { get; set; }

            /// <summary>
            /// <para>The VSwitches in the zone of the resource pool.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The zone ID of the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The total elastic strength of the scaling group. The strength is the sum of scores from all configured instance type and zone combinations. Each combination is scored from 0 (low strength) to 1 (high strength) based on resource availability.&gt;Warning:  This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("TotalStrength")]
        [Validation(Required=false)]
        public double? TotalStrength { get; set; }

    }

}
