// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayOrderRequest : TeaModel {
        /// <summary>
        /// The configurations of ApsaraMQ for Confluent components.
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public CreatePrePayOrderRequestConfluentConfig ConfluentConfig { get; set; }
        public class CreatePrePayOrderRequestConfluentConfig : TeaModel {
            /// <summary>
            /// The number of CPU cores of Connect.
            /// </summary>
            [NameInMap("ConnectCU")]
            [Validation(Required=false)]
            public int? ConnectCU { get; set; }

            /// <summary>
            /// The number of replicas of Connect.
            /// </summary>
            [NameInMap("ConnectReplica")]
            [Validation(Required=false)]
            public int? ConnectReplica { get; set; }

            /// <summary>
            /// The number of CPU cores of Control Center.
            /// </summary>
            [NameInMap("ControlCenterCU")]
            [Validation(Required=false)]
            public int? ControlCenterCU { get; set; }

            /// <summary>
            /// The number of replicas of Control Center.
            /// </summary>
            [NameInMap("ControlCenterReplica")]
            [Validation(Required=false)]
            public int? ControlCenterReplica { get; set; }

            /// <summary>
            /// The disk capacity of Control Center. Unit: GB
            /// </summary>
            [NameInMap("ControlCenterStorage")]
            [Validation(Required=false)]
            public int? ControlCenterStorage { get; set; }

            /// <summary>
            /// The number of CPU cores of the Kafka broker.
            /// </summary>
            [NameInMap("KafkaCU")]
            [Validation(Required=false)]
            public int? KafkaCU { get; set; }

            /// <summary>
            /// The number of replicas of the Kafka broker.
            /// </summary>
            [NameInMap("KafkaReplica")]
            [Validation(Required=false)]
            public int? KafkaReplica { get; set; }

            /// <summary>
            /// The number of CPU cores of Kafka Rest Proxy.
            /// </summary>
            [NameInMap("KafkaRestProxyCU")]
            [Validation(Required=false)]
            public int? KafkaRestProxyCU { get; set; }

            /// <summary>
            /// The number of replicas of Kafka Rest Proxy.
            /// </summary>
            [NameInMap("KafkaRestProxyReplica")]
            [Validation(Required=false)]
            public int? KafkaRestProxyReplica { get; set; }

            /// <summary>
            /// The disk capacity of the Kafka broker. Unit: GB
            /// </summary>
            [NameInMap("KafkaStorage")]
            [Validation(Required=false)]
            public int? KafkaStorage { get; set; }

            /// <summary>
            /// The number of CPU cores of ksqIDB.
            /// </summary>
            [NameInMap("KsqlCU")]
            [Validation(Required=false)]
            public int? KsqlCU { get; set; }

            /// <summary>
            /// The number of replicas of ksqlDB.
            /// </summary>
            [NameInMap("KsqlReplica")]
            [Validation(Required=false)]
            public int? KsqlReplica { get; set; }

            /// <summary>
            /// The disk capacity of ksqlDB. Unit: GB
            /// </summary>
            [NameInMap("KsqlStorage")]
            [Validation(Required=false)]
            public int? KsqlStorage { get; set; }

            /// <summary>
            /// The number of CPU cores of Schema Registry.
            /// </summary>
            [NameInMap("SchemaRegistryCU")]
            [Validation(Required=false)]
            public int? SchemaRegistryCU { get; set; }

            /// <summary>
            /// The number of replicas of Schema Registry.
            /// </summary>
            [NameInMap("SchemaRegistryReplica")]
            [Validation(Required=false)]
            public int? SchemaRegistryReplica { get; set; }

            /// <summary>
            /// The number of CPU cores of ZooKeeper.
            /// </summary>
            [NameInMap("ZooKeeperCU")]
            [Validation(Required=false)]
            public int? ZooKeeperCU { get; set; }

            /// <summary>
            /// The number of replicas of ZooKeeper.
            /// </summary>
            [NameInMap("ZooKeeperReplica")]
            [Validation(Required=false)]
            public int? ZooKeeperReplica { get; set; }

            /// <summary>
            /// The disk capacity of ZooKeeper. Unit: GB
            /// </summary>
            [NameInMap("ZooKeeperStorage")]
            [Validation(Required=false)]
            public int? ZooKeeperStorage { get; set; }

        }

        /// <summary>
        /// The deployment mode of the instance. Valid values:
        /// 
        /// *   **4**: deploys the instance that allows access from the Internet and a VPC.
        /// *   **5**: deploys the instance that allows access only from a VPC.
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// The disk size. Unit: GB.
        /// 
        /// For more information about the valid values, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The disk type. Valid values:
        /// 
        /// *   **0**: ultra disk
        /// *   **1**: standard SSD
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
        /// The Internet traffic for the instance.
        /// 
        /// *   This parameter is required if the **DeployType** parameter is set to **4**.
        /// *   For more information about the valid values, see [Pay-as-you-go](https://help.aliyun.com/document_detail/72142.html).
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// The maximum traffic for the instance. We recommend that you do not configure this parameter.
        /// 
        /// *   You must configure at least one of the **IoMax** and **IoMaxSpec** parameters. If both parameters are configured, the value of the **IoMaxSpec** parameter takes effect. We recommend that you configure only the **IoMaxSpec** parameter.
        /// *   For more information about the valid values, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// The traffic specification of the instance. We recommend that you configure this parameter.
        /// 
        /// *   You must configure at least one of the **IoMax** and **IoMaxSpec** parameters. If both parameters are configured, the value of the **IoMaxSpec** parameter takes effect. We recommend that you configure only the **IoMaxSpec** parameter.
        /// *   For more information about the valid values, see [Billing](https://help.aliyun.com/document_detail/84737.html).
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
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   For more information about the valid values, see [Billing](https://help.aliyun.com/document_detail/84737.html).
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
        /// The edition of the instance. Valid values:
        /// 
        /// *   **normal**: Standard Edition (High Write)
        /// *   **professional**: Professional Edition (High Write)
        /// *   **professionalForHighRead**: Professional Edition (High Read)
        /// 
        /// For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrePayOrderRequestTag> Tag { get; set; }
        public class CreatePrePayOrderRequestTag : TeaModel {
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
        /// *   You must specify at least one of the PartitionNum and TopicQuota parameters. We recommend that you configure only the PartitionNum parameter.
        /// *   If you specify both parameters, the topic-based sales model is used to check whether the PartitionNum value and the TopicQuota value are the same. If they are not the same, a failure response is returned. If they are the same, the order is placed based on the PartitionNum value.
        /// *   The default value of the TopicQuota parameter varies based on the value of the IoMaxSpec parameter. If the number of topics that you consume exceeds the default value, you are charged additional fees.
        /// *   For more information about the valid values, see [Billing](https://help.aliyun.com/document_detail/84737.html).
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
