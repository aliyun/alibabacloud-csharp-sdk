// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsOpenAPIProjectRequest : TeaModel {
        /// <summary>
        /// The business system identifier, which is optional and is a specific field of the Post message.
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The settings of the destination data source.
        /// </summary>
        [NameInMap("DestConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestDestConfig DestConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestDestConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable message tracing when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("EnableMsgTrace")]
            [Validation(Required=false)]
            public bool? EnableMsgTrace { get; set; }

            /// <summary>
            /// The ID of the data source.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values: `MYSQL`, `MARIADB`, `OB_MYSQL`, `OB_MYSQL_CE`, `OB_ORACLE`, `ORACLE`, `DB2_LUW`, `KAFKA`, `ROCKETMQ`, `DATAHUB`, `SYBASE`, `LOGPROXY`, `ADB`, `DBP_OP_ROUTE`, `DMS`, `IDB`, and `TIDB`.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The tag of the Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("MsgTags")]
            [Validation(Required=false)]
            public string MsgTags { get; set; }

            /// <summary>
            /// The partitioned index, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ, and the partitioning mode is set to ONE.
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            /// <summary>
            /// The partitioning mode, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ. Valid values: ONE, HASH, and TABLE.
            /// </summary>
            [NameInMap("PartitionMode")]
            [Validation(Required=false)]
            public string PartitionMode { get; set; }

            /// <summary>
            /// The producer group of the Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("ProducerGroup")]
            [Validation(Required=false)]
            public string ProducerGroup { get; set; }

            /// <summary>
            /// The timeout period for a single Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("SendMsgTimeout")]
            [Validation(Required=false)]
            public long? SendMsgTimeout { get; set; }

            /// <summary>
            /// Specifies whether to enable message sequencing when the destination data source is DataHub.
            /// </summary>
            [NameInMap("SequenceEnable")]
            [Validation(Required=false)]
            public bool? SequenceEnable { get; set; }

            /// <summary>
            /// The start time of the sequence, which must be specified if the destination data source is DataHub and message sequencing is enabled. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("SequenceStartTimestamp")]
            [Validation(Required=false)]
            public long? SequenceStartTimestamp { get; set; }

            /// <summary>
            /// The text serialization type, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ. Valid values: Default, Canal, Dataworks, SharePlex, and DefaultExtendColumnType.
            /// </summary>
            [NameInMap("SerializerType")]
            [Validation(Required=false)]
            public string SerializerType { get; set; }

            /// <summary>
            /// The type of the topic to which the Post message belongs when the destination data source is DataHub. Valid values: Tuple and Blob.
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        /// <summary>
        /// A collection of label IDs.
        /// </summary>
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        /// <summary>
        /// The page number, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page size, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The settings of the source data source.
        /// </summary>
        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestSourceConfig SourceConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestSourceConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable message tracing when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("EnableMsgTrace")]
            [Validation(Required=false)]
            public bool? EnableMsgTrace { get; set; }

            /// <summary>
            /// The ID of the data source.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values: `MYSQL`, `MARIADB`, `OB_MYSQL`, `OB_MYSQL_CE`, `OB_ORACLE`, `ORACLE`, `DB2_LUW`, `KAFKA`, `ROCKETMQ`, `DATAHUB`, `SYBASE`, `LOGPROXY`, `ADB`, `DBP_OP_ROUTE`, `DMS`, `IDB`, and `TIDB`.
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// The tag of the Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("MsgTags")]
            [Validation(Required=false)]
            public string MsgTags { get; set; }

            /// <summary>
            /// The partitioned index, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ, and the partitioning mode is set to ONE.
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            /// <summary>
            /// The partitioning mode, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ. Valid values: ONE, HASH, and TABLE.
            /// </summary>
            [NameInMap("PartitionMode")]
            [Validation(Required=false)]
            public string PartitionMode { get; set; }

            /// <summary>
            /// The producer group of the Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("ProducerGroup")]
            [Validation(Required=false)]
            public string ProducerGroup { get; set; }

            /// <summary>
            /// The timeout period for a single Post message when the destination data source is RocketMQ.
            /// </summary>
            [NameInMap("SendMsgTimeout")]
            [Validation(Required=false)]
            public long? SendMsgTimeout { get; set; }

            /// <summary>
            /// Specifies whether to enable message sequencing when the destination data source is DataHub.
            /// </summary>
            [NameInMap("SequenceEnable")]
            [Validation(Required=false)]
            public bool? SequenceEnable { get; set; }

            /// <summary>
            /// The start time of the sequence, which must be specified if the destination data source is DataHub and message sequencing is enabled. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("SequenceStartTimestamp")]
            [Validation(Required=false)]
            public long? SequenceStartTimestamp { get; set; }

            /// <summary>
            /// The text serialization type, which must be specified if the destination data source is a message queue system, such as Kafka, DataHub, or RocketMQ. Valid values: Default, Canal, Dataworks, SharePlex, and DefaultExtendColumnType.
            /// </summary>
            [NameInMap("SerializerType")]
            [Validation(Required=false)]
            public string SerializerType { get; set; }

            /// <summary>
            /// The type of the topic to which the Post message belongs when the destination data source is DataHub. Valid values: Tuple and Blob.
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        /// <summary>
        /// The mappings for the synchronization objects.
        /// </summary>
        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestTransferMapping TransferMapping { get; set; }
        public class CreateOmsOpenAPIProjectRequestTransferMapping : TeaModel {
            /// <summary>
            /// The table mapping in the source data source, which is a conventional mapping scheme and takes effect only when Mode is set to NORMAL.
            /// </summary>
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<CreateOmsOpenAPIProjectRequestTransferMappingDatabases> Databases { get; set; }
            public class CreateOmsOpenAPIProjectRequestTransferMappingDatabases : TeaModel {
                /// <summary>
                /// The ID of the database. This parameter takes effect when the source data source is IDB.
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The mapped-to database. This parameter takes effect when the destination data source is a database.
                /// </summary>
                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                /// <summary>
                /// The settings for the target table objects in the current database.
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTables> Tables { get; set; }
                public class CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTables : TeaModel {
                    /// <summary>
                    /// The schema of the ADB table. If the destination data source is ADB, you need to configure additional information for schema synchronization.
                    /// </summary>
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
                        /// <summary>
                        /// The list of distribution key columns.
                        /// </summary>
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        /// <summary>
                        /// The lifecycle of the table.
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// The partitioning expression.
                        /// </summary>
                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        /// <summary>
                        /// The list of primary key columns.
                        /// </summary>
                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    /// <summary>
                    /// The list of filter columns, which are the columns to be synchronized.
                    /// </summary>
                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    /// <summary>
                    /// The name of the mapped-to table or topic. If the destination data source is a database, this parameter specifies the name of the mapped-to table. If the destination data source is a message queue system, this parameter specifies the name of the mapped-to topic.
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// The list of sharding key columns. This parameter applies to scenarios where the destination data source is a message queue system.
                    /// </summary>
                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// The ID of the table. This parameter takes effect when the source data source is IDB.
                    /// </summary>
                    [NameInMap("TableId")]
                    [Validation(Required=false)]
                    public string TableId { get; set; }

                    /// <summary>
                    /// The name of the table.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// Valid values: DATABASE and TABLE.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The row filter conditions.
                    /// </summary>
                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                /// <summary>
                /// The mapped-to tenant. This parameter takes effect when the source data source is OceanBase Database.
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                /// <summary>
                /// Valid values: DATABASE and TABLE.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The mapping type. Valid values: \"NORMAL\" and \"WHITE_AND_BLACK_LIST\".
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// The settings of synchronization steps.
        /// </summary>
        [NameInMap("TransferStepConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestTransferStepConfig TransferStepConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestTransferStepConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable full migration.
            /// </summary>
            [NameInMap("EnableFullSync")]
            [Validation(Required=false)]
            public bool? EnableFullSync { get; set; }

            /// <summary>
            /// Specifies whether to enable incremental synchronization.
            /// </summary>
            [NameInMap("EnableIncrSync")]
            [Validation(Required=false)]
            public bool? EnableIncrSync { get; set; }

            /// <summary>
            /// Specifies whether to enable schema synchronization.
            /// </summary>
            [NameInMap("EnableStructSync")]
            [Validation(Required=false)]
            public bool? EnableStructSync { get; set; }

            /// <summary>
            /// The settings of incremental synchronization steps.
            /// </summary>
            [NameInMap("IncrSyncStepTransferConfig")]
            [Validation(Required=false)]
            public CreateOmsOpenAPIProjectRequestTransferStepConfigIncrSyncStepTransferConfig IncrSyncStepTransferConfig { get; set; }
            public class CreateOmsOpenAPIProjectRequestTransferStepConfigIncrSyncStepTransferConfig : TeaModel {
                /// <summary>
                /// The list of data types of incremental data synchronized in incremental synchronization.
                /// </summary>
                [NameInMap("RecordTypeList")]
                [Validation(Required=false)]
                public List<string> RecordTypeList { get; set; }

                /// <summary>
                /// The start time for incremental synchronization. The value is a timestamp in seconds.
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// The retention time of logs when incremental synchronization is enabled and the incremental log pull component is Store.
                /// </summary>
                [NameInMap("StoreLogKeptHour")]
                [Validation(Required=false)]
                public long? StoreLogKeptHour { get; set; }

                /// <summary>
                /// Specifies whether to enable intra-transaction sequencing when incremental synchronization is enabled and the incremental log pull component is Store.
                /// </summary>
                [NameInMap("StoreTransactionEnabled")]
                [Validation(Required=false)]
                public bool? StoreTransactionEnabled { get; set; }

                /// <summary>
                /// Valid values: STRUCT, FULL, and INCR.
                /// </summary>
                [NameInMap("TransferStepType")]
                [Validation(Required=false)]
                public string TransferStepType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the migration instance. Generally, if you want to create a project on a public cloud, you must first purchase a migration instance.
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
