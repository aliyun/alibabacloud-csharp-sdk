// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetTableResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response result</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableResponseBodyResult Result { get; set; }
        public class GetTableResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Field processing configuration</para>
            /// </summary>
            [NameInMap("dataProcessConfig")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultDataProcessConfig> DataProcessConfig { get; set; }
            public class GetTableResponseBodyResultDataProcessConfig : TeaModel {
                /// <summary>
                /// <para>Target field</para>
                /// 
                /// <b>Example:</b>
                /// <para>source_image_vector</para>
                /// </summary>
                [NameInMap("dstField")]
                [Validation(Required=false)]
                public string DstField { get; set; }

                /// <summary>
                /// <para>Field processing method (copy: copies the source field to the target field, vectorize: vectorizes the source field using a model and stores the vector in the target field)</para>
                /// 
                /// <b>Example:</b>
                /// <para>vectorize</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>Model configuration information</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataProcessConfigParams Params { get; set; }
                public class GetTableResponseBodyResultDataProcessConfigParams : TeaModel {
                    /// <summary>
                    /// <para>Vectorization information source</para>
                    /// </summary>
                    [NameInMap("srcFieldConfig")]
                    [Validation(Required=false)]
                    public GetTableResponseBodyResultDataProcessConfigParamsSrcFieldConfig SrcFieldConfig { get; set; }
                    public class GetTableResponseBodyResultDataProcessConfigParamsSrcFieldConfig : TeaModel {
                        /// <summary>
                        /// <para>OSS Bucket</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("ossBucket")]
                        [Validation(Required=false)]
                        public string OssBucket { get; set; }

                        /// <summary>
                        /// <para>OSS region endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ossEndpoint")]
                        [Validation(Required=false)]
                        public string OssEndpoint { get; set; }

                        /// <summary>
                        /// <para>Cloud account ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>uid</para>
                        /// </summary>
                        [NameInMap("uid")]
                        [Validation(Required=false)]
                        public string Uid { get; set; }

                    }

                    /// <summary>
                    /// <para>Data type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("vectorModal")]
                    [Validation(Required=false)]
                    public string VectorModal { get; set; }

                    /// <summary>
                    /// <para>Vectorization model</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>clip</para>
                    /// </summary>
                    [NameInMap("vectorModel")]
                    [Validation(Required=false)]
                    public string VectorModel { get; set; }

                }

                /// <summary>
                /// <para>Source field</para>
                /// 
                /// <b>Example:</b>
                /// <para>source_image</para>
                /// </summary>
                [NameInMap("srcField")]
                [Validation(Required=false)]
                public string SrcField { get; set; }

            }

            /// <summary>
            /// <para>Number of data update resources</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dataProcessorCount")]
            [Validation(Required=false)]
            public int? DataProcessorCount { get; set; }

            /// <summary>
            /// <para>Data source configuration</para>
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public GetTableResponseBodyResultDataSource DataSource { get; set; }
            public class GetTableResponseBodyResultDataSource : TeaModel {
                /// <summary>
                /// <para>Whether to automatically rebuild the index</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                /// <summary>
                /// <para>Data source configuration</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataSourceConfig Config { get; set; }
                public class GetTableResponseBodyResultDataSourceConfig : TeaModel {
                    /// <summary>
                    /// <para>AK</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ak</para>
                    /// </summary>
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>AS</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>as</para>
                    /// </summary>
                    [NameInMap("accessSecret")]
                    [Validation(Required=false)]
                    public string AccessSecret { get; set; }

                    /// <summary>
                    /// <para>OSS namespace</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>heytea-ops-oss</para>
                    /// </summary>
                    [NameInMap("bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>ODPS-related</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>saro-related</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>namespace</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>OSS file path</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/opensearch_index_data/sift_oss_test.data</para>
                    /// </summary>
                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    /// <summary>
                    /// <para>Partition information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds=20220808</para>
                    /// </summary>
                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    /// <summary>
                    /// <para>HDFS-related</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vendor/sebastian/comparator/src/exceptions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>ODPS data source project name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dp_pdm_marketing_prod</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>saro/ODPS data source table name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_add</para>
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// <para>Incremental data timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715160176</para>
                /// </summary>
                [NameInMap("dataTimeSec")]
                [Validation(Required=false)]
                public int? DataTimeSec { get; set; }

                /// <summary>
                /// <para>Data source type: only supports three types: odps, swift, and oss (odps, swift, saro, oss, unKnow)</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Field map collection, key: field name, value: field type</para>
            /// </summary>
            [NameInMap("fieldSchema")]
            [Validation(Required=false)]
            public Dictionary<string, string> FieldSchema { get; set; }

            /// <summary>
            /// <para>Index name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_oss</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Number of data shards</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

            /// <summary>
            /// <para>Primary key field</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <para>If the user provides rawSchema, it is used directly as the HA3 schema structure without manual assembly</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("rawSchema")]
            [Validation(Required=false)]
            public string RawSchema { get; set; }

            /// <summary>
            /// <para>Index table status (NEW, PUBLISH, IN_USE: normal status after the recall engine version is created successfully, NOT_USE, STOP_USE, RESTORE_USE, FAIL: status when a new version of the vector retrieval version fails to create an index for the first time)</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN_USE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Index structure</para>
            /// </summary>
            [NameInMap("vectorIndex")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultVectorIndex> VectorIndex { get; set; }
            public class GetTableResponseBodyResultVectorIndex : TeaModel {
                /// <summary>
                /// <para>Index structure configuration</para>
                /// </summary>
                [NameInMap("advanceParams")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultVectorIndexAdvanceParams AdvanceParams { get; set; }
                public class GetTableResponseBodyResultVectorIndexAdvanceParams : TeaModel {
                    /// <summary>
                    /// <para>Index building parameters</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;proxima.qc.builder.quantizer_class&quot;: &quot;Int8QuantizerConverter&quot;,
                    ///   &quot;proxima.qc.builder.quantize_by_centroid&quot;: true,
                    ///   &quot;proxima.qc.builder.optimizer_class&quot;: &quot;BruteForceBuilder&quot;,
                    ///   &quot;proxima.qc.builder.thread_count&quot;: 10,
                    ///   &quot;proxima.qc.builder.optimizer_params&quot;: {
                    ///     &quot;proxima.linear.builder.column_major_order&quot;: true
                    ///   },
                    ///   &quot;proxima.qc.builder.store_original_features&quot;: false,
                    ///   &quot;proxima.qc.builder.train_sample_count&quot;: 3000000,
                    ///   &quot;proxima.qc.builder.train_sample_ratio&quot;: 0.5
                    /// }</para>
                    /// </summary>
                    [NameInMap("buildIndexParams")]
                    [Validation(Required=false)]
                    public string BuildIndexParams { get; set; }

                    /// <summary>
                    /// <para>Linear build threshold</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("linearBuildThreshold")]
                    [Validation(Required=false)]
                    public string LinearBuildThreshold { get; set; }

                    /// <summary>
                    /// <para>Minimum number of recall candidates</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("minScanDocCnt")]
                    [Validation(Required=false)]
                    public string MinScanDocCnt { get; set; }

                    /// <summary>
                    /// <para>Index search parameters</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;proxima.qc.searcher.scan_ratio&quot;:0.01}</para>
                    /// </summary>
                    [NameInMap("searchIndexParams")]
                    [Validation(Required=false)]
                    public string SearchIndexParams { get; set; }

                }

                /// <summary>
                /// <para>Vector dimension</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <para>Distance type</para>
                /// 
                /// <b>Example:</b>
                /// <para>SquaredEuclidean</para>
                /// </summary>
                [NameInMap("distanceType")]
                [Validation(Required=false)]
                public string DistanceType { get; set; }

                /// <summary>
                /// <para>Index structure name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_odps</para>
                /// </summary>
                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// <para>Namespace field</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Sparse vector index field</para>
                /// 
                /// <b>Example:</b>
                /// <para>sparse_indices</para>
                /// </summary>
                [NameInMap("sparseIndexField")]
                [Validation(Required=false)]
                public string SparseIndexField { get; set; }

                /// <summary>
                /// <para>Sparse vector value field</para>
                /// 
                /// <b>Example:</b>
                /// <para>sparse_values</para>
                /// </summary>
                [NameInMap("sparseValueField")]
                [Validation(Required=false)]
                public string SparseValueField { get; set; }

                /// <summary>
                /// <para>Vector field</para>
                /// 
                /// <b>Example:</b>
                /// <para>source_image_vector</para>
                /// </summary>
                [NameInMap("vectorField")]
                [Validation(Required=false)]
                public string VectorField { get; set; }

                /// <summary>
                /// <para>Vector index algorithm</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qc</para>
                /// </summary>
                [NameInMap("vectorIndexType")]
                [Validation(Required=false)]
                public string VectorIndexType { get; set; }

            }

        }

    }

}
