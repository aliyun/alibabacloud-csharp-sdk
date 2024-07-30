// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The configurations of Confluent.
        /// 
        /// >  When you create an ApsaraMQ for Confluent instance, you must configure this parameter.
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// The type of the network in which the instance is deployed. Valid values:
        /// 
        /// *   **4**: Internet and virtual private cloud (VPC)
        /// *   **5**: VPC
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, set the value to 5. After the instance is created, you can specify whether to enable each component.
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// The disk size. Unit: GB
        /// 
        /// For information about the valid values of this parameter, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The disk type. Valid values:
        /// 
        /// *   **0**: ultra disk
        /// *   **1**: standard SSD
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// The subscription duration. Unit: months. Default value: 1. Valid values:
        /// 
        /// *   **1 to 12**
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The maximum Internet traffic in the instance.
        /// 
        /// *   If you set **DeployType** to **4**, you must configure this parameter.
        /// *   For information about the valid values, see [Pay-as-you-go](https://help.aliyun.com/document_detail/72142.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// The maximum traffic in the instance. We recommend that you do not configure this parameter.
        /// 
        /// *   You must set one of **IoMax** and **IoMaxSpec**. If both parameters are configured, the value of **IoMaxSpec** is used. We recommend that you configure only **IoMaxSpec**.
        /// *   For information about the valid values of this parameter, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// The traffic specification of the instance. We recommend that you configure this parameter.
        /// 
        /// *   You must configure one of **IoMax** and **IoMaxSpec**. If both parameters are configured, the value of **IoMaxSpec** is used. We recommend that you configure only **IoMaxSpec**.
        /// *   For more information about the valid values of this parameter, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **0**: the subscription billing method
        /// *   **4**: the subscription billing method for ApsaraMQ for Confluent instances
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// The number of partitions. We recommend that you configure this parameter.
        /// 
        /// *   You must configure one of PartitionNum and TopicQuota. We recommend that you configure only PartitionNum.
        /// *   If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.
        /// *   For information about the valid values of this parameter, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// If this parameter is left empty, the default resource group is used. You can view the resource group ID on the Resource Group page in the Resource Management console.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The instance edition. Valid values:
        /// 
        /// *   **normal**: Standard Edition (High Write)
        /// *   **professional**: Professional Edition (High Write)
        /// *   **professionalForHighRead**: Professional Edition (High Read)
        /// 
        /// For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrePayOrderShrinkRequestTag> Tag { get; set; }
        public class CreatePrePayOrderShrinkRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   If this parameter is left empty, the keys of all tags are matched.
            /// *   The tag key can be up to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   This parameter can be left empty.
            /// *   The tag value can be 1 to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of topics. We recommend that you do not configure this parameter.
        /// 
        /// *   You must configure one of PartitionNum and TopicQuota. We recommend that you configure only PartitionNum.
        /// *   If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.
        /// *   The default value of TopicQuota varies based on the value of IoMaxSpec. If the number of topics that you use exceeds the default value, you are charged additional fees.
        /// *   For information about the valid values of this parameter, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// 
        /// >  If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
