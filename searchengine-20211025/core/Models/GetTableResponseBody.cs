// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetTableResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableResponseBodyResult Result { get; set; }
        public class GetTableResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configurations about field processing.</para>
            /// </summary>
            [NameInMap("dataProcessConfig")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultDataProcessConfig> DataProcessConfig { get; set; }
            public class GetTableResponseBodyResultDataProcessConfig : TeaModel {
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
                /// <para>The method used to process the field. Valid values: copy and vectorize. A value of copy indicates that the value of the source field is copied to the destination field. A value of vectorize indicates that the value of the source field is vectorized by a vectorization model and the output vector is stored in the destination field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vectorize</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The information about the model.</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataProcessConfigParams Params { get; set; }
                public class GetTableResponseBodyResultDataProcessConfigParams : TeaModel {
                    /// <summary>
                    /// <para>The source of the data to be vectorized.</para>
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
                        /// <para>The Object Storage Service (OSS) endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ossEndpoint")]
                        [Validation(Required=false)]
                        public string OssEndpoint { get; set; }

                        /// <summary>
                        /// <para>The ID of the Alibaba Cloud account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>uid</para>
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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dataProcessorCount")]
            [Validation(Required=false)]
            public int? DataProcessorCount { get; set; }

            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public GetTableResponseBodyResultDataSource DataSource { get; set; }
            public class GetTableResponseBodyResultDataSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

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
                    /// <b>Example:</b>
                    /// <para>heytea-ops-oss</para>
                    /// </summary>
                    [NameInMap("bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>namespace</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/opensearch_index_data/sift_oss_test.data</para>
                    /// </summary>
                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ds=20220808</para>
                    /// </summary>
                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vendor/sebastian/comparator/src/exceptions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dp_pdm_marketing_prod</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_add</para>
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715160176</para>
                /// </summary>
                [NameInMap("dataTimeSec")]
                [Validation(Required=false)]
                public int? DataTimeSec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The field. The value is a key-value pair in which the key indicates the field name and value indicates the field type.</para>
            /// </summary>
            [NameInMap("fieldSchema")]
            [Validation(Required=false)]
            public Dictionary<string, string> FieldSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_oss</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("rawSchema")]
            [Validation(Required=false)]
            public string RawSchema { get; set; }

            /// <summary>
            /// <para>The state of the index table. Valid values: NEW, PUBLISH, IN_USE, NOT_USE, STOP_USE, RESTORE_USE, and FAIL. After an index is created in an OpenSearch Retrieval Engine Edition instance, the index enters the IN_USE state. If the first full index fails to be created in an OpenSearch Vector Search Edition instance of the new version, the index is in the FAIL state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN_USE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The index schema.</para>
            /// </summary>
            [NameInMap("vectorIndex")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultVectorIndex> VectorIndex { get; set; }
            public class GetTableResponseBodyResultVectorIndex : TeaModel {
                /// <summary>
                /// <para>The configurations of the index schema.</para>
                /// </summary>
                [NameInMap("advanceParams")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultVectorIndexAdvanceParams AdvanceParams { get; set; }
                public class GetTableResponseBodyResultVectorIndexAdvanceParams : TeaModel {
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
                    /// <para>The minimum number of retrieved candidate sets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("minScanDocCnt")]
                    [Validation(Required=false)]
                    public string MinScanDocCnt { get; set; }

                    /// <summary>
                    /// <para>The index retrieval parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("searchIndexParams")]
                    [Validation(Required=false)]
                    public string SearchIndexParams { get; set; }

                }

                /// <summary>
                /// <para>The dimension of the vector.</para>
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
                /// <para>The name of the index schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_odps</para>
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
                /// <para>The field that stores the indexes of the elements in sparse vectors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sparse_indices</para>
                /// </summary>
                [NameInMap("sparseIndexField")]
                [Validation(Required=false)]
                public string SparseIndexField { get; set; }

                /// <summary>
                /// <para>The field that stores the elements in sparse vectors.</para>
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
                /// <para>The vector retrieval algorithm.</para>
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
