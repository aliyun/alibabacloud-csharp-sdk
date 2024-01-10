// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("CommonTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestCommonTransferConfig CommonTransferConfig { get; set; }
        public class CreateProjectRequestCommonTransferConfig : TeaModel {
            [NameInMap("ActiveActive")]
            [Validation(Required=false)]
            public bool? ActiveActive { get; set; }

            [NameInMap("CustomColumns")]
            [Validation(Required=false)]
            public List<CreateProjectRequestCommonTransferConfigCustomColumns> CustomColumns { get; set; }
            public class CreateProjectRequestCommonTransferConfigCustomColumns : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

            }

            [NameInMap("DataWorksBusinessName")]
            [Validation(Required=false)]
            public string DataWorksBusinessName { get; set; }

            [NameInMap("DatahubTopicType")]
            [Validation(Required=false)]
            public string DatahubTopicType { get; set; }

            [NameInMap("MqPartition")]
            [Validation(Required=false)]
            public int? MqPartition { get; set; }

            [NameInMap("MqPartitionMode")]
            [Validation(Required=false)]
            public string MqPartitionMode { get; set; }

            [NameInMap("MqSerializerType")]
            [Validation(Required=false)]
            public string MqSerializerType { get; set; }

            [NameInMap("RocketMqEnableMsgTrace")]
            [Validation(Required=false)]
            public bool? RocketMqEnableMsgTrace { get; set; }

            [NameInMap("RocketMqMsgTags")]
            [Validation(Required=false)]
            public string RocketMqMsgTags { get; set; }

            [NameInMap("RocketMqProducerGroup")]
            [Validation(Required=false)]
            public string RocketMqProducerGroup { get; set; }

            [NameInMap("RocketMqSendMsgTimeout")]
            [Validation(Required=false)]
            public long? RocketMqSendMsgTimeout { get; set; }

            [NameInMap("SyncSchema")]
            [Validation(Required=false)]
            public bool? SyncSchema { get; set; }

            [NameInMap("SyncSchemaColumnName")]
            [Validation(Required=false)]
            public string SyncSchemaColumnName { get; set; }

            [NameInMap("TableCategory")]
            [Validation(Required=false)]
            public string TableCategory { get; set; }

        }

        [NameInMap("EnableFullTransfer")]
        [Validation(Required=false)]
        public bool? EnableFullTransfer { get; set; }

        [NameInMap("EnableFullVerify")]
        [Validation(Required=false)]
        public bool? EnableFullVerify { get; set; }

        [NameInMap("EnableIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableIncrTransfer { get; set; }

        [NameInMap("EnableReverseIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableReverseIncrTransfer { get; set; }

        [NameInMap("EnableStructTransfer")]
        [Validation(Required=false)]
        public bool? EnableStructTransfer { get; set; }

        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestFullTransferConfig FullTransferConfig { get; set; }
        public class CreateProjectRequestFullTransferConfig : TeaModel {
            [NameInMap("AllowDestTableNotEmpty")]
            [Validation(Required=false)]
            public bool? AllowDestTableNotEmpty { get; set; }

            [NameInMap("FullTransferSpeedMode")]
            [Validation(Required=false)]
            public string FullTransferSpeedMode { get; set; }

            [NameInMap("FullVerifySpeedMode")]
            [Validation(Required=false)]
            public string FullVerifySpeedMode { get; set; }

            [NameInMap("NonePkUkTruncateDstTable")]
            [Validation(Required=false)]
            public bool? NonePkUkTruncateDstTable { get; set; }

        }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestIncrTransferConfig IncrTransferConfig { get; set; }
        public class CreateProjectRequestIncrTransferConfig : TeaModel {
            [NameInMap("EnableIncrSyncStatistics")]
            [Validation(Required=false)]
            public bool? EnableIncrSyncStatistics { get; set; }

            [NameInMap("EnableSequencingWithinTxn")]
            [Validation(Required=false)]
            public bool? EnableSequencingWithinTxn { get; set; }

            [NameInMap("IncrSyncConcurrency")]
            [Validation(Required=false)]
            public int? IncrSyncConcurrency { get; set; }

            [NameInMap("RecordTypeWhiteList")]
            [Validation(Required=false)]
            public List<string> RecordTypeWhiteList { get; set; }

            [NameInMap("StartTimestamp")]
            [Validation(Required=false)]
            public string StartTimestamp { get; set; }

            [NameInMap("StoreLogKeptHour")]
            [Validation(Required=false)]
            public int? StoreLogKeptHour { get; set; }

        }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        [NameInMap("SinkEndpointId")]
        [Validation(Required=false)]
        public string SinkEndpointId { get; set; }

        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        [NameInMap("StructTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestStructTransferConfig StructTransferConfig { get; set; }
        public class CreateProjectRequestStructTransferConfig : TeaModel {
            [NameInMap("ByteCharConvertStrategy")]
            [Validation(Required=false)]
            public string ByteCharConvertStrategy { get; set; }

            [NameInMap("DeferIndexCreation")]
            [Validation(Required=false)]
            public bool? DeferIndexCreation { get; set; }

        }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public CreateProjectRequestTransferMapping TransferMapping { get; set; }
        public class CreateProjectRequestTransferMapping : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<CreateProjectRequestTransferMappingDatabases> Databases { get; set; }
            public class CreateProjectRequestTransferMappingDatabases : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SpecificTables")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesSpecificTables> SpecificTables { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesSpecificTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("SpecificViews")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesSpecificViews> SpecificViews { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesSpecificViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesTables> Tables { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesViews> Views { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

            }

            [NameInMap("DatabasesBlack")]
            [Validation(Required=false)]
            public List<CreateProjectRequestTransferMappingDatabasesBlack> DatabasesBlack { get; set; }
            public class CreateProjectRequestTransferMappingDatabasesBlack : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SpecificTables")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesBlackSpecificTables> SpecificTables { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesBlackSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesBlackSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesBlackSpecificTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("SpecificViews")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesBlackSpecificViews> SpecificViews { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesBlackSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesBlackSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesBlackSpecificViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesBlackTables> Tables { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesBlackTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesBlackTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesBlackTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<CreateProjectRequestTransferMappingDatabasesBlackViews> Views { get; set; }
                public class CreateProjectRequestTransferMappingDatabasesBlackViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesBlackViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesBlackViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

            }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("TableAndViewBlackList")]
            [Validation(Required=false)]
            public List<string> TableAndViewBlackList { get; set; }

            [NameInMap("TableAndViewWhiteList")]
            [Validation(Required=false)]
            public List<string> TableAndViewWhiteList { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UseOss")]
        [Validation(Required=false)]
        public bool? UseOss { get; set; }

        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
