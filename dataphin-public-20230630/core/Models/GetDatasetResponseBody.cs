// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDatasetResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dataset object.</para>
        /// </summary>
        [NameInMap("DatasetDTO")]
        [Validation(Required=false)]
        public GetDatasetResponseBodyDatasetDTO DatasetDTO { get; set; }
        public class GetDatasetResponseBodyDatasetDTO : TeaModel {
            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001391</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

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
            /// <para>The subject area name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>离线数据主题域</para>
            /// </summary>
            [NameInMap("DataCellName")]
            [Validation(Required=false)]
            public string DataCellName { get; set; }

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
            /// <para>The directory (retrieved from the file service by using the fileId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7255018404650688</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-28 10:03:49</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-28 10:03:49</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The dataset ID (business primary key).</para>
            /// 
            /// <b>Example:</b>
            /// <para>7255018404425088</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the development owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001391</para>
            /// </summary>
            [NameInMap("LockOwner")]
            [Validation(Required=false)]
            public string LockOwner { get; set; }

            /// <summary>
            /// <para>The display name of the development owner on the interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("LockOwnerName")]
            [Validation(Required=false)]
            public string LockOwnerName { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>audio_dataset</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of owners.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<GetDatasetResponseBodyDatasetDTOOwnerList> OwnerList { get; set; }
            public class GetDatasetResponseBodyDatasetDTOOwnerList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001391</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the project to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7255013756724992</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the project to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_tm</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The dataset scenarios. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OFFLINE: offline (default).</description></item>
            /// <item><description>REALTIME: real-time.</description></item>
            /// </list>
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
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001413</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

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
            /// <para>The list of versions.</para>
            /// </summary>
            [NameInMap("VersionList")]
            [Validation(Required=false)]
            public List<GetDatasetResponseBodyDatasetDTOVersionList> VersionList { get; set; }
            public class GetDatasetResponseBodyDatasetDTOVersionList : TeaModel {
                /// <summary>
                /// <para>The creator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The dataset version configuration.</para>
                /// </summary>
                [NameInMap("DataVersionConfig")]
                [Validation(Required=false)]
                public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfig DataVersionConfig { get; set; }
                public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfig : TeaModel {
                    /// <summary>
                    /// <para>The file storage configuration.</para>
                    /// </summary>
                    [NameInMap("FileStorageConfig")]
                    [Validation(Required=false)]
                    public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigFileStorageConfig FileStorageConfig { get; set; }
                    public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigFileStorageConfig : TeaModel {
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
                    public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfig MetadataStorageConfig { get; set; }
                    public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfig : TeaModel {
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
                        /// <para>The storage destination (new table or existing table).</para>
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
                        /// <para>The table schema configuration.</para>
                        /// </summary>
                        [NameInMap("TableSchema")]
                        [Validation(Required=false)]
                        public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchema TableSchema { get; set; }
                        public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchema : TeaModel {
                            /// <summary>
                            /// <para>The list of columns.</para>
                            /// </summary>
                            [NameInMap("Columns")]
                            [Validation(Required=false)]
                            public List<GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchemaColumns> Columns { get; set; }
                            public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchemaColumns : TeaModel {
                                /// <summary>
                                /// <para>The column comment.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>主键</para>
                                /// </summary>
                                [NameInMap("Comment")]
                                [Validation(Required=false)]
                                public string Comment { get; set; }

                                /// <summary>
                                /// <para>The array element subtype. This parameter is valid only when type is set to ARRAY.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>INT64</para>
                                /// </summary>
                                [NameInMap("ElementType")]
                                [Validation(Required=false)]
                                public string ElementType { get; set; }

                                /// <summary>
                                /// <para>The maximum array capacity. This parameter is valid only when type is set to ARRAY. Default value: 4096.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>35</para>
                                /// </summary>
                                [NameInMap("MaxCapacity")]
                                [Validation(Required=false)]
                                public int? MaxCapacity { get; set; }

                                /// <summary>
                                /// <para>The column name.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>id</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the column is a primary key.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Pk")]
                                [Validation(Required=false)]
                                public bool? Pk { get; set; }

                                /// <summary>
                                /// <para>The column type.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>int8</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the column is a URL.</para>
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
                                public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                                public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigMetadataStorageConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
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
                                    /// <para>The index build parameters. Different parameters are required depending on the index type. For example, HNSW requires {M:30, efConstruction:360}, and IVF_FLAT requires {nlist:128}.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>{M:30, efConstruction:360}</para>
                                    /// </summary>
                                    [NameInMap("IndexParams")]
                                    [Validation(Required=false)]
                                    public Dictionary<string, object> IndexParams { get; set; }

                                    /// <summary>
                                    /// <para>The index type. PG supports IVFFlat and HNSW. Milvus supports all types.</para>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>AUTOINDEX</para>
                                    /// </summary>
                                    [NameInMap("IndexType")]
                                    [Validation(Required=false)]
                                    public string IndexType { get; set; }

                                    /// <summary>
                                    /// <para>The similarity type. Default value: COSINE. COSINE corresponds to vector_cosine_ops, L2 corresponds to vector_l2_ops, and IP corresponds to vector_ip_ops.</para>
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
                    /// <para>The real-time meta table configuration. This parameter takes effect only when metadataStorageType is set to REALTIME_META_TABLE.</para>
                    /// </summary>
                    [NameInMap("RealtimeMetaTableConfig")]
                    [Validation(Required=false)]
                    public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfig RealtimeMetaTableConfig { get; set; }
                    public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfig : TeaModel {
                        /// <summary>
                        /// <para>The data source type of the meta table. Only KAFKA is supported in the current release.</para>
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
                        /// <para>The project ID to which the meta table belongs. Cross-project references are supported.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7255013756724992</para>
                        /// </summary>
                        [NameInMap("ProjectId")]
                        [Validation(Required=false)]
                        public long? ProjectId { get; set; }

                        /// <summary>
                        /// <para>The table schema configuration (reuses MetadataStorageConfigDTO.TableSchemaDTO).</para>
                        /// </summary>
                        [NameInMap("TableSchema")]
                        [Validation(Required=false)]
                        public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchema TableSchema { get; set; }
                        public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchema : TeaModel {
                            /// <summary>
                            /// <para>The list of columns.</para>
                            /// </summary>
                            [NameInMap("Columns")]
                            [Validation(Required=false)]
                            public List<GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchemaColumns> Columns { get; set; }
                            public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchemaColumns : TeaModel {
                                /// <summary>
                                /// <para>The column comment.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>录入时间</para>
                                /// </summary>
                                [NameInMap("Comment")]
                                [Validation(Required=false)]
                                public string Comment { get; set; }

                                /// <summary>
                                /// <para>The array element subtype.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>INT64</para>
                                /// </summary>
                                [NameInMap("ElementType")]
                                [Validation(Required=false)]
                                public string ElementType { get; set; }

                                /// <summary>
                                /// <para>The maximum array capacity.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>5</para>
                                /// </summary>
                                [NameInMap("MaxCapacity")]
                                [Validation(Required=false)]
                                public int? MaxCapacity { get; set; }

                                /// <summary>
                                /// <para>The column name.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>happen_time</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the column is a primary key.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Pk")]
                                [Validation(Required=false)]
                                public bool? Pk { get; set; }

                                /// <summary>
                                /// <para>The column type.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>date</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the column is a URL.</para>
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
                                public GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig VectorIndexConfig { get; set; }
                                public class GetDatasetResponseBodyDatasetDTOVersionListDataVersionConfigRealtimeMetaTableConfigTableSchemaColumnsVectorIndexConfig : TeaModel {
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
                                    /// <para>The index build parameters.</para>
                                    /// </summary>
                                    [NameInMap("IndexParams")]
                                    [Validation(Required=false)]
                                    public Dictionary<string, object> IndexParams { get; set; }

                                    /// <summary>
                                    /// <para>The index type.</para>
                                    /// <para>This parameter is required.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>AUTOINDEX</para>
                                    /// </summary>
                                    [NameInMap("IndexType")]
                                    [Validation(Required=false)]
                                    public string IndexType { get; set; }

                                    /// <summary>
                                    /// <para>The similarity type.</para>
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

                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7280832407583104</para>
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public long? DatasetId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-13T02:11:56Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1749450490000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7280840713415040</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
