// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiskReplicaPairRequest : TeaModel {
        /// <summary>
        /// The bandwidth to use to asynchronously replicate data between the primary disk and secondary disk. Unit: Kbit/s. Valid values:
        /// 
        /// *   10240 : equal to 10 Mbit/s
        /// *   20480 : equal to 20 Mbit/s
        /// *   51200 : equal to 50 Mbit/s
        /// *   102400 : equal to 100 Mbit/s
        /// 
        /// Default value: 10240.
        /// 
        /// When you set the ChargeType parameter to POSTPAY, the Bandwidth parameter is automatically set to 0 and cannot be modified. The value 0 indicates that bandwidth is dynamically allocated based on the volume of data that is asynchronously replicated from the primary disk to the secondary disk.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The billing method of the replication pair. Valid values:
        /// 
        /// *   PREPAY: subscription
        /// *   POSTPAY: pay-as-you-go
        /// 
        /// Default value: POSTPAY.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the replication pair. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the secondary disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationDiskId")]
        [Validation(Required=false)]
        public string DestinationDiskId { get; set; }

        /// <summary>
        /// The region ID of the secondary disk. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions in which async replication is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// The zone ID of the secondary disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// The ID of the primary disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The name of the replication pair. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("PairName")]
        [Validation(Required=false)]
        public string PairName { get; set; }

        /// <summary>
        /// The subscription duration of the replication pair. This parameter is required when the `ChargeType` parameter is set to PREPAY. The unit of the subscription duration is specified by the `PeriodUnit` parameter.
        /// 
        /// *   Valid values when the `PeriodUnit` parameter is set to Week: 1, 2, 3, and 4.
        /// *   Valid values when the `PeriodUnit` parameter is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration of the replication pair. Valid values:
        /// 
        /// *   Week.
        /// *   Month
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The recovery point objective (RPO) of the replication pair. Unit: seconds. Set the value to 900.
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// The ID of the region in which to create the replication pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the replication group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The zone ID of the primary disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceZoneId")]
        [Validation(Required=false)]
        public string SourceZoneId { get; set; }

        /// <summary>
        /// The resource tags. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskReplicaPairRequestTag> Tag { get; set; }
        public class CreateDiskReplicaPairRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with `acs:` or contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
