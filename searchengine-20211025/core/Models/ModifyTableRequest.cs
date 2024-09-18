// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyTableRequest : TeaModel {
        /// <summary>
        /// The configurations about field processing.
        /// </summary>
        [NameInMap("dataProcessConfig")]
        [Validation(Required=false)]
        public List<ModifyTableRequestDataProcessConfig> DataProcessConfig { get; set; }
        public class ModifyTableRequestDataProcessConfig : TeaModel {
            /// <summary>
            /// The destination field.
            /// </summary>
            [NameInMap("dstField")]
            [Validation(Required=false)]
            public string DstField { get; set; }

            /// <summary>
            /// The method used to process the field. Valid values: copy and vectorize. A value of copy specifies that the value of the source field is copied to the destination field. A value of vectorize specifies that the value of the source field is vectorized by a vectorization model and the output vector is stored in the destination field.
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The information about the model.
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public ModifyTableRequestDataProcessConfigParams Params { get; set; }
            public class ModifyTableRequestDataProcessConfigParams : TeaModel {
                /// <summary>
                /// The source of the data to be vectorized.
                /// </summary>
                [NameInMap("srcFieldConfig")]
                [Validation(Required=false)]
                public ModifyTableRequestDataProcessConfigParamsSrcFieldConfig SrcFieldConfig { get; set; }
                public class ModifyTableRequestDataProcessConfigParamsSrcFieldConfig : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket.
                    /// </summary>
                    [NameInMap("ossBucket")]
                    [Validation(Required=false)]
                    public string OssBucket { get; set; }

                    /// <summary>
                    /// The OSS endpoint.
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

        /// <summary>
        /// The configurations of the data source.
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public ModifyTableRequestDataSource DataSource { get; set; }
        public class ModifyTableRequestDataSource : TeaModel {
            /// <summary>
            /// Specifies whether to automatically rebuild the index.
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// The configurations of the data source.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyTableRequestDataSourceConfig Config { get; set; }
            public class ModifyTableRequestDataSourceConfig : TeaModel {
                /// <summary>
                /// The AccessKey ID of the MaxCompute data source.
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// The AccessKey secret of the MaxCompute data source.
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// The name of the OSS bucket.
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The endpoint of the MaxCompute data source.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The path of the Object Storage Service (OSS) object.
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// The partition in the MaxCompute table.
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// The name of the MaxCompute project that is used as the data source.
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The name of the MaxCompute table that is used as the data source.
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The start timestamp from which incremental data is retrieved.
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

        }

        /// <summary>
        /// The fields.
        /// </summary>
        [NameInMap("fieldSchema")]
        [Validation(Required=false)]
        public Dictionary<string, string> FieldSchema { get; set; }

        /// <summary>
        /// The number of data shards.
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public int? PartitionCount { get; set; }

        /// <summary>
        /// The primary key field.
        /// </summary>
        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// The instance schema. If this parameter is specified, the parameters about the index are not required.
        /// </summary>
        [NameInMap("rawSchema")]
        [Validation(Required=false)]
        public string RawSchema { get; set; }

        /// <summary>
        /// The index schema.
        /// </summary>
        [NameInMap("vectorIndex")]
        [Validation(Required=false)]
        public List<ModifyTableRequestVectorIndex> VectorIndex { get; set; }
        public class ModifyTableRequestVectorIndex : TeaModel {
            /// <summary>
            /// The configurations of the index schema.
            /// </summary>
            [NameInMap("advanceParams")]
            [Validation(Required=false)]
            public ModifyTableRequestVectorIndexAdvanceParams AdvanceParams { get; set; }
            public class ModifyTableRequestVectorIndexAdvanceParams : TeaModel {
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

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. The system only checks the validity of the data source. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
