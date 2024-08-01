// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the [ISO 8601 standard](https://help.aliyun.com/document_detail/25696.html) in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC.
        /// 
        /// This parameter is empty by default. If this parameter is empty, the current time is used.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC. The specified time can be up to 30 days earlier than the specified EndTime value.
        /// 
        /// This parameter is empty by default. If this parameter is empty, the time that is 3 hours earlier than the specified EndTime value is used.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether the instance is I/O optimized. Valid values:
        /// 
        /// *   optimized: The instance is I/O optimized.
        /// *   none: The instance is not I/O optimized.
        /// 
        /// For instances of generation I instance families, the default value is none.
        /// 
        /// For instances of other instance families, the default value is optimized.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The network type of the preemptible instance. Valid values:
        /// 
        /// *   classic: classic network
        /// *   vpc: Virtual Private Cloud (VPC)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The type of the operating system platform. Valid values:
        /// 
        /// - linux
        /// - windows
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// The line from which the query starts.
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The zone ID of the preemptible instance.
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
        /// The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:
        /// 
        /// *   1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
        /// *   0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
        /// 
        /// Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.
        /// 
        /// >  This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit or SpotAsPriceGo.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value of this parameter and the value of EndTime can be up to 30 days apart. Specify the time in the [ISO 8601 standard](https://help.aliyun.com/document_detail/25696.html) in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC.
        /// 
        /// This parameter is left empty by default. If this parameter is empty, the time that is 3 hours earlier than the value of EndTime is used.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The spot price (market price) of the preemptible instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
