// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectModifyRecordsResponseBody : TeaModel {
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProjectModifyRecordsResponseBodyData> Data { get; set; }
        public class ListProjectModifyRecordsResponseBodyData : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<ListProjectModifyRecordsResponseBodyDataDatabases> Databases { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataDatabases : TeaModel {
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
                public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTables> SpecificTables { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesColumns : TeaModel {
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViews> SpecificViews { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsColumns : TeaModel {
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                public List<ListProjectModifyRecordsResponseBodyDataDatabasesTables> Tables { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataDatabasesTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public ListProjectModifyRecordsResponseBodyDataDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesTablesColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesTablesColumns : TeaModel {
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataDatabasesViews> Views { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataDatabasesViews : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public ListProjectModifyRecordsResponseBodyDataDatabasesViewsAdbTableSchema AdbTableSchema { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesViewsAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesViewsColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesViewsColumns : TeaModel {
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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

            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public ListProjectModifyRecordsResponseBodyDataErrorDetail ErrorDetail { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataErrorDetail : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ExtraContext")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtraContext { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("MessageMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> MessageMcmsContext { get; set; }

                [NameInMap("MessageMcmsKey")]
                [Validation(Required=false)]
                public string MessageMcmsKey { get; set; }

                [NameInMap("Proposal")]
                [Validation(Required=false)]
                public string Proposal { get; set; }

                [NameInMap("ProposalMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> ProposalMcmsContext { get; set; }

                [NameInMap("ProposalMcmsKey")]
                [Validation(Required=false)]
                public string ProposalMcmsKey { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ReasonMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> ReasonMcmsContext { get; set; }

                [NameInMap("ReasonMcmsKey")]
                [Validation(Required=false)]
                public string ReasonMcmsKey { get; set; }

                [NameInMap("UpstreamErrorDetail")]
                [Validation(Required=false)]
                public object UpstreamErrorDetail { get; set; }

            }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MergeRequestId")]
            [Validation(Required=false)]
            public long? MergeRequestId { get; set; }

            [NameInMap("MigrationObjectsInfo")]
            [Validation(Required=false)]
            public ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfo MigrationObjectsInfo { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfo : TeaModel {
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTables> Tables { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTables : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("TablesBlack")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTablesBlack> TablesBlack { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTablesBlack : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViews> Views { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViews : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("ViewsBlack")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViewsBlack> ViewsBlack { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViewsBlack : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("WildcardMode")]
                [Validation(Required=false)]
                public bool? WildcardMode { get; set; }

            }

            [NameInMap("OmsProjectMappingInfo")]
            [Validation(Required=false)]
            public ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfo OmsProjectMappingInfo { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfo : TeaModel {
                [NameInMap("ColumnMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoColumnMappings> ColumnMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoColumnMappings : TeaModel {
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                    [NameInMap("SourceTable")]
                    [Validation(Required=false)]
                    public string SourceTable { get; set; }

                }

                [NameInMap("SchemaMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoSchemaMappings> SchemaMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoSchemaMappings : TeaModel {
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                }

                [NameInMap("TableMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoTableMappings> TableMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoTableMappings : TeaModel {
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                }

                [NameInMap("ViewMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoViewMappings> ViewMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoViewMappings : TeaModel {
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubProjectId")]
            [Validation(Required=false)]
            public string SubProjectId { get; set; }

            [NameInMap("TableEtlList")]
            [Validation(Required=false)]
            public List<ListProjectModifyRecordsResponseBodyDataTableEtlList> TableEtlList { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataTableEtlList : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("DestDatabase")]
                [Validation(Required=false)]
                public string DestDatabase { get; set; }

                [NameInMap("DestName")]
                [Validation(Required=false)]
                public string DestName { get; set; }

                [NameInMap("FilterColumns")]
                [Validation(Required=false)]
                public List<string> FilterColumns { get; set; }

                [NameInMap("LogicTableId")]
                [Validation(Required=false)]
                public string LogicTableId { get; set; }

                [NameInMap("ShardColumns")]
                [Validation(Required=false)]
                public List<string> ShardColumns { get; set; }

                [NameInMap("SourceEndpointId")]
                [Validation(Required=false)]
                public string SourceEndpointId { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("WhereClause")]
                [Validation(Required=false)]
                public string WhereClause { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateRequestId")]
            [Validation(Required=false)]
            public long? UpdateRequestId { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListProjectModifyRecordsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListProjectModifyRecordsResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
