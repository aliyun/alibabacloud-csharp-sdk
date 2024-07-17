// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetTableResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableResponseBodyResult Result { get; set; }
        public class GetTableResponseBodyResult : TeaModel {
            /// <summary>
            /// The configurations about field processing.
            /// </summary>
            [NameInMap("dataProcessConfig")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultDataProcessConfig> DataProcessConfig { get; set; }
            public class GetTableResponseBodyResultDataProcessConfig : TeaModel {
                /// <summary>
                /// The destination field.
                /// </summary>
                [NameInMap("dstField")]
                [Validation(Required=false)]
                public string DstField { get; set; }

                /// <summary>
                /// The method used to process the field. Valid values: copy and vectorize. A value of copy indicates that the value of the source field is copied to the destination field. A value of vectorize indicates that the value of the source field is vectorized by a vectorization model and the output vector is stored in the destination field.
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The information about the model.
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataProcessConfigParams Params { get; set; }
                public class GetTableResponseBodyResultDataProcessConfigParams : TeaModel {
                    /// <summary>
                    /// The source of the data to be vectorized.
                    /// </summary>
                    [NameInMap("srcFieldConfig")]
                    [Validation(Required=false)]
                    public GetTableResponseBodyResultDataProcessConfigParamsSrcFieldConfig SrcFieldConfig { get; set; }
                    public class GetTableResponseBodyResultDataProcessConfigParamsSrcFieldConfig : TeaModel {
                        /// <summary>
                        /// OSS Bucket
                        /// </summary>
                        [NameInMap("ossBucket")]
                        [Validation(Required=false)]
                        public string OssBucket { get; set; }

                        /// <summary>
                        /// The Object Storage Service (OSS) endpoint.
                        /// </summary>
                        [NameInMap("ossEndpoint")]
                        [Validation(Required=false)]
                        public string OssEndpoint { get; set; }

                        /// <summary>
                        /// The ID of the Alibaba Cloud account.
                        /// </summary>
                        [NameInMap("uid")]
                        [Validation(Required=false)]
                        public string Uid { get; set; }

                    }

                    /// <summary>
                    /// The data type.
                    /// </summary>
                    [NameInMap("vectorModal")]
                    [Validation(Required=false)]
                    public string VectorModal { get; set; }

                    /// <summary>
                    /// The vectorization model.
                    /// </summary>
                    [NameInMap("vectorModel")]
                    [Validation(Required=false)]
                    public string VectorModel { get; set; }

                }

                /// <summary>
                /// The source field.
                /// </summary>
                [NameInMap("srcField")]
                [Validation(Required=false)]
                public string SrcField { get; set; }

            }

            [NameInMap("dataProcessorCount")]
            [Validation(Required=false)]
            public int? DataProcessorCount { get; set; }

            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public GetTableResponseBodyResultDataSource DataSource { get; set; }
            public class GetTableResponseBodyResultDataSource : TeaModel {
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                [NameInMap("config")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataSourceConfig Config { get; set; }
                public class GetTableResponseBodyResultDataSourceConfig : TeaModel {
                    /// <summary>
                    /// AK
                    /// </summary>
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// AS
                    /// </summary>
                    [NameInMap("accessSecret")]
                    [Validation(Required=false)]
                    public string AccessSecret { get; set; }

                    [NameInMap("bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                [NameInMap("dataTimeSec")]
                [Validation(Required=false)]
                public int? DataTimeSec { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The field. The value is a key-value pair in which the key indicates the field name and value indicates the field type.
            /// </summary>
            [NameInMap("fieldSchema")]
            [Validation(Required=false)]
            public Dictionary<string, string> FieldSchema { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            [NameInMap("rawSchema")]
            [Validation(Required=false)]
            public string RawSchema { get; set; }

            /// <summary>
            /// The state of the index table. Valid values: NEW, PUBLISH, IN_USE, NOT_USE, STOP_USE, RESTORE_USE, and FAIL. After an index is created in an OpenSearch Retrieval Engine Edition instance, the index enters the IN_USE state. If the first full index fails to be created in an OpenSearch Vector Search Edition instance of the new version, the index is in the FAIL state.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The index schema.
            /// </summary>
            [NameInMap("vectorIndex")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultVectorIndex> VectorIndex { get; set; }
            public class GetTableResponseBodyResultVectorIndex : TeaModel {
                /// <summary>
                /// The configurations of the index schema.
                /// </summary>
                [NameInMap("advanceParams")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultVectorIndexAdvanceParams AdvanceParams { get; set; }
                public class GetTableResponseBodyResultVectorIndexAdvanceParams : TeaModel {
                    /// <summary>
                    /// The index building parameters.
                    /// </summary>
                    [NameInMap("buildIndexParams")]
                    [Validation(Required=false)]
                    public string BuildIndexParams { get; set; }

                    /// <summary>
                    /// The threshold for linear building.
                    /// </summary>
                    [NameInMap("linearBuildThreshold")]
                    [Validation(Required=false)]
                    public string LinearBuildThreshold { get; set; }

                    /// <summary>
                    /// The minimum number of retrieved candidate sets.
                    /// </summary>
                    [NameInMap("minScanDocCnt")]
                    [Validation(Required=false)]
                    public string MinScanDocCnt { get; set; }

                    /// <summary>
                    /// The index retrieval parameters.
                    /// </summary>
                    [NameInMap("searchIndexParams")]
                    [Validation(Required=false)]
                    public string SearchIndexParams { get; set; }

                }

                /// <summary>
                /// The dimension of the vector.
                /// </summary>
                [NameInMap("dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// The distance type.
                /// </summary>
                [NameInMap("distanceType")]
                [Validation(Required=false)]
                public string DistanceType { get; set; }

                /// <summary>
                /// The name of the index schema.
                /// </summary>
                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// The namespace field.
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The field that stores the indexes of the elements in sparse vectors.
                /// </summary>
                [NameInMap("sparseIndexField")]
                [Validation(Required=false)]
                public string SparseIndexField { get; set; }

                /// <summary>
                /// The field that stores the elements in sparse vectors.
                /// </summary>
                [NameInMap("sparseValueField")]
                [Validation(Required=false)]
                public string SparseValueField { get; set; }

                /// <summary>
                /// The vector field.
                /// </summary>
                [NameInMap("vectorField")]
                [Validation(Required=false)]
                public string VectorField { get; set; }

                /// <summary>
                /// The vector retrieval algorithm.
                /// </summary>
                [NameInMap("vectorIndexType")]
                [Validation(Required=false)]
                public string VectorIndexType { get; set; }

            }

        }

    }

}
