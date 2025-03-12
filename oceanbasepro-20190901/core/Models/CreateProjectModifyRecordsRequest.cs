// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectModifyRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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

    }

}
