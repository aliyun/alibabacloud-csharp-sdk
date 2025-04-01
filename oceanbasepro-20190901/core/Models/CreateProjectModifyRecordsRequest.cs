// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectModifyRecordsRequest : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<CreateProjectModifyRecordsRequestDatabases> Databases { get; set; }
        public class CreateProjectModifyRecordsRequestDatabases : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>db_id</para>
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
            public List<CreateProjectModifyRecordsRequestDatabasesSpecificTables> SpecificTables { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesSpecificTables : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesSpecificTablesAdbTableSchema : TeaModel {
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
                /// <para>table_id</para>
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
            public List<CreateProjectModifyRecordsRequestDatabasesSpecificViews> SpecificViews { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesSpecificViews : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesSpecificViewsAdbTableSchema : TeaModel {
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
                /// <para>view_id</para>
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
                /// <para>id &lt;1</para>
                /// </summary>
                [NameInMap("WhereClause")]
                [Validation(Required=false)]
                public string WhereClause { get; set; }

            }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestDatabasesTables> Tables { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesTables : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesTablesAdbTableSchema : TeaModel {
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
                /// <para>table_id</para>
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
                public CreateProjectModifyRecordsRequestDatabasesTablesObkvPartitionConfig ObkvPartitionConfig { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesTablesObkvPartitionConfig : TeaModel {
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
                /// <para>id&lt;1</para>
                /// </summary>
                [NameInMap("WhereClause")]
                [Validation(Required=false)]
                public string WhereClause { get; set; }

            }

            [NameInMap("Views")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestDatabasesViews> Views { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesViews : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesViewsAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesViewsAdbTableSchema : TeaModel {
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
                /// <para>view_id</para>
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
                /// <para>id&lt;1</para>
                /// </summary>
                [NameInMap("WhereClause")]
                [Validation(Required=false)]
                public string WhereClause { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np_fe****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public CreateProjectModifyRecordsRequestTransferMapping TransferMapping { get; set; }
        public class CreateProjectModifyRecordsRequestTransferMapping : TeaModel {
            [NameInMap("BlackTableRules")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingBlackTableRules> BlackTableRules { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingBlackTableRules : TeaModel {
                [NameInMap("ObjectMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingBlackTableRulesObjectMapping ObjectMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingBlackTableRulesObjectMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("SchemaMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingBlackTableRulesSchemaMapping SchemaMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingBlackTableRulesSchemaMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("BlackViewRules")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingBlackViewRules> BlackViewRules { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingBlackViewRules : TeaModel {
                [NameInMap("ObjectMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingBlackViewRulesObjectMapping ObjectMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingBlackViewRulesObjectMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("SchemaMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingBlackViewRulesSchemaMapping SchemaMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingBlackViewRulesSchemaMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingDatabases> Databases { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingDatabases : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificTables> SpecificTables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificTablesAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificViews> SpecificViews { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesSpecificViewsAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesTables> Tables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
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

                    [NameInMap("ObkvPartitionConfig")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesTablesObkvPartitionConfig ObkvPartitionConfig { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesTablesObkvPartitionConfig : TeaModel {
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

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesViews> Views { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesViewsAdbTableSchema : TeaModel {
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
            public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesBlack> DatabasesBlack { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlack : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificTables> SpecificTables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificTablesAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificViews> SpecificViews { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackSpecificViewsAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackTables> Tables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackTablesAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackViews> Views { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingDatabasesBlackViewsAdbTableSchema : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>SPCEIFIC</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Schemas")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingSchemas> Schemas { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingSchemas : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificTables> SpecificTables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificTablesAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificViews> SpecificViews { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingSchemasSpecificViewsAdbTableSchema : TeaModel {
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
                public List<CreateProjectModifyRecordsRequestTransferMappingSchemasTables> Tables { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingSchemasTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingSchemasTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingSchemasTablesAdbTableSchema : TeaModel {
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

                    [NameInMap("ObkvPartitionConfig")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingSchemasTablesObkvPartitionConfig ObkvPartitionConfig { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingSchemasTablesObkvPartitionConfig : TeaModel {
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

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<CreateProjectModifyRecordsRequestTransferMappingSchemasViews> Views { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingSchemasViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateProjectModifyRecordsRequestTransferMappingSchemasViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateProjectModifyRecordsRequestTransferMappingSchemasViewsAdbTableSchema : TeaModel {
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

            [NameInMap("TableAndViewBlackList")]
            [Validation(Required=false)]
            public List<string> TableAndViewBlackList { get; set; }

            [NameInMap("TableAndViewWhiteList")]
            [Validation(Required=false)]
            public List<string> TableAndViewWhiteList { get; set; }

            [NameInMap("WhiteTableRules")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingWhiteTableRules> WhiteTableRules { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingWhiteTableRules : TeaModel {
                [NameInMap("ObjectMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingWhiteTableRulesObjectMapping ObjectMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingWhiteTableRulesObjectMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("SchemaMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingWhiteTableRulesSchemaMapping SchemaMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingWhiteTableRulesSchemaMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("WhiteViewRules")]
            [Validation(Required=false)]
            public List<CreateProjectModifyRecordsRequestTransferMappingWhiteViewRules> WhiteViewRules { get; set; }
            public class CreateProjectModifyRecordsRequestTransferMappingWhiteViewRules : TeaModel {
                [NameInMap("ObjectMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingWhiteViewRulesObjectMapping ObjectMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingWhiteViewRulesObjectMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("SchemaMapping")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestTransferMappingWhiteViewRulesSchemaMapping SchemaMapping { get; set; }
                public class CreateProjectModifyRecordsRequestTransferMappingWhiteViewRulesSchemaMapping : TeaModel {
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

    }

}
