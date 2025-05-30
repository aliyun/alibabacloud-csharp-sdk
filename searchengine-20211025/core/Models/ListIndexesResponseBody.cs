// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FB0325E-8C37-5525-96AC-0333523170A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of indexes.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListIndexesResponseBodyResult> Result { get; set; }
        public class ListIndexesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The index schema, which is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;summarys&quot;:{&quot;parameter&quot;:{&quot;file_compressor&quot;:&quot;zstd&quot;},&quot;summary_fields&quot;:[&quot;id&quot;]},&quot;file_compress&quot;:[{&quot;name&quot;:&quot;file_compressor&quot;,&quot;type&quot;:&quot;zstd&quot;},{&quot;name&quot;:&quot;no_compressor&quot;,&quot;type&quot;:&quot;&quot;}],&quot;indexs&quot;:[{&quot;index_fields&quot;:&quot;name&quot;,&quot;index_name&quot;:&quot;ids&quot;,&quot;index_type&quot;:&quot;STRING&quot;},{&quot;has_primary_key_attribute&quot;:true,&quot;index_fields&quot;:&quot;id&quot;,&quot;is_primary_key_sorted&quot;:false,&quot;index_name&quot;:&quot;id&quot;,&quot;index_type&quot;:&quot;PRIMARYKEY64&quot;}],&quot;attributes&quot;:[{&quot;file_compress&quot;:&quot;no_compressor&quot;,&quot;field_name&quot;:&quot;id&quot;}],&quot;fields&quot;:[{&quot;user_defined_param&quot;:{},&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;id&quot;},{&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;name&quot;}],&quot;table_name&quot;:&quot;api&quot;}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-7mz2kvu2c01_table4</para>
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The information about the data source.</para>
            /// </summary>
            [NameInMap("dataSourceInfo")]
            [Validation(Required=false)]
            public ListIndexesResponseBodyResultDataSourceInfo DataSourceInfo { get; set; }
            public class ListIndexesResponseBodyResultDataSourceInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic full indexing feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                /// <summary>
                /// <para>The configuration of MaxCompute data sources.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoConfig Config { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoConfig : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey ID of the MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root</para>
                    /// </summary>
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>The AccessKey secret of the MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root123</para>
                    /// </summary>
                    [NameInMap("accessSecret")]
                    [Validation(Required=false)]
                    public string AccessSecret { get; set; }

                    /// <summary>
                    /// <para>The OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha3test-oss</para>
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

                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The namespace. This parameter is applicable to the SARO data source used in the intranet of Alibaba Group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEST_dump_demo_sj_na61hunbu2_share_holo</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The Object Storage Service (OSS) path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test_opensearch/sift_oss_test.data</para>
                    /// </summary>
                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    /// <summary>
                    /// <para>The shard name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds=12345</para>
                    /// </summary>
                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    /// <summary>
                    /// <para>The file path in the Apsara File Storage for HDFS file system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://test_opensearch/sift_oss_test.data">http://test_opensearch/sift_oss_test.data</a></para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The name of the MaxCompute project that is used as the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tisplus_dev</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>The name of the MaxCompute table that is used as the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dump_odps_demo</para>
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// <para>The data center in which the data source is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>index1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of resources used for data update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("processPartitionCount")]
                [Validation(Required=false)]
                public int? ProcessPartitionCount { get; set; }

                /// <summary>
                /// <para>The configurations of the SARO data source.</para>
                /// </summary>
                [NameInMap("saroConfig")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoSaroConfig SaroConfig { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoSaroConfig : TeaModel {
                    /// <summary>
                    /// <para>The namespace of the SARO data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEST_dump_demo_sj_na61hunbu2_share_holo</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the SARO table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dump_odps_demo</para>
                    /// </summary>
                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The type of the data source. Valid values: odps, swift, saro, oss, and unKnow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The deployment name of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The time when full data in the index was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-05 10:40:38</para>
            /// </summary>
            [NameInMap("fullUpdateTime")]
            [Validation(Required=false)]
            public string FullUpdateTime { get; set; }

            /// <summary>
            /// <para>The full version of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688523414</para>
            /// </summary>
            [NameInMap("fullVersion")]
            [Validation(Required=false)]
            public long? FullVersion { get; set; }

            /// <summary>
            /// <para>The time when incremental data in the index was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-05 10:58:33</para>
            /// </summary>
            [NameInMap("incUpdateTime")]
            [Validation(Required=false)]
            public string IncUpdateTime { get; set; }

            /// <summary>
            /// <para>The index size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4689</para>
            /// </summary>
            [NameInMap("indexSize")]
            [Validation(Required=false)]
            public long? IndexSize { get; set; }

            /// <summary>
            /// <para>The index ststus. Valid values: NEW and PUBLISH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("indexStatus")]
            [Validation(Required=false)]
            public string IndexStatus { get; set; }

            /// <summary>
            /// <para>The index name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The index versions.</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyResultVersions> Versions { get; set; }
            public class ListIndexesResponseBodyResultVersions : TeaModel {
                /// <summary>
                /// <para>The description of the index version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>close alarm, by 3.9.2 hotfix workflow</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The files.</para>
                /// </summary>
                [NameInMap("files")]
                [Validation(Required=false)]
                public List<ListIndexesResponseBodyResultVersionsFiles> Files { get; set; }
                public class ListIndexesResponseBodyResultVersionsFiles : TeaModel {
                    /// <summary>
                    /// <para>The full path of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot; &quot;</para>
                    /// </summary>
                    [NameInMap("fullPathName")]
                    [Validation(Required=false)]
                    public string FullPathName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the file is a directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public bool? IsDir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the file is a template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("isTemplate")]
                    [Validation(Required=false)]
                    public bool? IsTemplate { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha-cn-7mz2iv7sq01_qrs</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The name of the index version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-7pp2ngv4s02_qrs</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the index version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NEW: The index version is created.</description></item>
                /// <item><description>PUBLISH: The index version is normal.</description></item>
                /// <item><description>IN_USE: The index version is in use.</description></item>
                /// <item><description>NOT_USE: The index version is not used.</description></item>
                /// <item><description>STOP_USE: The index version is being stopped.</description></item>
                /// <item><description>RESTORE_USE: The index version is being restored.</description></item>
                /// <item><description>FAIL: The index version failed to be created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the index version was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot; &quot;</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the index version. If the index version is modified, the returned value is null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("versionId")]
                [Validation(Required=false)]
                public int? VersionId { get; set; }

            }

        }

    }

}
