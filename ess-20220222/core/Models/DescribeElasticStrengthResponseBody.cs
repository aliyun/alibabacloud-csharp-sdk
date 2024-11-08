// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeElasticStrengthResponseBody : TeaModel {
        /// <summary>
        /// <para>The scaling strength models.</para>
        /// </summary>
        [NameInMap("ElasticStrengthModels")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyElasticStrengthModels> ElasticStrengthModels { get; set; }
        public class DescribeElasticStrengthResponseBodyElasticStrengthModels : TeaModel {
            /// <summary>
            /// <para>The resource pools.</para>
            /// </summary>
            [NameInMap("ResourcePools")]
            [Validation(Required=false)]
            public List<DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools> ResourcePools { get; set; }
            public class DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools : TeaModel {
                /// <summary>
                /// <para>The error code returned when the scaling strength is the weakest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceTypesOrDiskTypesNotSupported</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

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
                /// <para>The error message returned when the scaling strength is the weakest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The instanceTypes or diskTypes are not supported.</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The scaling strength of the resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public double? Strength { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches in the zones of the resource pool.</para>
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
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-wz98mnj7nblv9gc****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The scaling strength of the scaling group. Each combination of instance type + zone is scored from 0 to 1 based on its availability, with 0 being the weakest scaling strength and 1 being the strongest. The scaling strength of the scaling group is measured by the combined scores of all the combinations of instance type + zone.</para>
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
        /// <para>The resource pools.</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyResourcePools> ResourcePools { get; set; }
        public class DescribeElasticStrengthResponseBodyResourcePools : TeaModel {
            /// <summary>
            /// <para>The error code returned when the scaling strength is the weakest.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMG_NOT_SUPPORTED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

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
            /// <para>The error message returned when the scaling strength is the weakest.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instanceType does not support the image in the configuration.</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The scaling strength of the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Strength")]
            [Validation(Required=false)]
            public double? Strength { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches in the zones of the resource pool.</para>
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
        /// <para>The scaling strength of the scaling group. Each combination of instance type + zone is scored from 0 to 1 based on its availability, with 0 being the weakest scaling strength and 1 being the strongest. The scaling strength of the scaling group is measured by the combined scores of all the combinations of instance type + zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("TotalStrength")]
        [Validation(Required=false)]
        public double? TotalStrength { get; set; }

    }

}
