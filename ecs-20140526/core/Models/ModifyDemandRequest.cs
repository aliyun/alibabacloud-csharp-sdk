// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDemandRequest : TeaModel {
        /// <summary>
        /// The number of instances. Valid values: 1 to 100000.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the demand. The description must be 2 to 256 characters in length. It cannot start with http:// or https://.
        /// </summary>
        [NameInMap("DemandDescription")]
        [Validation(Required=false)]
        public string DemandDescription { get; set; }

        /// <summary>
        /// The ID of the demand that you want to modify.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DemandId")]
        [Validation(Required=false)]
        public string DemandId { get; set; }

        /// <summary>
        /// The name of the demand. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with [http:// or https://](http://https://). It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// The default value is the instance type name.
        /// </summary>
        [NameInMap("DemandName")]
        [Validation(Required=false)]
        public string DemandName { get; set; }

        /// <summary>
        /// The end time of the subscription period. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html)standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.
        /// 
        /// If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the minute (mm).
        /// 
        /// The value of EndTime must be later than the value of StartTime.
        /// 
        /// in most cases, the interval between StartTime and EndTime cannot be more than 10 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid (default): pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance type. For more information, see [Instance families](https://help.aliyun.com/document_detail/25378.html). You can also call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation to query the performance data of the specified instance type. To learn how to select instance types, see [Select instance types](https://help.aliyun.com/document_detail/58291.html).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription period of the resource. Unit: month. You must specify this parameter. This parameter is valid only if you set `InstanceChargeType` to PrePaid. Valid values:
        /// 
        /// *   Valid values when PeriodUnit is set to Week: 1, 2, 3, and 4.
        /// *   Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription period of the resource. Valid values:
        /// 
        /// *   Day
        /// *   Week
        /// *   Month. This is the default value.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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
        /// The start time of the subscription period. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.
        /// 
        /// If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the minute (mm).
        /// 
        /// The value of EndTime must be later than the value of StartTime.
        /// 
        /// In most cases, the interval between StartTime and EndTime cannot be more than 10 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeZones](https://help.aliyun.com/document_detail/25610.html) operation to query the most recent zone list.
        /// 
        /// This parameter is empty by default. If you leave this parameter empty, the system randomly selects a zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
