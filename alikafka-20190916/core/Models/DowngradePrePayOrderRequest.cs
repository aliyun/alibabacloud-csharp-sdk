// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DowngradePrePayOrderRequest : TeaModel {
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public DowngradePrePayOrderRequestConfluentConfig ConfluentConfig { get; set; }
        public class DowngradePrePayOrderRequestConfluentConfig : TeaModel {
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

        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        [NameInMap("EipModel")]
        [Validation(Required=false)]
        public bool? EipModel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
