// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpgradePrePayOrderRequest : TeaModel {
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public UpgradePrePayOrderRequestConfluentConfig ConfluentConfig { get; set; }
        public class UpgradePrePayOrderRequestConfluentConfig : TeaModel {
            [NameInMap("ConnectCU")]
            [Validation(Required=false)]
            public int? ConnectCU { get; set; }

            [NameInMap("ConnectReplica")]
            [Validation(Required=false)]
            public int? ConnectReplica { get; set; }

            [NameInMap("ControlCenterCU")]
            [Validation(Required=false)]
            public int? ControlCenterCU { get; set; }

            [NameInMap("ControlCenterReplica")]
            [Validation(Required=false)]
            public int? ControlCenterReplica { get; set; }

            [NameInMap("ControlCenterStorage")]
            [Validation(Required=false)]
            public int? ControlCenterStorage { get; set; }

            [NameInMap("KafkaCU")]
            [Validation(Required=false)]
            public int? KafkaCU { get; set; }

            [NameInMap("KafkaReplica")]
            [Validation(Required=false)]
            public int? KafkaReplica { get; set; }

            [NameInMap("KafkaRestProxyCU")]
            [Validation(Required=false)]
            public int? KafkaRestProxyCU { get; set; }

            [NameInMap("KafkaRestProxyReplica")]
            [Validation(Required=false)]
            public int? KafkaRestProxyReplica { get; set; }

            [NameInMap("KafkaStorage")]
            [Validation(Required=false)]
            public int? KafkaStorage { get; set; }

            [NameInMap("KsqlCU")]
            [Validation(Required=false)]
            public int? KsqlCU { get; set; }

            [NameInMap("KsqlReplica")]
            [Validation(Required=false)]
            public int? KsqlReplica { get; set; }

            [NameInMap("KsqlStorage")]
            [Validation(Required=false)]
            public int? KsqlStorage { get; set; }

            [NameInMap("SchemaRegistryCU")]
            [Validation(Required=false)]
            public int? SchemaRegistryCU { get; set; }

            [NameInMap("SchemaRegistryReplica")]
            [Validation(Required=false)]
            public int? SchemaRegistryReplica { get; set; }

            [NameInMap("ZooKeeperCU")]
            [Validation(Required=false)]
            public int? ZooKeeperCU { get; set; }

            [NameInMap("ZooKeeperReplica")]
            [Validation(Required=false)]
            public int? ZooKeeperReplica { get; set; }

            [NameInMap("ZooKeeperStorage")]
            [Validation(Required=false)]
            public int? ZooKeeperStorage { get; set; }

        }

        /// <summary>
        /// The size of the disk.
        /// 
        /// *   The disk size that you specify must be greater than or equal to the current disk size of the instance.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The Internet traffic for the instance.
        /// 
        /// *   The Internet traffic volume that you specify must be greater than or equal to the current Internet traffic volume of the instance.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// > - If the **EipModel** parameter is set to **true**, set the **EipMax** parameter to a value that is greater than 0.
        /// > - If the **EipModel** parameter is set to **false**, set the **EipMax** parameter to **0**.
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
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum traffic for the instance. We recommend that you do not configure this parameter.
        /// 
        /// *   The maximum traffic volume that you specify must be greater than or equal to the current maximum traffic volume of the instance.
        /// *   You must configure at least one of the IoMax and IoMaxSpec parameters. If you configure both parameters, the value of the IoMaxSpec parameter takes effect. We recommend that you configure only the IoMaxSpec parameter.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// The traffic specification of the instance. We recommend that you configure this parameter.
        /// 
        /// *   The traffic specification that you specify must be greater than or equal to the current traffic specification of the instance.
        /// *   You must configure at least one of the IoMax and IoMaxSpec parameters. If you configure both parameters, the value of the IoMaxSpec parameter takes effect. We recommend that you configure only the IoMaxSpec parameter.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// The number of partitions. We recommend that you configure this parameter.
        /// 
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
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
        /// The edition of the instance. Valid values:
        /// 
        /// *   **normal**: Standard Edition (High Write)
        /// *   **professional**: Professional Edition (High Write)
        /// *   **professionalForHighRead**: Professional Edition (High Read)
        /// 
        /// You cannot downgrade an instance from the Professional Edition to the Standard Edition. For more information about these instance editions, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The number of topics. We recommend that you do not configure this parameter.
        /// 
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   The default value of the TopicQuota parameter varies based on the value of the IoMaxSpec parameter. If the number of topics that you consume exceeds the default value, you are charged additional fees.
        /// *   For more information about the valid values, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
