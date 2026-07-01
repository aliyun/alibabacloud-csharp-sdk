// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7273382541481536</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDatasetRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDatasetRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>78201</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试数据集</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7261110566632832</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7280832407583104</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>POSTGRESQL</para>
            /// </summary>
            [NameInMap("MetadataStorageType")]
            [Validation(Required=false)]
            public string MetadataStorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>audio_dataset</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300001391</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HYBRID</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public UpdateDatasetRequestUpdateCommandVersionConfig VersionConfig { get; set; }
            public class UpdateDatasetRequestUpdateCommandVersionConfig : TeaModel {
                [NameInMap("FileStorageConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestUpdateCommandVersionConfigFileStorageConfig FileStorageConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigFileStorageConfig : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7445343860022804608</para>
                    /// </summary>
                    [NameInMap("DataSourceId")]
                    [Validation(Required=false)]
                    public string DataSourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>测试数据源</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("DevPath")]
                    [Validation(Required=false)]
                    public string DevPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/var/run/openresty/cache/corp</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("ProdPath")]
                    [Validation(Required=false)]
                    public string ProdPath { get; set; }

                }

                [NameInMap("MetadataStorageConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfig MetadataStorageConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfig : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7429133693081710272</para>
                    /// </summary>
                    [NameInMap("DataSourceId")]
                    [Validation(Required=false)]
                    public string DataSourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>测试数据源</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("DevSchema")]
                    [Validation(Required=false)]
                    public string DevSchema { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATE</para>
                    /// </summary>
                    [NameInMap("MetadataStorageMode")]
                    [Validation(Required=false)]
                    public string MetadataStorageMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MILVUS</para>
                    /// </summary>
                    [NameInMap("MetadataStorageType")]
                    [Validation(Required=false)]
                    public string MetadataStorageType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTML正文提取/test423/</para>
                    /// </summary>
                    [NameInMap("ProdSchema")]
                    [Validation(Required=false)]
                    public string ProdSchema { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>s_crm_all_plt_jala_shop</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchema TableSchema { get; set; }
                    public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchema : TeaModel {
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumns> Columns { get; set; }
                        public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>primary key</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>INT64</para>
                            /// </summary>
                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public string ElementType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>250</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>id</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>int8</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public bool? Url { get; set; }

                            [NameInMap("VectorIndexConfig")]
                            [Validation(Required=false)]
                            public UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class UpdateDatasetRequestUpdateCommandVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>instance:mongodb</para>
                                /// </summary>
                                [NameInMap("Dimension")]
                                [Validation(Required=false)]
                                public long? Dimension { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MultiModal-Embedding</para>
                                /// </summary>
                                [NameInMap("EmbeddingModel")]
                                [Validation(Required=false)]
                                public string EmbeddingModel { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>{M:30, efConstruction:360}</para>
                                /// </summary>
                                [NameInMap("IndexParams")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> IndexParams { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AUTOINDEX</para>
                                /// </summary>
                                [NameInMap("IndexType")]
                                [Validation(Required=false)]
                                public string IndexType { get; set; }

                                /// <summary>
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

                [NameInMap("RealtimeMetaTableConfig")]
                [Validation(Required=false)]
                public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfig RealtimeMetaTableConfig { get; set; }
                public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfig : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KAFKA</para>
                    /// </summary>
                    [NameInMap("DatasourceType")]
                    [Validation(Required=false)]
                    public string DatasourceType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试元表</para>
                    /// </summary>
                    [NameInMap("MetaTableName")]
                    [Validation(Required=false)]
                    public string MetaTableName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7255013756724992</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchema TableSchema { get; set; }
                    public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchema : TeaModel {
                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public List<UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns> Columns { get; set; }
                        public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumns : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>happen time</para>
                            /// </summary>
                            [NameInMap("Comment")]
                            [Validation(Required=false)]
                            public string Comment { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>INT64</para>
                            /// </summary>
                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public string ElementType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("MaxCapacity")]
                            [Validation(Required=false)]
                            public int? MaxCapacity { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>happen_time</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Pk")]
                            [Validation(Required=false)]
                            public bool? Pk { get; set; }

                            /// <summary>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>date</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public bool? Url { get; set; }

                            [NameInMap("VectorIndexConfig")]
                            [Validation(Required=false)]
                            public UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                            public class UpdateDatasetRequestUpdateCommandVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>instance</para>
                                /// </summary>
                                [NameInMap("Dimension")]
                                [Validation(Required=false)]
                                public long? Dimension { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>multimodal-embedding-v1</para>
                                /// </summary>
                                [NameInMap("EmbeddingModel")]
                                [Validation(Required=false)]
                                public string EmbeddingModel { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>{M:30, efConstruction:360}</para>
                                /// </summary>
                                [NameInMap("IndexParams")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> IndexParams { get; set; }

                                /// <summary>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AUTOINDEX</para>
                                /// </summary>
                                [NameInMap("IndexType")]
                                [Validation(Required=false)]
                                public string IndexType { get; set; }

                                /// <summary>
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
                /// <b>Example:</b>
                /// <para>测试数据集版本</para>
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

        }

    }

}
