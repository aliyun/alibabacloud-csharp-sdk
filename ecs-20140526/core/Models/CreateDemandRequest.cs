// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDemandRequest : TeaModel {
        /// <summary>
        /// The number of instances. Valid values: 1 to 100000.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The `ClientToken` value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the demand. The description must be 2 to 256 characters in length and cannot start with [http:// or https://](http://https://。).
        /// </summary>
        [NameInMap("DemandDescription")]
        [Validation(Required=false)]
        public string DemandDescription { get; set; }

        /// <summary>
        /// The name of the demand. The name must be 2 to 128 characters in length and start with a letter but cannot start with [http:// or https://](http://https://). It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// 
        /// The default value is the instance type.
        /// </summary>
        [NameInMap("DemandName")]
        [Validation(Required=false)]
        public string DemandName { get; set; }

        /// <summary>
        /// The end time of the subscription period. Specify the time in the [ISO 8601](~~25696~~) standard and use the UTC time. The format is yyyy-MM-dd hh:mm:ss.
        /// 
        /// If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the specified minute (mm). The value of EndTime must be later than the value of Starttime. In most cases, the interval between the two times cannot be more than 10 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The billing method of the instance. Default value: PostPaid. Valid values:
        /// 
        /// *   PrePaid: subscription.
        /// *   PostPaid: pay-as-you-go.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance type. See [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the performance data of an instance type, or see [Select instance types](~~58291~~) to learn how to select instance types.
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
        /// The subscription period of the resource. Valid values:
        /// 
        /// *   When the value of PeriodUnit is Day, the valid values of Period are 1, 2, 3, 4, 5, and 6.
        /// *   When the value of PeriodUnit is Week, the valid values of Period are 1, 2, 3, and 4.
        /// *   When the value of PeriodUnit is Month, the valid values of Period are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription period. Default value: Month. Valid values:
        /// 
        /// *   Day
        /// *   Week
        /// *   Month
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
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
        /// The start time of the subscription period. Specify the time in the [ISO 8601](~~25696~~) standard and use the UTC time. The default format is yyyy-MM-dd HH:mm:ss.
        /// 
        /// If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the specified minute (mm). The value of EndTime must be later than the value of Starttime. In most cases, the interval between the two times cannot be more than 10 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeZones](~~25610~~) operation to query the most recent list of zones.
        /// 
        /// This parameter is empty by default, which indicates that the system randomly selects a zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
