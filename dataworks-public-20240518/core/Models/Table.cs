// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The business metadata. This parameter is specific to DataWorks and includes instructions, tags, categories, upstream tasks, and extended information.</para>
        /// </summary>
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public TableBusinessMetadata BusinessMetadata { get; set; }
        public class TableBusinessMetadata : TeaModel {
            /// <summary>
            /// <para>The list of categories to which the table belongs.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>测试类目</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parent category\&quot;s ID. This can be an empty string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CATEGORY.123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            /// <summary>
            /// <para>A map of custom attribute identifiers to lists of their corresponding values.</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>Extended information. This parameter is supported only for the MaxCompute data type.</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public TableBusinessMetadataExtension Extension { get; set; }
            public class TableBusinessMetadataExtension : TeaModel {
                /// <summary>
                /// <para>The environment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Prod: The production environment.</para>
                /// </description></item>
                /// <item><description><para>Dev: The development environment.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The number of times the table was favorited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FavorCount")]
                [Validation(Required=false)]
                public long? FavorCount { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The number of reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReadCount")]
                [Validation(Required=false)]
                public long? ReadCount { get; set; }

                /// <summary>
                /// <para>The number of views.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public long? ViewCount { get; set; }

            }

            /// <summary>
            /// <para>The instructions for use.</para>
            /// 
            /// <b>Example:</b>
            /// <h2>使用说明</h2>
            /// </summary>
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataTags> Tags { get; set; }
            public class TableBusinessMetadataTags : TeaModel {
                /// <summary>
                /// <para>The tag key. This value cannot be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. This can be an empty string.</para>
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
            /// <para>The list of upstream tasks.</para>
            /// </summary>
            [NameInMap("UpstreamTasks")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataUpstreamTasks> UpstreamTasks { get; set; }
            public class TableBusinessMetadataUpstreamTasks : TeaModel {
                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The task name.</para>
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
        /// <para>The comment on the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试表</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The table creation time, provided as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the entity. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${instance ID or escaped URL}:${data catalog identifier}:${database name}:${schema name}:${table name}</c>. Use an empty string as a placeholder for any non-existent level.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF data types, use an empty string as a placeholder for the instance ID. For MaxCompute, the database name is the MaxCompute project name. You must provide a schema name for projects where the three-layer model is enabled. If the model is not enabled, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks data types, the data catalog identifier is the catalog name. For DLF data types, the data catalog identifier is the catalog ID. Other data types do not support the catalog level. For these types, use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following are the ID formats for several common data types:</para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>Placeholder descriptions:<br>
        /// <c>instance_id</c>: The instance ID. This is required when the data source is registered in instance mode.<br>
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This is required when the data source is registered by using a connection string.<br>
        /// <c>catalog_id</c>: The DLF catalog ID.<br>
        /// <c>project_name</c>: The MaxCompute project name.<br>
        /// <c>database_name</c>: The database name.<br>
        /// <c>schema_name</c>: The schema name. For the MaxCompute data type, this is required only if the project has the three-layer model enabled. Otherwise, use an empty string as a placeholder.<br>
        /// <c>table_name</c>: The table name.<br><br><br><br><br><br><br></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The time the table was last modified, provided as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the parent metadata entity. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>For data types that support schemas, such as <c>maxcompute/holo/postgresql/sqlserver/hybriddb_for_postgresql/oracle</c>, <c>ParentMetaEntityId</c> specifies the table\&quot;s database schema. For the MaxCompute data type, this applies only to MaxCompute projects with the three-layer model enabled. The format is <c>${EntityType}:${instance ID or escaped URL}:${data catalog identifier}:${database name}:${schema name}</c>. Use an empty string as a placeholder for any non-existent level.</para>
        /// </description></item>
        /// <item><description><para>For other data types, <c>ParentMetaEntityId</c> specifies the table\&quot;s database. The format is <c>${EntityType}:${instance ID or escaped URL}:${data catalog identifier}:${database name}</c>. Use an empty string as a placeholder for any non-existent level.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For MaxCompute and DLF data types, use an empty string as a placeholder for the instance ID. For the MaxCompute data type, the database name is the MaxCompute project name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For StarRocks data types, the data catalog identifier is the catalog name. For DLF data types, the data catalog identifier is the catalog ID. Other data types do not support the catalog level. For these types, use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following are the formats of <c>ParentMetaEntityId</c> for several common data types:</para>
        /// <para><c>maxcompute-project:::project_name</c></para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (Only for projects with the three-layer model enabled)</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>hms-database:instance_id::database_name</c></para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>Placeholder descriptions:<br>
        /// <c>instance_id</c>: The instance ID. This is required when the data source is registered in instance mode.<br>
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This is required when the data source is registered by using a connection string.<br>
        /// <c>catalog_id</c>: The DLF catalog ID.<br>
        /// <c>project_name</c>: The MaxCompute project name.<br>
        /// <c>database_name</c>: The database name.<br>
        /// <c>schema_name</c>: The schema name.<br><br><br><br><br><br></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-database::catalog_id:database_name</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The list of partition keys. This parameter is empty for non-partitioned tables.</para>
        /// </summary>
        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        /// <summary>
        /// <para>The table type. The value depends on the type of metadata collector.</para>
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
            /// <para>Indicates whether the table is compressed.</para>
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
            /// <para>The storage location.</para>
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
            /// <para>The parameter information.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <para>The class used by the serializer/deserializer (SerDe).</para>
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
