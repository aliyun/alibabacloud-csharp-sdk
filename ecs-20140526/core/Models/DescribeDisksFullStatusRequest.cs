// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusRequest : TeaModel {
        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusRequestEventTime EventTime { get; set; }
        public class DescribeDisksFullStatusRequestEventTime : TeaModel {
            /// <summary>
            /// The end of the time range to query occurred events.
            /// 
            /// Specify the time in the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// The beginning of the time range to query occurred events.
            /// 
            /// Specify the time in the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// The ID of EBS device N. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// The ID of event N. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// The event type of the EBS device. Valid values:
        /// 
        /// *   Degraded: The performance of the EBS device is degraded.
        /// *   SeverelyDegraded: The performance of the EBS device is severely degraded.
        /// *   Stalled: The performance of the EBS device is severely affected.
        /// *   ErrorDetected: The local disk is damaged.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The health status of the EBS device. Valid values:
        /// 
        /// *   Impaired: The EBS device is damaged.
        /// *   Warning: The performance of the EBS device is degraded.
        /// *   Initializing: The EBS device is being initialized.
        /// *   InsufficientData: The status cannot be determined due to insufficient data.
        /// *   NotApplicable: The EBS device cannot be used.
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. The value must be a positive integer.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the EBS device. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the EBS device belongs. If you configure this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The lifecycle status of the EBS device. For more information, see [Disk status](~~25689~~). Valid values:
        /// 
        /// *   In_use: The EBS device is in use.
        /// *   Available: The EBS device can be attached.
        /// *   Attaching: The EBS device is being attached.
        /// *   Detaching: The EBS device is being detached.
        /// *   Creating: The EBS device is being created.
        /// *   ReIniting: The EBS device is being initialized.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags to add to the EBS device.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksFullStatusRequestTag> Tag { get; set; }
        public class DescribeDisksFullStatusRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the EBS device. A key-value pair consists of a key specified by the Tag.N.Key parameter and a value specified by the `Tag.N.Value` parameter. The two parameters are associated with each other. Valid values of N: 1 to 20.
            /// 
            /// Up to 1,000 resources with the specified tags can be returned in the response.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the EBS device. A key-value pair consists of a key specified by the `Tag.N.Key` parameter and a value specified by the Tag.N.Value parameter. The two parameters are associated with each other. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
