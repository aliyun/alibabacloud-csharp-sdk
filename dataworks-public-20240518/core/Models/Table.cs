// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The business metadata related to DataWorks, including the instructions, tags, categories, upstream output tasks, and extension information.</para>
        /// </summary>
        [NameInMap("BusinessMetadata")]
        [Validation(Required=false)]
        public TableBusinessMetadata BusinessMetadata { get; set; }
        public class TableBusinessMetadata : TeaModel {
            /// <summary>
            /// <para>The list of categories.</para>
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试类目</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parent category ID. This field can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CATEGORY.123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            /// <summary>
            /// <para>The custom attribute values, where the key is the custom attribute identifier and the value is the list of attribute values.</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The extension information. This parameter is currently supported only for the MaxCompute type.</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public TableBusinessMetadataExtension Extension { get; set; }
            public class TableBusinessMetadataExtension : TeaModel {
                /// <summary>
                /// <para>The environment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod: Production environment.</description></item>
                /// <item><description>Dev: Development environment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The number of times added to favorites.</para>
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
            /// <para>The instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <h2>Instructions</h2>
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
                /// <para>The tag key. This parameter cannot be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. This parameter can be empty.</para>
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
            /// <para>The list of upstream output tasks.</para>
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
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test table</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${Instance ID or URL-encoded URL}:${Data catalog identifier}:${Database name}:${Schema name}:${Table name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// <remarks>
        /// <para>For MaxCompute and DLF types, use an empty string as a placeholder for the instance ID. For the MaxCompute type, the database name is the MaxCompute project name. Projects with the three-level model enabled must provide the schema name. For projects without the three-level model enabled, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For the StarRocks type, the data catalog identifier is the catalog name. For the DLF type, the data catalog identifier is the catalog ID. Other types do not support the catalog level, and you can use an empty string as a placeholder. </para>
        /// </remarks>
        /// <para>The ID formats for several common types are as follows: </para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name. For the MaxCompute type, this is required only when the three-level model is enabled for the project. If it is not enabled, use an empty string as a placeholder.<br><c>table_name</c>: The table name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The modification time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
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
        /// <item><description><para>For types that support schemas (<c>maxcompute/holo/postgresql/sqlserver/hybriddb_for_postgresql/oracle</c>, where the MaxCompute type requires the three-level model to be enabled for the project), <c>ParentMetaEntityId</c> is the database schema to which the table belongs. The format is <c>${EntityType}:${Instance ID or URL-encoded URL}:${Data catalog identifier}:${Database name}:${Schema name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// </description></item>
        /// <item><description><para>For other types, <c>ParentMetaEntityId</c> is the database to which the table belongs. The format is <c>${EntityType}:${Instance ID or URL-encoded URL}:${Data catalog identifier}:${Database name}</c>. Use an empty string as a placeholder for non-existent levels.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For MaxCompute and DLF types, use an empty string as a placeholder for the instance ID. For the MaxCompute type, the database name is the MaxCompute project name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For the StarRocks type, the data catalog identifier is the catalog name. For the DLF type, the data catalog identifier is the catalog ID. Other types do not support the catalog level, and you can use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The <c>ParentMetaEntityId</c> formats for several common types are as follows:</para>
        /// <para><c>maxcompute-project:::project_name</c></para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (Only when the three-level model is enabled for the project)</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>hms-database:instance_id::database_name</c></para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name.</para>
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

        [NameInMap("StatisticsInfos")]
        [Validation(Required=false)]
        public Dictionary<string, string> StatisticsInfos { get; set; }

        /// <summary>
        /// <para>The table type. The valid values depend on the metadata collector type.</para>
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
            /// <para>Specifies whether the table is compressed.</para>
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
            /// <para>The owner.</para>
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
            /// <para>The class used for SerDe.</para>
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
