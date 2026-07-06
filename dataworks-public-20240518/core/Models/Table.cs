// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The business metadata related to DataWorks, including usage instructions, tags, categories, upstream production nodes, and extended information.</para>
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
                /// <para>The parent category ID. This parameter can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CATEGORY.123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

            }

            /// <summary>
            /// <para>The custom attribute values, where key is the custom attribute identifier and value is the list of attribute values.</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The extension information. Currently only supported for MaxCompute type.</para>
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
                /// <para>The favorite count.</para>
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
                /// <para>The read count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReadCount")]
                [Validation(Required=false)]
                public long? ReadCount { get; set; }

                /// <summary>
                /// <para>The view count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ViewCount")]
                [Validation(Required=false)]
                public long? ViewCount { get; set; }

            }

            /// <summary>
            /// <para>The usage instructions.</para>
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
            /// <para>The list of upstream nodes.</para>
            /// </summary>
            [NameInMap("UpstreamTasks")]
            [Validation(Required=false)]
            public List<TableBusinessMetadataUpstreamTasks> UpstreamTasks { get; set; }
            public class TableBusinessMetadataUpstreamTasks : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The node name.</para>
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
        /// <para>测试表</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time, in millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <para>The format is <c>${EntityType}:${instance ID or encoded URL}:${DataFolderIdentity}:${DatabaseName}:${PatternName}:${TableName}</c>. Use an empty character as a placeholder for levels that do not exist.</para>
        /// <remarks>
        /// <para>For maxcompute and dlf types, use an empty string as a placeholder for the instance ID. For the maxcompute type, the database name is the MaxCompute project name. Projects with the three-layer model enabled require a schema name. For projects without the three-layer model enabled, use an empty string as a placeholder for the schema name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For the starrocks type, the data catalog identifier is the catalog name. For the dlf type, the data catalog identifier is the catalog ID. Other types do not support the catalog level. Use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following examples show the ID formats for common types:</para>
        /// <para><c>maxcompute-table:::project_name:[schema_name]:table_name</c></para>
        /// <para><c>dlf-table::catalog_id:database_name::table_name</c></para>
        /// <para><c>hms-table:instance_id::database_name::table_name</c></para>
        /// <para><c>holo-table:instance_id::database_name:schema_name:table_name</c></para>
        /// <para><c>mysql-table:(instance_id|encoded_jdbc_url)::database_name::table_name</c></para>
        /// <remarks>
        /// <para>Where<br><c>instance_id</c>: The instance ID. This is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This is required when the data source is registered by using a connection string.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name. For the maxcompute type, this is required only when the three-layer model is enabled for the project. If the three-layer model is not enabled, use an empty string as a placeholder.<br><c>table_name</c>: The table name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The modification time, in millisecond-level timestamp.</para>
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
        /// <para>The parent-level metadata entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>For types that support schemas (<c>maxcompute/holo/postgresql/sqlserver/hybriddb_for_postgresql/oracle, where the maxcompute type requires the Layer 3 model to be enabled for the project</c>), ParentMetaEntityId is the database pattern to which the table belongs. The format is <c>${EntityType}:${instance ID or encoded URL}:${DataFolderIdentity}:${DatabaseName}:${PatternName}</c>. Use an empty character as a placeholder for levels that do not exist.</para>
        /// </description></item>
        /// <item><description><para>For other types, ParentMetaEntityId is the database to which the table belongs. The format is <c>${EntityType}:${instance ID or encoded URL}:${DataFolderIdentity}:${DatabaseName}</c>. Use an empty character as a placeholder for levels that do not exist.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For maxcompute and dlf types, use an empty string as a placeholder for the instance ID. For the maxcompute type, the database name is the MaxCompute project name.</para>
        /// </remarks>
        /// <remarks>
        /// <para>For the starrocks type, the data catalog identifier is the catalog name. For the dlf type, the data catalog identifier is the catalog ID. Other types do not support the catalog level. Use an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>The following examples show the ParentMetaEntityId formats for common types:</para>
        /// <para><c>maxcompute-project:::project_name</c></para>
        /// <para><c>maxcompute-schema:::project_name:schema_name</c> (only when the three-layer model is enabled for the project)</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>hms-database:instance_id::database_name</c></para>
        /// <para><c>holo-schema:instance_id::database_name:schema_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>Where<br><c>instance_id</c>: The instance ID. This is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. This is required when the data source is registered by using a connection string.<br><c>catalog_id</c>: The DLF catalog ID.<br><c>project_name</c>: The MaxCompute project name.<br><c>database_name</c>: The database name.<br><c>schema_name</c>: The schema name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-database::catalog_id:database_name</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The list of partition keys. This is empty for non-partitioned tables.</para>
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
            /// <para>The class used by SerDe.</para>
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
