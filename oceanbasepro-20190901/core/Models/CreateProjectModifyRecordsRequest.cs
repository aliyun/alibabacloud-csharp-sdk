// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectModifyRecordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<CreateProjectModifyRecordsRequestDatabases> Databases { get; set; }
        public class CreateProjectModifyRecordsRequestDatabases : TeaModel {
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
            public List<CreateProjectModifyRecordsRequestDatabasesSpecificTables> SpecificTables { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesSpecificTables : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesSpecificTablesAdbTableSchema : TeaModel {
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
            public List<CreateProjectModifyRecordsRequestDatabasesSpecificViews> SpecificViews { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesSpecificViews : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesSpecificViewsAdbTableSchema : TeaModel {
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
            public List<CreateProjectModifyRecordsRequestDatabasesTables> Tables { get; set; }
            public class CreateProjectModifyRecordsRequestDatabasesTables : TeaModel {
                [NameInMap("AdbTableSchema")]
                [Validation(Required=false)]
                public CreateProjectModifyRecordsRequestDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                public class CreateProjectModifyRecordsRequestDatabasesTablesAdbTableSchema : TeaModel {
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
