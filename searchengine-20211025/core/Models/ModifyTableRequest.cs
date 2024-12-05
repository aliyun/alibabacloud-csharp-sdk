// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyTableRequest : TeaModel {
        /// <summary>
        /// <para>The configurations about field processing.</para>
        /// </summary>
        [NameInMap("dataProcessConfig")]
        [Validation(Required=false)]
        public List<ModifyTableRequestDataProcessConfig> DataProcessConfig { get; set; }
        public class ModifyTableRequestDataProcessConfig : TeaModel {
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
            /// <para>The method used to process the field. Valid values: copy and vectorize. A value of copy specifies that the value of the source field is copied to the destination field. A value of vectorize specifies that the value of the source field is vectorized by a vectorization model and the output vector is stored in the destination field.</para>
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
            public ModifyTableRequestDataProcessConfigParams Params { get; set; }
            public class ModifyTableRequestDataProcessConfigParams : TeaModel {
                /// <summary>
                /// <para>The source of the data to be vectorized.</para>
                /// </summary>
                [NameInMap("srcFieldConfig")]
                [Validation(Required=false)]
                public ModifyTableRequestDataProcessConfigParamsSrcFieldConfig SrcFieldConfig { get; set; }
                public class ModifyTableRequestDataProcessConfigParamsSrcFieldConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ossBucket")]
                    [Validation(Required=false)]
                    public string OssBucket { get; set; }

                    /// <summary>
                    /// <para>The OSS endpoint.</para>
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
        /// <para>The configurations of the data source.</para>
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public ModifyTableRequestDataSource DataSource { get; set; }
        public class ModifyTableRequestDataSource : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically rebuild the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// <para>The configurations of the data source.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyTableRequestDataSourceConfig Config { get; set; }
            public class ModifyTableRequestDataSourceConfig : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AK</para>
                /// </summary>
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The AccessKey secret of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AS</para>
                /// </summary>
                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antsys-shujiang-osstest</para>
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
                /// <para>The endpoint of the MaxCompute data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The path of the Object Storage Service (OSS) object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://opensearch</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The partition in the MaxCompute table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20231220</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project that is used as the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yw_dw_rpt</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute table that is used as the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>behavior</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The start timestamp from which incremental data is retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715160176</para>
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

        }

        /// <summary>
        /// <para>The fields.</para>
        /// </summary>
        [NameInMap("fieldSchema")]
        [Validation(Required=false)]
        public Dictionary<string, string> FieldSchema { get; set; }

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
        /// <para>The instance schema. If this parameter is specified, the parameters about the index are not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("rawSchema")]
        [Validation(Required=false)]
        public string RawSchema { get; set; }

        /// <summary>
        /// <para>The index schema.</para>
        /// </summary>
        [NameInMap("vectorIndex")]
        [Validation(Required=false)]
        public List<ModifyTableRequestVectorIndex> VectorIndex { get; set; }
        public class ModifyTableRequestVectorIndex : TeaModel {
            /// <summary>
            /// <para>The configurations of the index schema.</para>
            /// </summary>
            [NameInMap("advanceParams")]
            [Validation(Required=false)]
            public ModifyTableRequestVectorIndexAdvanceParams AdvanceParams { get; set; }
            public class ModifyTableRequestVectorIndexAdvanceParams : TeaModel {
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
            /// <para>test_api</para>
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

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. The system only checks the validity of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
