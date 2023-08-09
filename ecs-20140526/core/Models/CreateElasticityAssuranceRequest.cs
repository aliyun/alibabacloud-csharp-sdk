// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateElasticityAssuranceRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateElasticityAssuranceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateElasticityAssuranceRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The type of the private pool with which the elasticity assurance is associated. Valid values:
            /// 
            /// *   Open: open private pool
            /// *   Target: specified private pool
            /// 
            /// Default value: Open.
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

            /// <summary>
            /// The name of the elasticity assurance. The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The total number of times that the elasticity assurance can be applied. Set the value to Unlimited. This value indicates that the elasticity assurance can be applied an unlimited number of times within its effective period.
        /// 
        /// Default value: Unlimited.
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the token, but make sure that the token is unique among requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the elasticity assurance. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The total number of instances for which the capacity of an instance type is reserved.
        /// 
        /// Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        /// <summary>
        /// The instance types. Currently, an elasticity assurance can be created to reserve the capacity of a single instance type.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public List<string> InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The effective period of the elasticity assurance. The unit of the effective period is determined by the `PeriodUnit` value. Valid values:
        /// 
        /// *   When the `PeriodUnit` parameter is set to `Month`, the valid values are 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   When the `PeriodUnit` parameter is set to `Year`, the valid values are 1, 2, 3, 4, and 5.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the effective period of the elasticity assurance. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Year.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the region in which to create the elasticity assurance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the elasticity assurance is assigned.
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
        /// The time when the elasticity assurance takes effect. The default value is the time when the CreateElasticityAssurance operation is called to create the elasticity assurance. Specify the time in the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC. For more information, see [ISO 8601](~~25696~~).
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The tags to add to the elasticity assurance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateElasticityAssuranceRequestTag> Tag { get; set; }
        public class CreateElasticityAssuranceRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the elasticity assurance. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the elasticity assurance. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone IDs of the elasticity assurances. Currently, an elasticity assurance can be used to reserve resources within a single zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public List<string> ZoneId { get; set; }

    }

}
