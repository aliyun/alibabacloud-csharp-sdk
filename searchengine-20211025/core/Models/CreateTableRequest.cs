// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateTableRequest : TeaModel {
        /// <summary>
        /// <para>The field processing configuration.</para>
        /// </summary>
        [NameInMap("dataProcessConfig")]
        [Validation(Required=false)]
        public List<CreateTableRequestDataProcessConfig> DataProcessConfig { get; set; }
        public class CreateTableRequestDataProcessConfig : TeaModel {
            /// <summary>
            /// <para>The destination field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source_image_vector</para>
            /// </summary>
            [NameInMap("dstField")]
            [Validation(Required=false)]
            public string DstField { get; set; }

            /// <summary>
            /// <para>The field processing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>copy: copies the source field to the destination field.</description></item>
            /// <item><description>vectorize: vectorizes the source field by using a model and stores the vector in the destination field.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vectorize</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The model configuration.</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public CreateTableRequestDataProcessConfigParams Params { get; set; }
            public class CreateTableRequestDataProcessConfigParams : TeaModel {
                /// <summary>
                /// <para>The vectorization information source.</para>
                /// </summary>
                [NameInMap("srcFieldConfig")]
                [Validation(Required=false)]
                public CreateTableRequestDataProcessConfigParamsSrcFieldConfig SrcFieldConfig { get; set; }
                public class CreateTableRequestDataProcessConfigParamsSrcFieldConfig : TeaModel {
                    /// <summary>
                    /// <para>OSSBucket</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-bucket</para>
                    /// </summary>
                    [NameInMap("ossBucket")]
                    [Validation(Required=false)]
                    public string OssBucket { get; set; }

                    /// <summary>
                    /// <para>The OSS region endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ossEndpoint")]
                    [Validation(Required=false)]
                    public string OssEndpoint { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud account ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1062017779051424</para>
                    /// </summary>
                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

                /// <summary>
                /// <para>The data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image</para>
                /// </summary>
                [NameInMap("vectorModal")]
                [Validation(Required=false)]
                public string VectorModal { get; set; }

                /// <summary>
                /// <para>The vectorization model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clip</para>
                /// </summary>
                [NameInMap("vectorModel")]
                [Validation(Required=false)]
                public string VectorModel { get; set; }

            }

            /// <summary>
            /// <para>The source field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source_image</para>
            /// </summary>
            [NameInMap("srcField")]
            [Validation(Required=false)]
            public string SrcField { get; set; }

        }

        /// <summary>
        /// <para>The number of data update resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dataProcessorCount")]
        [Validation(Required=false)]
        public int? DataProcessorCount { get; set; }

        /// <summary>
        /// <para>The datasource config.</para>
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public CreateTableRequestDataSource DataSource { get; set; }
        public class CreateTableRequestDataSource : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto index rebuilding is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// <para>The datasource config.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateTableRequestDataSourceConfig Config { get; set; }
            public class CreateTableRequestDataSourceConfig : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the ODPS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L***p</para>
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the ODPS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5**9a6</para>
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// <para>oss bucket</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The catalog name of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_catalog</para>
                /// </summary>
                [NameInMap("catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The database of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch_db</para>
                /// </summary>
                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The file format type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha3
                /// json</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The OSS data source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opensearch/test.txt</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The partition. This parameter is required when the data source is ODPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20220713</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The relative path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The project name of the ODPS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The table name of the ODPS or DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test56</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                /// <summary>
                /// <para>The table format of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>paimon
                /// lance
                /// object</para>
                /// </summary>
                [NameInMap("tableFormat")]
                [Validation(Required=false)]
                public string TableFormat { get; set; }

                /// <summary>
                /// <para>The tag of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The timestamp for incremental data tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715160176</para>
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// <para>The data source type. Only odps, swift, and oss are supported. Valid values: odps, swift, saro, oss, and unKnow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The field schema. The key is the field name.</para>
        /// </summary>
        [NameInMap("fieldSchema")]
        [Validation(Required=false)]
        public Dictionary<string, string> FieldSchema { get; set; }

        /// <summary>
        /// <para>The index name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_index_1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of data shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public int? PartitionCount { get; set; }

        /// <summary>
        /// <para>The primary key field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// <para>The raw schema. If you specify this parameter, the value is used directly as the HA3 schema structure without manual assembly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("rawSchema")]
        [Validation(Required=false)]
        public string RawSchema { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoSearcher</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The index structure.</para>
        /// </summary>
        [NameInMap("vectorIndex")]
        [Validation(Required=false)]
        public List<CreateTableRequestVectorIndex> VectorIndex { get; set; }
        public class CreateTableRequestVectorIndex : TeaModel {
            /// <summary>
            /// <para>The index structure configuration.</para>
            /// </summary>
            [NameInMap("advanceParams")]
            [Validation(Required=false)]
            public CreateTableRequestVectorIndexAdvanceParams AdvanceParams { get; set; }
            public class CreateTableRequestVectorIndexAdvanceParams : TeaModel {
                /// <summary>
                /// <para>The index building parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("buildIndexParams")]
                [Validation(Required=false)]
                public string BuildIndexParams { get; set; }

                /// <summary>
                /// <para>The threshold for linear building.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("linearBuildThreshold")]
                [Validation(Required=false)]
                public string LinearBuildThreshold { get; set; }

                /// <summary>
                /// <para>The minimum number of candidate documents for recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("minScanDocCnt")]
                [Validation(Required=false)]
                public string MinScanDocCnt { get; set; }

                /// <summary>
                /// <para>The index search parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("searchIndexParams")]
                [Validation(Required=false)]
                public string SearchIndexParams { get; set; }

            }

            /// <summary>
            /// <para>The vector dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// <para>The distance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SquaredEuclidean</para>
            /// </summary>
            [NameInMap("distanceType")]
            [Validation(Required=false)]
            public string DistanceType { get; set; }

            /// <summary>
            /// <para>The index structure name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_index</para>
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// <para>The namespace field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespace</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The sparse vector index field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sparse_indices</para>
            /// </summary>
            [NameInMap("sparseIndexField")]
            [Validation(Required=false)]
            public string SparseIndexField { get; set; }

            /// <summary>
            /// <para>The sparse vector value field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sparse_values</para>
            /// </summary>
            [NameInMap("sparseValueField")]
            [Validation(Required=false)]
            public string SparseValueField { get; set; }

            /// <summary>
            /// <para>The vector field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source_image_vector</para>
            /// </summary>
            [NameInMap("vectorField")]
            [Validation(Required=false)]
            public string VectorField { get; set; }

            /// <summary>
            /// <para>The vector index algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qc</para>
            /// </summary>
            [NameInMap("vectorIndexType")]
            [Validation(Required=false)]
            public string VectorIndexType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run (only validates whether the data source is valid). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run.</description></item>
        /// <item><description>false: does not perform a dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
