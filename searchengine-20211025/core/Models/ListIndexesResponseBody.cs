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
        /// <para>The list of index details.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListIndexesResponseBodyResult> Result { get; set; }
        public class ListIndexesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The schema in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;summarys&quot;:{&quot;parameter&quot;:{&quot;file_compressor&quot;:&quot;zstd&quot;},&quot;summary_fields&quot;:[&quot;id&quot;]},&quot;file_compress&quot;:[{&quot;name&quot;:&quot;file_compressor&quot;,&quot;type&quot;:&quot;zstd&quot;},{&quot;name&quot;:&quot;no_compressor&quot;,&quot;type&quot;:&quot;&quot;}],&quot;indexs&quot;:[{&quot;index_fields&quot;:&quot;name&quot;,&quot;index_name&quot;:&quot;ids&quot;,&quot;index_type&quot;:&quot;STRING&quot;},{&quot;has_primary_key_attribute&quot;:true,&quot;index_fields&quot;:&quot;id&quot;,&quot;is_primary_key_sorted&quot;:false,&quot;index_name&quot;:&quot;id&quot;,&quot;index_type&quot;:&quot;PRIMARYKEY64&quot;}],&quot;attributes&quot;:[{&quot;file_compress&quot;:&quot;no_compressor&quot;,&quot;field_name&quot;:&quot;id&quot;}],&quot;fields&quot;:[{&quot;user_defined_param&quot;:{},&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;id&quot;},{&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;name&quot;}],&quot;table_name&quot;:&quot;api&quot;}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_test_api</para>
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
                /// <para>Indicates whether to automatically build a full index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoBuildIndex")]
                [Validation(Required=false)]
                public bool? AutoBuildIndex { get; set; }

                /// <summary>
                /// <para>The configurations of the MaxCompute data source.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoConfig Config { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoConfig : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey ID of the MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>L***p</para>
                    /// </summary>
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>The AccessKey secret of the MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5**9a6</para>
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

                    /// <summary>
                    /// <para>The ID of the data catalog for the DLF data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>clg-paimon-21cc136237a6457f8618f5f82d116d7e</para>
                    /// </summary>
                    [NameInMap("catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <para>The database name of the DLF data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dlf_test</para>
                    /// </summary>
                    [NameInMap("database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <para>Information about the MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>The file format for OSS.</para>
                    /// <list type="bullet">
                    /// <item><description><para>ha3</para>
                    /// </description></item>
                    /// <item><description><para>json</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ha3</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>Information about the saro data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEST_dump_demo_sj_na61hunbu2_share_holo</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>Information about the OSS data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test_opensearch/sift_oss_test.data</para>
                    /// </summary>
                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    /// <summary>
                    /// <para>The data partition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds=20231220</para>
                    /// </summary>
                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    /// <summary>
                    /// <para>Information about the Hadoop Distributed File System (HDFS) data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://test_opensearch/sift_oss_test.data">http://test_opensearch/sift_oss_test.data</a></para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The name of the MaxCompute project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tisplus_dev</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>Information about the saro or MaxCompute data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dump_odps_demo</para>
                    /// </summary>
                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                    /// <summary>
                    /// <para>The tag of the DLF data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_tag</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// <para>The offline deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc_hz_domain_2</para>
                /// </summary>
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-pl32rf0****_test_api</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of resources for data updates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("processPartitionCount")]
                [Validation(Required=false)]
                public int? ProcessPartitionCount { get; set; }

                /// <summary>
                /// <para>The configurations of the saro data source.</para>
                /// </summary>
                [NameInMap("saroConfig")]
                [Validation(Required=false)]
                public ListIndexesResponseBodyResultDataSourceInfoSaroConfig SaroConfig { get; set; }
                public class ListIndexesResponseBodyResultDataSourceInfoSaroConfig : TeaModel {
                    /// <summary>
                    /// <para>The namespace of the saro data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEST_dump_demo_sj_na61hunbu2_share_holo</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the saro data table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dump_odps_demo</para>
                    /// </summary>
                    [NameInMap("tableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The type of the data source. Valid values: odps (MaxCompute), swift, saro, oss (Object Storage Service), and unKnow.</para>
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
            /// <para>note</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The deployment name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The time when the full index was switched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-05 10:40:38</para>
            /// </summary>
            [NameInMap("fullUpdateTime")]
            [Validation(Required=false)]
            public string FullUpdateTime { get; set; }

            /// <summary>
            /// <para>The full version, which is the index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688523414</para>
            /// </summary>
            [NameInMap("fullVersion")]
            [Validation(Required=false)]
            public long? FullVersion { get; set; }

            /// <summary>
            /// <para>The time of the incremental update.</para>
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
            /// <para>NEW, PUBLISH</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISH</para>
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
            /// <para>The number of data shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The list of versions.</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyResultVersions> Versions { get; set; }
            public class ListIndexesResponseBodyResultVersions : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Index Note</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The list of file names.</para>
                /// </summary>
                [NameInMap("files")]
                [Validation(Required=false)]
                public List<ListIndexesResponseBodyResultVersionsFiles> Files { get; set; }
                public class ListIndexesResponseBodyResultVersionsFiles : TeaModel {
                    /// <summary>
                    /// <para>The name of the folder after a full-text index is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/qrs.json</para>
                    /// </summary>
                    [NameInMap("fullPathName")]
                    [Validation(Required=false)]
                    public string FullPathName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a folder exists.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isDir")]
                    [Validation(Required=false)]
                    public bool? IsDir { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the file is a template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isTemplate")]
                    [Validation(Required=false)]
                    public bool? IsTemplate { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qrs.json</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// <list type="bullet">
                /// <item><description><para>NEW: The index is being created.</para>
                /// </description></item>
                /// <item><description><para>PUBLISH: The index is in the Normal state.</para>
                /// </description></item>
                /// <item><description><para>IN_USE: The index is in use.</para>
                /// </description></item>
                /// <item><description><para>NOT_USE: The index is not in use.</para>
                /// </description></item>
                /// <item><description><para>STOP_USE: The index is being stopped.</para>
                /// </description></item>
                /// <item><description><para>RESTORE_USE: The index is being resumed.</para>
                /// </description></item>
                /// <item><description><para>FAIL: The index failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLISH</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-20 08:52:54</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The version ID. This parameter is null for an edit version.</para>
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
