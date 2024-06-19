// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// The information about the resource that you want to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public DescribeAvailableResourceRequestDestinationResource DestinationResource { get; set; }
        public class DescribeAvailableResourceRequestDestinationResource : TeaModel {
            /// <summary>
            /// The type of the resource. Valid values:
            /// 
            /// *   InstanceTypeFamily: queries instance families. If you use this parameter value, you must also specify the Value parameter.
            /// *   InstanceType: queries instance types. If you use this parameter value, you must also specify the Value, Cores, and Memory parameters.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The number of vCPUs. This parameter is available only when the Category parameter is set to InstanceType.
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public float? Cores { get; set; }

            /// <summary>
            /// The size of the memory. Unit: GiB. This parameter is available only when the Category parameter is set to InstanceType.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// Instance families or instance types.
            /// 
            /// *   If you set Category to InstanceTypeFamily, you must set this parameter to instance families such as ecs.c5.
            /// *   If you set Category to InstanceType, you must set this parameter to instance types such as ecs.c5.large.
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
        /// The region ID of the ECS instance families.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/146965.html) operation to query the most recent list of regions.
        /// 
        /// This parameter is required.
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
        /// The information about the preemptible instances that you want to query.
        /// </summary>
        [NameInMap("SpotResource")]
        [Validation(Required=false)]
        public DescribeAvailableResourceRequestSpotResource SpotResource { get; set; }
        public class DescribeAvailableResourceRequestSpotResource : TeaModel {
            /// <summary>
            /// The protection period of the preemptible instance. Unit: hours. Default value: 1. The value of 0 indicates no protection period.
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places. If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public double? SpotPriceLimit { get; set; }

            /// <summary>
            /// The bidding policy for the elastic container instance. Valid values:
            /// 
            /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
            /// 
            /// Default value: NoSpot.
            /// 
            /// > If you set this parameter to SpotWithPriceLimit or SpotAsPriceGo to query preemptible instances, you must set Category to InstanceType. You must also use the Value parameter to specify instance types, or use the Cores and Memory parameters to specify the number of vCPUs and memory size.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

        }

        /// <summary>
        /// The zone ID of the ECS instance families.
        /// 
        /// This parameter is empty by default, which indicates that ECS instance families available in all zones in the specified region are queried.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
