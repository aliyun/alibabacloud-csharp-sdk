// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectModifyRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact the administrator.</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
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
                public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTables> SpecificTables { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

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

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificTablesColumns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>comments</para>
                        /// </summary>
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>col_name</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FLOAT</para>
                        /// </summary>
                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>64</para>
                        /// </summary>
                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>utf16</para>
                        /// </summary>
                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_name</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>INT8</para>
                        /// </summary>
                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DATABASE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                    /// <para>mapped_name</para>
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
                    /// <para>id&lt;3</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

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

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesSpecificViewsColumns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>comments</para>
                        /// </summary>
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>col_name</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FLOAT</para>
                        /// </summary>
                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>64</para>
                        /// </summary>
                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>utf16</para>
                        /// </summary>
                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_name</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>INT8</para>
                        /// </summary>
                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DATABASE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                    /// <para>mapped_name</para>
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
                    /// <para>id &lt; 1</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

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

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesTablesColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesTablesColumns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>comments</para>
                        /// </summary>
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>col_name</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FLOAT</para>
                        /// </summary>
                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>64</para>
                        /// </summary>
                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>utf8</para>
                        /// </summary>
                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_col</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>INT8</para>
                        /// </summary>
                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DATABASE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                    /// <para>mapped_name</para>
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
                    /// <para>id &lt; 1</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

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

                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<ListProjectModifyRecordsResponseBodyDataDatabasesViewsColumns> Columns { get; set; }
                    public class ListProjectModifyRecordsResponseBodyDataDatabasesViewsColumns : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>comments</para>
                        /// </summary>
                        [NameInMap("ColumnComment")]
                        [Validation(Required=false)]
                        public string ColumnComment { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PRI</para>
                        /// </summary>
                        [NameInMap("ColumnKey")]
                        [Validation(Required=false)]
                        public string ColumnKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>col_name</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>FLOAT</para>
                        /// </summary>
                        [NameInMap("ColumnType")]
                        [Validation(Required=false)]
                        public string ColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataLength")]
                        [Validation(Required=false)]
                        public long? DataLength { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>64</para>
                        /// </summary>
                        [NameInMap("DataPrecision")]
                        [Validation(Required=false)]
                        public int? DataPrecision { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DataScale")]
                        [Validation(Required=false)]
                        public int? DataScale { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>utf16</para>
                        /// </summary>
                        [NameInMap("Encoding")]
                        [Validation(Required=false)]
                        public string Encoding { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsGenerateField")]
                        [Validation(Required=false)]
                        public bool? IsGenerateField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_name</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Nullable")]
                        [Validation(Required=false)]
                        public bool? Nullable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("RawColumnType")]
                        [Validation(Required=false)]
                        public string RawColumnType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>INT8</para>
                        /// </summary>
                        [NameInMap("RecordFieldType")]
                        [Validation(Required=false)]
                        public string RecordFieldType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DATABASE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

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
                    /// <para>mapped_view</para>
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

            }

            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public ListProjectModifyRecordsResponseBodyDataErrorDetail ErrorDetail { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataErrorDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>INNER_ERROR</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ExtraContext")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtraContext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A system error occurred.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("MessageMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> MessageMcmsContext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("MessageMcmsKey")]
                [Validation(Required=false)]
                public string MessageMcmsKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Proposal")]
                [Validation(Required=false)]
                public string Proposal { get; set; }

                [NameInMap("ProposalMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> ProposalMcmsContext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ProposalMcmsKey")]
                [Validation(Required=false)]
                public string ProposalMcmsKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ReasonMcmsContext")]
                [Validation(Required=false)]
                public Dictionary<string, string> ReasonMcmsContext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ReasonMcmsKey")]
                [Validation(Required=false)]
                public string ReasonMcmsKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("UpstreamErrorDetail")]
                [Validation(Required=false)]
                public object UpstreamErrorDetail { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T06:26:15</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>344000005</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>schema_name</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("TablesBlack")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTablesBlack> TablesBlack { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoTablesBlack : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>schema_name</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("Views")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViews> Views { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViews : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>view_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>schema_name</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                [NameInMap("ViewsBlack")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViewsBlack> ViewsBlack { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataMigrationObjectsInfoViewsBlack : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>view_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>schema_name</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dest_name</para>
                    /// </summary>
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_name</para>
                    /// </summary>
                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_schema</para>
                    /// </summary>
                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_table</para>
                    /// </summary>
                    [NameInMap("SourceTable")]
                    [Validation(Required=false)]
                    public string SourceTable { get; set; }

                }

                [NameInMap("SchemaMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoSchemaMappings> SchemaMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoSchemaMappings : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_schema</para>
                    /// </summary>
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_name</para>
                    /// </summary>
                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                }

                [NameInMap("TableMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoTableMappings> TableMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoTableMappings : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dest_name</para>
                    /// </summary>
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_name</para>
                    /// </summary>
                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_schema</para>
                    /// </summary>
                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                }

                [NameInMap("ViewMappings")]
                [Validation(Required=false)]
                public List<ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoViewMappings> ViewMappings { get; set; }
                public class ListProjectModifyRecordsResponseBodyDataOmsProjectMappingInfoViewMappings : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dest_name</para>
                    /// </summary>
                    [NameInMap("DestName")]
                    [Validation(Required=false)]
                    public string DestName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_name</para>
                    /// </summary>
                    [NameInMap("SourceName")]
                    [Validation(Required=false)]
                    public string SourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>schema_name</para>
                    /// </summary>
                    [NameInMap("SourceSchema")]
                    [Validation(Required=false)]
                    public string SourceSchema { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>np_598qm***</para>
            /// </summary>
            [NameInMap("SubProjectId")]
            [Validation(Required=false)]
            public string SubProjectId { get; set; }

            [NameInMap("TableEtlList")]
            [Validation(Required=false)]
            public List<ListProjectModifyRecordsResponseBodyDataTableEtlList> TableEtlList { get; set; }
            public class ListProjectModifyRecordsResponseBodyDataTableEtlList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>db_name</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dest_db</para>
                /// </summary>
                [NameInMap("DestDatabase")]
                [Validation(Required=false)]
                public string DestDatabase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dest_name</para>
                /// </summary>
                [NameInMap("DestName")]
                [Validation(Required=false)]
                public string DestName { get; set; }

                [NameInMap("FilterColumns")]
                [Validation(Required=false)]
                public List<string> FilterColumns { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("LogicTableId")]
                [Validation(Required=false)]
                public string LogicTableId { get; set; }

                [NameInMap("ShardColumns")]
                [Validation(Required=false)]
                public List<string> ShardColumns { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SourceEndpointId")]
                [Validation(Required=false)]
                public string SourceEndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table_name</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tenant_name</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id&gt;1</para>
                /// </summary>
                [NameInMap("WhereClause")]
                [Validation(Required=false)]
                public string WhereClause { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INCREASE_OBJECT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("UpdateRequestId")]
            [Validation(Required=false)]
            public long? UpdateRequestId { get; set; }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListProjectModifyRecordsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListProjectModifyRecordsResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INNER_ERROR</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A system error occurred.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Contact the administrator.</para>
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A system error occurred.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
