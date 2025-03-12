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
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DataWorksBusinessName")]
            [Validation(Required=false)]
            public string DataWorksBusinessName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TUPLE</para>
            /// </summary>
            [NameInMap("DatahubTopicType")]
            [Validation(Required=false)]
            public string DatahubTopicType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MqPartition")]
            [Validation(Required=false)]
            public int? MqPartition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE</para>
            /// </summary>
            [NameInMap("MqPartitionMode")]
            [Validation(Required=false)]
            public string MqPartitionMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("MqSerializerType")]
            [Validation(Required=false)]
            public string MqSerializerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RocketMqEnableMsgTrace")]
            [Validation(Required=false)]
            public bool? RocketMqEnableMsgTrace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default_tag</para>
            /// </summary>
            [NameInMap("RocketMqMsgTags")]
            [Validation(Required=false)]
            public string RocketMqMsgTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OMS</para>
            /// </summary>
            [NameInMap("RocketMqProducerGroup")]
            [Validation(Required=false)]
            public string RocketMqProducerGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RocketMqSendMsgTimeout")]
            [Validation(Required=false)]
            public long? RocketMqSendMsgTimeout { get; set; }

            [NameInMap("SinkStoreFormat")]
            [Validation(Required=false)]
            public string SinkStoreFormat { get; set; }

            [NameInMap("SourceStoreFormat")]
            [Validation(Required=false)]
            public string SourceStoreFormat { get; set; }

            [NameInMap("SyncSchema")]
            [Validation(Required=false)]
            public bool? SyncSchema { get; set; }

            [NameInMap("SyncSchemaColumnName")]
            [Validation(Required=false)]
            public string SyncSchemaColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TableCategory")]
            [Validation(Required=false)]
            public string TableCategory { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableFullTransfer")]
        [Validation(Required=false)]
        public bool? EnableFullTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableFullVerify")]
        [Validation(Required=false)]
        public bool? EnableFullVerify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableIncrTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReverseIncrTransfer")]
        [Validation(Required=false)]
        public bool? EnableReverseIncrTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStructTransfer")]
        [Validation(Required=false)]
        public bool? EnableStructTransfer { get; set; }

        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestFullTransferConfig FullTransferConfig { get; set; }
        public class CreateProjectRequestFullTransferConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowDestTableNotEmpty")]
            [Validation(Required=false)]
            public bool? AllowDestTableNotEmpty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("FullTransferSpeedMode")]
            [Validation(Required=false)]
            public string FullTransferSpeedMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("FullVerifySpeedMode")]
            [Validation(Required=false)]
            public string FullVerifySpeedMode { get; set; }

            [NameInMap("HbaseObjCheckMode")]
            [Validation(Required=false)]
            public string HbaseObjCheckMode { get; set; }

            [NameInMap("HbaseObjMigMode")]
            [Validation(Required=false)]
            public string HbaseObjMigMode { get; set; }

            [NameInMap("IndexDDLConcurrencyLimit")]
            [Validation(Required=false)]
            public int? IndexDDLConcurrencyLimit { get; set; }

            [NameInMap("MaxConcurrentIndexDDLs")]
            [Validation(Required=false)]
            public int? MaxConcurrentIndexDDLs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NonePkUkTruncateDstTable")]
            [Validation(Required=false)]
            public bool? NonePkUkTruncateDstTable { get; set; }

            [NameInMap("ReadWorkerNum")]
            [Validation(Required=false)]
            public int? ReadWorkerNum { get; set; }

            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

            [NameInMap("WriteWorkerNum")]
            [Validation(Required=false)]
            public int? WriteWorkerNum { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestIncrTransferConfig IncrTransferConfig { get; set; }
        public class CreateProjectRequestIncrTransferConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIncrSyncStatistics")]
            [Validation(Required=false)]
            public bool? EnableIncrSyncStatistics { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSequencingWithinTxn")]
            [Validation(Required=false)]
            public bool? EnableSequencingWithinTxn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("IncrSyncConcurrency")]
            [Validation(Required=false)]
            public int? IncrSyncConcurrency { get; set; }

            [NameInMap("RecordTypeWhiteList")]
            [Validation(Required=false)]
            public List<string> RecordTypeWhiteList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1689201369</para>
            /// </summary>
            [NameInMap("StartTimestamp")]
            [Validation(Required=false)]
            public string StartTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("StoreLogKeptHour")]
            [Validation(Required=false)]
            public int? StoreLogKeptHour { get; set; }

            [NameInMap("SupportDDLTypes")]
            [Validation(Required=false)]
            public List<string> SupportDDLTypes { get; set; }

            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

        }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open_api_create_project/oacp_xxx</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        [NameInMap("ReverseIncrTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestReverseIncrTransferConfig ReverseIncrTransferConfig { get; set; }
        public class CreateProjectRequestReverseIncrTransferConfig : TeaModel {
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

            [NameInMap("SupportDDLTypes")]
            [Validation(Required=false)]
            public List<string> SupportDDLTypes { get; set; }

            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_4j0cz****</para>
        /// </summary>
        [NameInMap("SinkEndpointId")]
        [Validation(Required=false)]
        public string SinkEndpointId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e_4j0c12z****</para>
        /// </summary>
        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        [NameInMap("StructTransferConfig")]
        [Validation(Required=false)]
        public CreateProjectRequestStructTransferConfig StructTransferConfig { get; set; }
        public class CreateProjectRequestStructTransferConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DO_NOTHING_IF_BYTE_USED</para>
            /// </summary>
            [NameInMap("ByteCharConvertStrategy")]
            [Validation(Required=false)]
            public string ByteCharConvertStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeferIndexCreation")]
            [Validation(Required=false)]
            public bool? DeferIndexCreation { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public CreateProjectRequestTransferMapping TransferMapping { get; set; }
        public class CreateProjectRequestTransferMapping : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<CreateProjectRequestTransferMappingDatabases> Databases { get; set; }
            public class CreateProjectRequestTransferMappingDatabases : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cluster_name</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gez3***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mapped_db</para>
                /// </summary>
                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db_name</para>
                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_4azdil4lu7***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_table</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;5</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_3wsmjv49a***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_view</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>view_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;5</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_4l085bu7***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_table</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ObkvPartitionConfig")]
                    [Validation(Required=false)]
                    public CreateProjectRequestTransferMappingDatabasesTablesObkvPartitionConfig ObkvPartitionConfig { get; set; }
                    public class CreateProjectRequestTransferMappingDatabasesTablesObkvPartitionConfig : TeaModel {
                        [NameInMap("PartitionSize")]
                        [Validation(Required=false)]
                        public int? PartitionSize { get; set; }

                        [NameInMap("PartitionType")]
                        [Validation(Required=false)]
                        public string PartitionType { get; set; }

                        [NameInMap("VirtualColumn")]
                        [Validation(Required=false)]
                        public string VirtualColumn { get; set; }

                    }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id &gt; 1</para>
                    /// </summary>
                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tenant_name</para>
                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_4himpq4z***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_view</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>view_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&gt;1</para>
                    /// </summary>
                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

            }

            [NameInMap("DatabasesBlack")]
            [Validation(Required=false)]
            public List<CreateProjectRequestTransferMappingDatabasesBlack> DatabasesBlack { get; set; }
            public class CreateProjectRequestTransferMappingDatabasesBlack : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cluster_name</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e_3y6v5v1x94f4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mapped_db</para>
                /// </summary>
                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db_name</para>
                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_4himpq4zf***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_table</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;1</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_474hmh5iqo***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_table</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;1</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_474hmh5iqo***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_table</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;1</para>
                    /// </summary>
                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tenant_name</para>
                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public string PartitionLifeCycle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e_4azdil4lu7mo</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_view</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>view_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id&lt;5</para>
                    /// </summary>
                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SPCEIFIC</para>
            /// </summary>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIGRATION</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseOss")]
        [Validation(Required=false)]
        public bool? UseOss { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g_abcdefj***</para>
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
