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

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableResponseBodyResult Result { get; set; }
        public class GetTableResponseBodyResult : TeaModel {
            [NameInMap("dataProcessConfig")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultDataProcessConfig> DataProcessConfig { get; set; }
            public class GetTableResponseBodyResultDataProcessConfig : TeaModel {
                [NameInMap("dstField")]
                [Validation(Required=false)]
                public string DstField { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("params")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultDataProcessConfigParams Params { get; set; }
                public class GetTableResponseBodyResultDataProcessConfigParams : TeaModel {
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

                        [NameInMap("ossEndpoint")]
                        [Validation(Required=false)]
                        public string OssEndpoint { get; set; }

                        [NameInMap("uid")]
                        [Validation(Required=false)]
                        public string Uid { get; set; }

                    }

                    [NameInMap("vectorModal")]
                    [Validation(Required=false)]
                    public string VectorModal { get; set; }

                    [NameInMap("vectorModel")]
                    [Validation(Required=false)]
                    public string VectorModel { get; set; }

                }

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

            [NameInMap("vectorIndex")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyResultVectorIndex> VectorIndex { get; set; }
            public class GetTableResponseBodyResultVectorIndex : TeaModel {
                [NameInMap("advanceParams")]
                [Validation(Required=false)]
                public GetTableResponseBodyResultVectorIndexAdvanceParams AdvanceParams { get; set; }
                public class GetTableResponseBodyResultVectorIndexAdvanceParams : TeaModel {
                    [NameInMap("buildIndexParams")]
                    [Validation(Required=false)]
                    public string BuildIndexParams { get; set; }

                    [NameInMap("linearBuildThreshold")]
                    [Validation(Required=false)]
                    public string LinearBuildThreshold { get; set; }

                    [NameInMap("minScanDocCnt")]
                    [Validation(Required=false)]
                    public string MinScanDocCnt { get; set; }

                    [NameInMap("searchIndexParams")]
                    [Validation(Required=false)]
                    public string SearchIndexParams { get; set; }

                }

                [NameInMap("dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("distanceType")]
                [Validation(Required=false)]
                public string DistanceType { get; set; }

                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("sparseIndexField")]
                [Validation(Required=false)]
                public string SparseIndexField { get; set; }

                [NameInMap("sparseValueField")]
                [Validation(Required=false)]
                public string SparseValueField { get; set; }

                [NameInMap("vectorField")]
                [Validation(Required=false)]
                public string VectorField { get; set; }

                [NameInMap("vectorIndexType")]
                [Validation(Required=false)]
                public string VectorIndexType { get; set; }

            }

        }

    }

}
