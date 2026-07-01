// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The creation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDatasetRequestCreateCommand CreateCommand { get; set; }
        public class CreateDatasetRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The dataset content type. Valid values: GENERAL, TEXT, AUDIO, VIDEO, IMAGE, TABLE, INDEX.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The data domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78201</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试数据集</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory (obtained from the file service by using the fileId).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("DirName")]
            [Validation(Required=false)]
            public string DirName { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7255018404650688</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The metastore type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTGRESQL</para>
            /// </summary>
            [NameInMap("MetadataStorageType")]
            [Validation(Required=false)]
            public string MetadataStorageType { get; set; }

            /// <summary>
            /// <para>The dataset name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of owner IDs, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000913</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The dataset scenarios. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OFFLINE: offline. This is the default value.</description></item>
            /// <item><description>REALTIME: real-time.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The dataset type. Valid values: FILE, TABLE, HYBRID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number. If not specified, the default version V1 is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The version configuration.</para>
            /// </summary>
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public CreateDatasetRequestCreateCommandVersionConfig VersionConfig { get; set; }
            public class CreateDatasetRequestCreateCommandVersionConfig : TeaModel {
                /// <summary>
                /// <para>The file storage configuration.</para>
                /// </summary>
                [NameInMap("FileStorageConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestCreateCommandVersionConfigFileStorageConfig FileStorageConfig { get; set; }
                public class CreateDatasetRequestCreateCommandVersionConfigFileStorageConfig : TeaModel {
                    /// <summary>
                    /// <para>The data source ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7445343860022804608</para>
                    /// </summary>
                    [NameInMap("DataSourceId")]
                    [Validation(Required=false)]
                    public string DataSourceId { get; set; }

                    /// <summary>
                    /// <para>The data source name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试数据源</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <para>The development path (not required for basic projects).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("DevPath")]
                    [Validation(Required=false)]
                    public string DevPath { get; set; }

                    /// <summary>
                    /// <para>The mount path.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/var/run/openresty/cache/corp</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The production path.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("ProdPath")]
                    [Validation(Required=false)]
                    public string ProdPath { get; set; }

                }

                /// <summary>
                /// <para>The metastore configuration.</para>
                /// </summary>
                [NameInMap("MetadataStorageConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfig MetadataStorageConfig { get; set; }
                public class CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfig : TeaModel {
                    /// <summary>
                    /// <para>The data source ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7429133693081710272</para>
                    /// </summary>
                    [NameInMap("DataSourceId")]
                    [Validation(Required=false)]
                    public string DataSourceId { get; set; }

                    /// <summary>
                    /// <para>The data source name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试数据源</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <para>The development database/schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("DevSchema")]
                    [Validation(Required=false)]
                    public string DevSchema { get; set; }

                    /// <summary>
                    /// <para>The metadata storage mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CREATE: create a new table.</description></item>
                    /// <item><description>EXISTING: use an existing table.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE</para>
                    /// </summary>
                    [NameInMap("MetadataStorageMode")]
                    [Validation(Required=false)]
                    public string MetadataStorageMode { get; set; }

                    /// <summary>
                    /// <para>The metastore type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MILVUS</para>
                    /// </summary>
                    [NameInMap("MetadataStorageType")]
                    [Validation(Required=false)]
                    public string MetadataStorageType { get; set; }

                    /// <summary>
                    /// <para>The production database/schema.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("ProdSchema")]
                    [Validation(Required=false)]
                    public string ProdSchema { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>s_crm_all_plt_jala_shop</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The table schema.</para>
                    /// </summary>
                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchema TableSchema { get; set; }
                    public class CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchema : TeaModel {
                        /// <summary>
                        /// <para>The column list.</para>
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchemaColumns> Columns { get; set; }
                        public class CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <para>The field comment.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>primary key</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <para>The array element subtype. Valid only when type is set to ARRAY.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>INT64</para>
                            /// </summary>
                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public string ElementType { get; set; }

                            /// <summary>
                            /// <para>The maximum capacity of the array. Valid only when type is set to ARRAY. Default value: 4096.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>35</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para>The field name.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the field is a primary key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para>The field type.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>int8</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the field is a URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public bool? Url { get; set; }

                            /// <summary>
                            /// <para>The vector index configuration.</para>
                            /// </summary>
                            [NameInMap("VectorIndexConfig")]
                            [Validation(Required=false)]
                            public CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class CreateDatasetRequestCreateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>The vector dimensions.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>instance:mongodb</para>
                                /// </summary>
                                [NameInMap("Dimension")]
                                [Validation(Required=false)]
                                public long? Dimension { get; set; }

                                /// <summary>
                                /// <para>The embedding model.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MultiModal-Embedding</para>
                                /// </summary>
                                [NameInMap("EmbeddingModel")]
                                [Validation(Required=false)]
                                public string EmbeddingModel { get; set; }

                                /// <summary>
                                /// <para>The index build parameters. Different parameters are required based on the indexType. For example, HNSW requires {M:30, efConstruction:360} and IVF_FLAT requires {nlist:128}.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{M:30, efConstruction:360}</para>
                                /// </summary>
                                [NameInMap("IndexParams")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> IndexParams { get; set; }

                                /// <summary>
                                /// <para>The index type. PostgreSQL supports IVFFlat and HNSW. Milvus supports all types.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AUTOINDEX</para>
                                /// </summary>
                                [NameInMap("IndexType")]
                                [Validation(Required=false)]
                                public string IndexType { get; set; }

                                /// <summary>
                                /// <para>The similarity type. Default value: COSINE. Valid values: COSINE, L2, IP.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>COSINE</para>
                                /// </summary>
                                [NameInMap("SimilarityType")]
                                [Validation(Required=false)]
                                public string SimilarityType { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The real-time meta table configuration. Takes effect when metadataStorageType is set to STREAM_TABLE.</para>
                /// </summary>
                [NameInMap("RealtimeMetaTableConfig")]
                [Validation(Required=false)]
                public CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfig RealtimeMetaTableConfig { get; set; }
                public class CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfig : TeaModel {
                    /// <summary>
                    /// <para>The meta table data source type (only KAFKA is supported in this version).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KAFKA</para>
                    /// </summary>
                    [NameInMap("DatasourceType")]
                    [Validation(Required=false)]
                    public string DatasourceType { get; set; }

                    /// <summary>
                    /// <para>The meta table name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试元表</para>
                    /// </summary>
                    [NameInMap("MetaTableName")]
                    [Validation(Required=false)]
                    public string MetaTableName { get; set; }

                    /// <summary>
                    /// <para>The project ID of the meta table (cross-project supported).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7256391656294144</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The table schema.</para>
                    /// </summary>
                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchema TableSchema { get; set; }
                    public class CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchema : TeaModel {
                        /// <summary>
                        /// <para>The column list.</para>
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns> Columns { get; set; }
                        public class CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <para>The field comment.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>happen time</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <para>The array element subtype. Valid only when type is set to ARRAY.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>INT64</para>
                            /// </summary>
                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public string ElementType { get; set; }

                            /// <summary>
                            /// <para>The maximum capacity of the array. Valid only when type is set to ARRAY. Default value: 4096.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>35</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para>The field name.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>happen_time</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the field is a primary key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para>The field type.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>date</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the field is a URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public bool? Url { get; set; }

                            /// <summary>
                            /// <para>The vector index configuration. Configure this when the field type is FLOAT_VECTOR/FLOAT16_VECTOR/BFLOAT16_VECTOR to set the dimension, index type, and similarity.</para>
                            /// </summary>
                            [NameInMap("VectorIndexConfig")]
                            [Validation(Required=false)]
                            public CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class CreateDatasetRequestCreateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>The vector dimensions.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>instance:MySQL.monitor</para>
                                /// </summary>
                                [NameInMap("Dimension")]
                                [Validation(Required=false)]
                                public long? Dimension { get; set; }

                                /// <summary>
                                /// <para>The embedding model.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MultiModal-Embedding</para>
                                /// </summary>
                                [NameInMap("EmbeddingModel")]
                                [Validation(Required=false)]
                                public string EmbeddingModel { get; set; }

                                /// <summary>
                                /// <para>The index build parameters. Different parameters are required based on the indexType. For example, HNSW requires {M:30, efConstruction:360} and IVF_FLAT requires {nlist:128}.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{M:30, efConstruction:360}</para>
                                /// </summary>
                                [NameInMap("IndexParams")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> IndexParams { get; set; }

                                /// <summary>
                                /// <para>The index type. PostgreSQL supports IVFFlat and HNSW. Milvus supports all types.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AUTOINDEX</para>
                                /// </summary>
                                [NameInMap("IndexType")]
                                [Validation(Required=false)]
                                public string IndexType { get; set; }

                                /// <summary>
                                /// <para>The similarity type. Default value: COSINE. Valid values: COSINE, L2, IP.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>COSINE</para>
                                /// </summary>
                                [NameInMap("SimilarityType")]
                                [Validation(Required=false)]
                                public string SimilarityType { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The version description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试数据集版本</para>
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7255013756724992</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
