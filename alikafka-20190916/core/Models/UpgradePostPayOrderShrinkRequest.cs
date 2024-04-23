// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpgradePostPayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// The disk size. Unit: GB.
        /// 
        /// *   The disk size that you specify must be greater than or equal to the current disk size of the instance.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// >  When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The Internet traffic for the instance.
        /// 
        /// *   The Internet traffic that you specify must be greater than or equal to the current Internet traffic of the instance.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// > 
        /// 
        /// *   If you set **EipModel** to **true**, set **EipMax** to a value that is greater than 0.
        /// 
        /// *   If you set **EipModel** to **false**, set **EipMax** to **0**.
        /// 
        /// *   When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access for the instance. Valid values:
        /// 
        /// *   true: enables Internet access.
        /// *   false: disables Internet access.
        /// </summary>
        [NameInMap("EipModel")]
        [Validation(Required=false)]
        public bool? EipModel { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum traffic for the instance. We recommend that you do not configure this parameter.
        /// 
        /// *   The maximum traffic that you specify must be greater than or equal to the current maximum traffic of the instance.
        /// *   You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// >  When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// The traffic specification of the instance. We recommend that you configure this parameter.
        /// 
        /// *   The traffic specification that you specify must be greater than or equal to the current traffic specification of the instance.
        /// *   You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// >  When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// The number of partitions. We recommend that you configure this parameter.
        /// 
        /// *   You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.
        /// *   If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// >  When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The parameters configured for the Serverless instance. When you create an ApsaraMQ for Kafka V3 serverless instance, you must configure these parameters.
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// The instance edition.
        /// 
        /// Valid values for this parameter if you set PaidType to 1:
        /// 
        /// *   normal: Standard Edition (High Write)
        /// *   professional: Professional Edition (High Write)
        /// *   professionalForHighRead: Professional Edition (High Read)
        /// 
        /// Valid values for this parameter if you set PaidType to 3:
        /// 
        /// *   normal: Serverless Standard Edition
        /// *   professional: Serverless Professional Edition
        /// 
        /// For more information, see [Billing](~~84737~~).
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The number of topics. We recommend that you do not configure this parameter.
        /// 
        /// *   You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.
        /// *   If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.
        /// *   The default value of TopicQuota varies based on the value of IoMaxSpec. If the number of topics that you consume exceeds the default value, you are charged additional fees.
        /// *   For information about the valid values of this parameter, see [Billing](~~84737~~).
        /// 
        /// >  When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
