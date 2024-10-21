// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeElasticStrengthResponseBody : TeaModel {
        [NameInMap("ElasticStrengthModels")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyElasticStrengthModels> ElasticStrengthModels { get; set; }
        public class DescribeElasticStrengthResponseBodyElasticStrengthModels : TeaModel {
            [NameInMap("ResourcePools")]
            [Validation(Required=false)]
            public List<DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools> ResourcePools { get; set; }
            public class DescribeElasticStrengthResponseBodyElasticStrengthModelsResourcePools : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>InstanceTypesOrDiskTypesNotSupported</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.r7.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The instanceTypes or diskTypes are not supported.</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public double? Strength { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("TotalStrength")]
            [Validation(Required=false)]
            public double? TotalStrength { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public List<DescribeElasticStrengthResponseBodyResourcePools> ResourcePools { get; set; }
        public class DescribeElasticStrengthResponseBodyResourcePools : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>IMG_NOT_SUPPORTED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.c7t.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The instanceType does not support the image in the configuration.</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Strength")]
            [Validation(Required=false)]
            public double? Strength { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("TotalStrength")]
        [Validation(Required=false)]
        public double? TotalStrength { get; set; }

    }

}
