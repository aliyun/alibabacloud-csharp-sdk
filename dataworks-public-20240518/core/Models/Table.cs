// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The information about the business metadata that is related to DataWorks, including the usage notes, tags, categories, ancestor tasks, and extended information.</para>
        /// </summary>
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public TableBusinessMetadata BusinessMetadata { get; set; }
        public class TableBusinessMetadata : TeaModel {
            /// <summary>
            /// <para>The categories.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<List<TableBusinessMetadataCategories>> Categories { get; set; }
            public class TableBusinessMetadataCategories : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CATEGORY.456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parent category ID. You can leave this parameter empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CATEGORY.123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            /// <summary>
            /// <para>The extended information. Only MaxCompute tables supports this parameter.</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public TableBusinessMetadataExtension Extension { get; set; }
            public class TableBusinessMetadataExtension : TeaModel {
                /// <summary>
                /// <para>The type of the environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod</description></item>
                /// <item><description>Dev</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The number of times the table is added to favorites.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FavorCount")]
                [Validation(Required=false)]
                public long? FavorCount { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The number of times the table is read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReadCount")]
                [Validation(Required=false)]
                public long? ReadCount { get; set; }

                /// <summary>
                /// <para>The number of times the table is viewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public long? ViewCount { get; set; }

            }

            /// <summary>
            /// <para>The usage notes.</para>
            /// </summary>
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataTags> Tags { get; set; }
            public class TableBusinessMetadataTags : TeaModel {
                /// <summary>
                /// <para>The tag key. You cannot leave this parameter empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. You can leave this parameter empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_value</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ancestor tasks.</para>
            /// </summary>
            [NameInMap("UpstreamTasks")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataUpstreamTasks> UpstreamTasks { get; set; }
            public class TableBusinessMetadataUpstreamTasks : TeaModel {
                /// <summary>
                /// <para>The ancestor task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ancestor task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The comments.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The table ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The common format of this parameter is <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}:${Schema name}:${Table name}</c>. If a level does not exist, specify an empty string as a placeholder.</para>
        /// <remarks>
        /// <para> For MaxCompute and DLF tables, specify an empty string at the Instance ID level as a placeholder. For MaxCompute tables, specify a MaxCompute project name at the Database name level. If the three-layer model is enabled for your MaxCompute project, you must specify a schema name at the Schema name level. Otherwise, you can specify an empty string at the Schema name level as a placeholder.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For StarRocks tables, specify a catalog name at the Catalog identifier level. For DLF tables, specify a catalog ID at the Catalog identifier level. Other types of tables do not support the Catalog identifier level, and you can specify an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>You can configure this parameter in one of the following formats based on your table type:</para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: the ID of an instance. If the related data source is added to DataWorks in Alibaba Cloud instance mode, you must configure this parameter.\
        /// <c>encoded_jdbc_url</c>: the JDBC connection string that is URL-encoded. If the related data source is added to DataWorks in connection string mode, you must configure this parameter.\
        /// <c>catalog_id</c>: the ID of a DLF catalog.\
        /// <c>project_name</c>: the name of a MaxCompute project.\
        /// <c>database_name</c>: the name of a database.\
        /// <c>schema_name</c>: the name of a schema. For a MaxCompute table, this parameter is required only if the three-layer model is enabled for the MaxCompute project to which the table belongs. If the schema feature is not enabled for the MaxCompute project, specify an empty string for this parameter as a placeholder.\
        /// <c>table_name</c>: the name of a table.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456XXX::test_project::test_tbl
        /// dlf-table:123456XXX:test_catalog:test_db::test_tbl
        /// hms-table:c-abc123xxx::test_db::test_tbl
        /// holo-table:h-abc123xxx::test_db:test_schema:test_tbl</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The modification time. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of a parent metadata entity. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <list type="bullet">
        /// <item><description>For data source types that support schemas, such as <c>MaxCompute, Hologres, PostgreSQL, SQL Server, HybridDB for PostgreSQL, and Oracle</c>, the <c>ParentMetaEntityId</c> parameter specifies the schema of the database to which the table belongs. In this case, the common format of this parameter is <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}:${Schema name}</c>. If a level does not exist, leave the level empty. For a MaxCompute data table, you must make sure that the three-layer model is enabled for the MaxCompute project to which the table belongs.</description></item>
        /// <item><description>For other data source types that do not support schemas, the <c>ParentMetaEntityId</c> parameter specifies the database to which the table belongs. In this case, the common format of this parameter is <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}</c>. If a level does not exist, leave the level empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For MaxCompute and DLF tables, specify an empty string at the Instance ID level as a placeholder. For MaxCompute tables, specify a MaxCompute project name at the Database name level.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For StarRocks tables, specify a catalog name at the Catalog identifier level. For DLF tables, specify a catalog ID at the Catalog identifier level. Other types of tables do not support the Catalog identifier level, and you can specify an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>You can configure this parameter in one of the following formats based on your table type:</para>
        /// <para><c>maxcompute-project:::project_name</c></para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (Three-layer model enabled for the MaxCompute project)</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>hms-database:instance_id::database_name</c></para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: the ID of an instance. If the related data source is added to DataWorks in Alibaba Cloud instance mode, you must configure this parameter.\
        /// <c>encoded_jdbc_url</c>: the JDBC connection string that is URL-encoded. If the related data source is added to DataWorks in connection string mode, you must configure this parameter.\
        /// <c>catalog_id</c>: the ID of a DLF catalog.\
        /// <c>project_name</c>: the name of a MaxCompute project.\
        /// <c>database_name</c>: the name of a database.\
        /// <c>schema_name</c>: the name of a schema.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-schema:123456XXX::test_project_with_schema:default
        /// maxcompute-project:123456XXX::test_project_without_schema
        /// dlf-database:123456XXX:test_catalog:test_db
        /// hms-database:c-abc123xxx::test_db
        /// holo-schema:h-abc123xxx::test_db:test_schema</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The partition keys. If the table is a non-partitioned table, leave this parameter empty.</para>
        /// </summary>
        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        /// <summary>
        /// <para>The table type. The value of this parameter is related to the type of metadata crawler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <para>The technical metadata.</para>
        /// </summary>
        [NameInMap("TechnicalMetadata")]
        [Validation(Required=false)]
        public TableTechnicalMetadata TechnicalMetadata { get; set; }
        public class TableTechnicalMetadata : TeaModel {
            /// <summary>
            /// <para>Specifies whether the table is a compressed table. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Compressed")]
            [Validation(Required=false)]
            public bool? Compressed { get; set; }

            /// <summary>
            /// <para>The input format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat</para>
            /// </summary>
            [NameInMap("InputFormat")]
            [Validation(Required=false)]
            public string InputFormat { get; set; }

            /// <summary>
            /// <para>The storage location of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test_tbl</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The output format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetOutputFormat</para>
            /// </summary>
            [NameInMap("OutputFormat")]
            [Validation(Required=false)]
            public string OutputFormat { get; set; }

            /// <summary>
            /// <para>The table owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The information about parameters.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <para>The implementation class of SerDe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org.apache.hadoop.hive.ql.io.parquet.serde.ParquetHiveSerDe</para>
            /// </summary>
            [NameInMap("SerializationLibrary")]
            [Validation(Required=false)]
            public string SerializationLibrary { get; set; }

        }

    }

}
