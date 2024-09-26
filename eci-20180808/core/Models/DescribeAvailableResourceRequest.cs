// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The information about the resource that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public DescribeAvailableResourceRequestDestinationResource DestinationResource { get; set; }
        public class DescribeAvailableResourceRequestDestinationResource : TeaModel {
            /// <summary>
            /// <para>The type of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InstanceTypeFamily: queries instance families. If you use this parameter value, you must also specify the Value parameter.</description></item>
            /// <item><description>InstanceType: queries instance types. If you use this parameter value, you must also specify the Value, Cores, and Memory parameters.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceTypeFamily</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The number of vCPUs. This parameter is available only when the Category parameter is set to InstanceType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public float? Cores { get; set; }

            /// <summary>
            /// <para>The size of the memory. Unit: GiB. This parameter is available only when the Category parameter is set to InstanceType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>Instance families or instance types.</para>
            /// <list type="bullet">
            /// <item><description>If you set Category to InstanceTypeFamily, you must set this parameter to instance families such as ecs.c5.</description></item>
            /// <item><description>If you set Category to InstanceType, you must set this parameter to instance types such as ecs.c5.large.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the ECS instance families.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/146965.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The information about the preemptible instances that you want to query.</para>
        /// </summary>
        [NameInMap("SpotResource")]
        [Validation(Required=false)]
        public DescribeAvailableResourceRequestSpotResource SpotResource { get; set; }
        public class DescribeAvailableResourceRequestSpotResource : TeaModel {
            /// <summary>
            /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. The value of 0 indicates no protection period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places. If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public double? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The bidding policy for the elastic container instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instance is created as a regular pay-as-you-go instance.</description></item>
            /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
            /// </list>
            /// <para>Default value: NoSpot.</para>
            /// <remarks>
            /// <para>If you set this parameter to SpotWithPriceLimit or SpotAsPriceGo to query preemptible instances, you must set Category to InstanceType. You must also use the Value parameter to specify instance types, or use the Cores and Memory parameters to specify the number of vCPUs and memory size.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SpotAsPriceGo</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the ECS instance families.</para>
        /// <para>This parameter is empty by default, which indicates that ECS instance families available in all zones in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
