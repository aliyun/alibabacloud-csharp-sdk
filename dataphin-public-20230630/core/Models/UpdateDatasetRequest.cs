// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDatasetRequest : TeaModel {
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
        /// <para>7273382541481536</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The update request struct.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDatasetRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDatasetRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para><b>The content type.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The subject area ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78201</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <para><b>The description.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>Test dataset.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The file ID (the file ID at creation time).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7261110566632832</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The dataset ID (business primary key).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7280832407583104</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para><b>The metastore type.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTGRESQL</para>
            /// </summary>
            [NameInMap("MetadataStorageType")]
            [Validation(Required=false)]
            public string MetadataStorageType { get; set; }

            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio_dataset</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of owner IDs, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001391</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para><b>Scenarios:</b> <c>OFFLINE</c> (offline, default) / <c>REALTIME</c> (real-time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para><b>The storage type.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The dataset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The dataset version configuration.</para>
            /// </summary>
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public UpdateDatasetRequestUpdateCommandVersionConfig VersionConfig { get; set; }
            public class UpdateDatasetRequestUpdateCommandVersionConfig : TeaModel {
                /// <summary>
                /// <para>The file storage configuration.</para>
                /// </summary>
                [NameInMap("FileStorageConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestUpdateCommandVersionConfigFileStorageConfig FileStorageConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigFileStorageConfig : TeaModel {
                    /// <summary>
                    /// <para><b>The data source ID.</b></para>
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
                    /// <para>Test data source.</para>
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
                public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfig MetadataStorageConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfig : TeaModel {
                    /// <summary>
                    /// <para><b>The data source ID.</b></para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7429133693081710272</para>
                    /// </summary>
                    [NameInMap("DataSourceId")]
                    [Validation(Required=false)]
                    public string DataSourceId { get; set; }

                    /// <summary>
                    /// <para><b>The data source name.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test data source.</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <para><b>The development database/schema.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("DevSchema")]
                    [Validation(Required=false)]
                    public string DevSchema { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to store metadata in a new table or an existing table.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE</para>
                    /// </summary>
                    [NameInMap("MetadataStorageMode")]
                    [Validation(Required=false)]
                    public string MetadataStorageMode { get; set; }

                    /// <summary>
                    /// <para><b>The metastore type.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MILVUS</para>
                    /// </summary>
                    [NameInMap("MetadataStorageType")]
                    [Validation(Required=false)]
                    public string MetadataStorageType { get; set; }

                    /// <summary>
                    /// <para><b>The production database/schema.</b></para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("ProdSchema")]
                    [Validation(Required=false)]
                    public string ProdSchema { get; set; }

                    /// <summary>
                    /// <para><b>The table name.</b></para>
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
                    public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchema TableSchema { get; set; }
                    public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchema : TeaModel {
                        /// <summary>
                        /// <para>The field list.</para>
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumns> Columns { get; set; }
                        public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <para>The field description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>primary key</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <para><b>The array element subtype. Valid only when type is set to ARRAY.</b></para>
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
                            /// <para>250</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para><b>The field name.</b></para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the field is a primary key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para><b>The field type.</b></para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>int8</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the field is a URL.</para>
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
                            public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>The embedding dimension.</para>
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
                                /// <para>The index build parameters. Different parameters are required based on the indexType. For example, HNSW requires {M:30, efConstruction:360}, and IVF_FLAT requires {nlist:128}.</para>
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
                                /// <para>The similarity type. Default value: COSINE. Valid values: COSINE, L2, and IP.</para>
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
                public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfig RealtimeMetaTableConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfig : TeaModel {
                    /// <summary>
                    /// <para>The meta table data source type (only KAFKA is supported in the current release).</para>
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
                    /// <para>Test meta table.</para>
                    /// </summary>
                    [NameInMap("MetaTableName")]
                    [Validation(Required=false)]
                    public string MetaTableName { get; set; }

                    /// <summary>
                    /// <para>The project ID to which the meta table belongs (cross-project access is supported).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7255013756724992</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The table schema.</para>
                    /// </summary>
                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchema TableSchema { get; set; }
                    public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchema : TeaModel {
                        /// <summary>
                        /// <para><b>The field list.</b></para>
                        /// </summary>
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns> Columns { get; set; }
                        public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <para>The field description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>happen time</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <para><b>The array element subtype. Valid only when type is set to ARRAY.</b></para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>INT64</para>
                            /// </summary>
                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public string ElementType { get; set; }

                            /// <summary>
                            /// <para><b>The maximum capacity of the array. This parameter is valid only when type is set to ARRAY. Default value: 4096.</b></para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para><b>The field name.</b></para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>happen_time</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the field is a primary key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para><b>The field type.</b></para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>date</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the field is a URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public bool? Url { get; set; }

                            /// <summary>
                            /// <para>The vector index configuration. Configure this parameter when the field type is FLOAT_VECTOR, FLOAT16_VECTOR, or BFLOAT16_VECTOR. This parameter is used to specify the dimensions, index type, and similarity metric.</para>
                            /// </summary>
                            [NameInMap("VectorIndexConfig")]
                            [Validation(Required=false)]
                            public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>The embedding dimension.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>instance</para>
                                /// </summary>
                                [NameInMap("Dimension")]
                                [Validation(Required=false)]
                                public long? Dimension { get; set; }

                                /// <summary>
                                /// <para>The embedding model.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>multimodal-embedding-v1</para>
                                /// </summary>
                                [NameInMap("EmbeddingModel")]
                                [Validation(Required=false)]
                                public string EmbeddingModel { get; set; }

                                /// <summary>
                                /// <para>The index build parameters. Different parameters are required based on the indexType. For example, HNSW requires {M:30, efConstruction:360}, and IVF_FLAT requires {nlist:128}.</para>
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
                                /// <para>The similarity type. Default value: COSINE. Valid values: COSINE, L2, and IP.</para>
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
                /// <para><b>Version description</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Test dataset version.</para>
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

        }

    }

}
