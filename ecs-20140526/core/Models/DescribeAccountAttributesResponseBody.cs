// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesResponseBody : TeaModel {
        /// <summary>
        /// Details about account privileges specified by AccountAttributeItem in the specified region.
        /// </summary>
        [NameInMap("AccountAttributeItems")]
        [Validation(Required=false)]
        public DescribeAccountAttributesResponseBodyAccountAttributeItems AccountAttributeItems { get; set; }
        public class DescribeAccountAttributesResponseBodyAccountAttributeItems : TeaModel {
            [NameInMap("AccountAttributeItem")]
            [Validation(Required=false)]
            public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem> AccountAttributeItem { get; set; }
            public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem : TeaModel {
                /// <summary>
                /// The type of the resource quota in the specified region. Valid values:
                /// 
                /// *   instance-network-type: available network types
                /// *   max-security-groups: the maximum number of security groups
                /// *   max-elastic-network-interfaces: the maximum number of ENIs
                /// *   max-postpaid-instance-vcpu-count: the maximum number of vCPUs for pay-as-you-go instances
                /// *   max-spot-instance-vcpu-count: the maximum number of vCPUs for preemptible instances
                /// *   used-postpaid-instance-vcpu-count: the number of vCPUs that have been allocated to pay-as-you-go instances
                /// *   used-spot-instance-vcpu-count: the number of vCPUs that have been allocated to preemptible instances
                /// *   max-postpaid-yundisk-capacity: the maximum capacity of pay-as-you-go data disks
                /// *   used-postpaid-yundisk-capacity: the capacity of pay-as-you-go disks that have been created
                /// *   max-dedicated-hosts: the maximum number of dedicated hosts
                /// *   supported-postpaid-instance-types: the instance types of pay-as-you-go I/O optimized instances
                /// *   max-axt-command-count: the maximum number of Cloud Assistant commands
                /// *   max-axt-invocation-daily: the maximum number of Cloud Assistant command executions per day
                /// *   real-name-authentication: whether the account has passed the real-name verification
                /// *   max-cloud-assistant-activation-count: the maximum number of activation codes that can be created to use to register managed instances
                /// </summary>
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                /// <summary>
                /// The specific values of resource quotas.
                /// </summary>
                [NameInMap("AttributeValues")]
                [Validation(Required=false)]
                public DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues AttributeValues { get; set; }
                public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues : TeaModel {
                    [NameInMap("ValueItem")]
                    [Validation(Required=false)]
                    public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem> ValueItem { get; set; }
                    public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem : TeaModel {
                        /// <summary>
                        /// The number of privilege attributes in the account.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The data disk category. Valid values:
                        /// 
                        /// *   cloud_efficiency: ultra disk
                        /// *   cloud_ssd: standard SSD
                        /// *   cloud_essd: enhanced SSD (ESSD)
                        /// </summary>
                        [NameInMap("DiskCategory")]
                        [Validation(Required=false)]
                        public string DiskCategory { get; set; }

                        /// <summary>
                        /// The expiration time of a privilege. This parameter is returned only when the account privilege has an expiration time. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// The billing method of the instance.
                        /// </summary>
                        [NameInMap("InstanceChargeType")]
                        [Validation(Required=false)]
                        public string InstanceChargeType { get; set; }

                        /// <summary>
                        /// The type of the instance.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The value of the resource quota in the specified region. Valid values:
                        /// 
                        /// The values returned for the resource quotas to which the following AttributeName values correspond are 0 or positive integers:
                        /// 
                        /// *   max-security-groups
                        /// *   max-elastic-network-interfaces
                        /// *   max-postpaid-instance-vcpu-count
                        /// *   max-spot-instance-vcpu-count
                        /// *   used-postpaid-instance-vcpu-count
                        /// *   used-spot-instance-vcpu-count
                        /// *   max-postpaid-yundisk-capacity
                        /// *   used-postpaid-yundisk-capacity
                        /// *   max-dedicated-hosts
                        /// *   max-axt-command-count
                        /// *   max-axt-invocation-daily
                        /// *   max-cloud-assistant-activation-count
                        /// 
                        /// When the AttributeName parameter is set to supported-postpay-instance-types, an instance type is returned. For more information, see [Instance families](~~25378~~).
                        /// 
                        /// When the AttributeName parameter is set to real-name-authentications, one of the following values is returned:
                        /// 
                        /// *   yes
                        /// *   none
                        /// *   unnecessary
                        /// 
                        /// When the AttributeName parameter is set to instance-network-type, one of the following values is returned:
                        /// 
                        /// *   vpc
                        /// *   classic
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// The ID of the zone in which the resource resides.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
