// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateIndexRequest : TeaModel {
        /// <summary>
        /// <para>The concurrency for full index building.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// <para>The index schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;summarys\&quot;:{\&quot;summary_fields\&quot;:[\&quot;id\&quot;]},\&quot;indexs\&quot;:[{\&quot;index_name\&quot;:\&quot;index_id\&quot;,\&quot;index_type\&quot;:\&quot;PRIMARYKEY64\&quot;,\&quot;index_fields\&quot;:\&quot;id\&quot;,\&quot;has_primary_key_attribute\&quot;:true,\&quot;is_primary_key_sorted\&quot;:false}],\&quot;attributes\&quot;:[\&quot;id\&quot;],\&quot;fields\&quot;:[{\&quot;field_name\&quot;:\&quot;id\&quot;,\&quot;field_type\&quot;:\&quot;UINT16\&quot;}],\&quot;table_name\&quot;:\&quot;index_2\&quot;}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-35t3n1y****_index_1</para>
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>Information about the data source. This parameter is required for new versions of Vector Search Edition.</para>
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public CreateIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class CreateIndexRequestDataSourceInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically trigger a full indexing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// <para>ODPS-related configurations.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateIndexRequestDataSourceInfoConfig Config { get; set; }
            public class CreateIndexRequestDataSourceInfoConfig : TeaModel {
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
                /// <para>The OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The data catalog ID of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-catalog</para>
                /// </summary>
                [NameInMap("catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The database of the DLF data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-database</para>
                /// </summary>
                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The endpoint of the ODPS or OSS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com">https://oss-cn-hangzhou.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The format of the OSS file.</para>
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
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-namespace</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The path of the OSS file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opensearch/oss.json</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>This parameter is required if the data source type is ODPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20230114</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The path of the HDFS data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-hdfs-path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The name of the ODPS project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbt_algo_pai</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbt_rec_swing_u2i2i_score_be_v1</para>
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
                /// <para>test-tag</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp for incremental data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709715164</para>
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// <para>The offline data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-35t3n1y****_index_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The concurrency for full data processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("processParallelNum")]
            [Validation(Required=false)]
            public int? ProcessParallelNum { get; set; }

            /// <summary>
            /// <para>The number of resources for data updates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("processPartitionCount")]
            [Validation(Required=false)]
            public int? ProcessPartitionCount { get; set; }

            /// <summary>
            /// <para>The configuration of the Saro data source.</para>
            /// </summary>
            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public CreateIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class CreateIndexRequestDataSourceInfoSaroConfig : TeaModel {
                /// <summary>
                /// <para>The namespace of the Saro data source. This feature is available only for internal use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The name of the Saro data table. This feature is available only for internal use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tableA</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

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
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>odps</para>
            /// </description></item>
            /// <item><description><para>swift</para>
            /// </description></item>
            /// <item><description><para>saro</para>
            /// </description></item>
            /// <item><description><para>oss</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The data center of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The extended field configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>key: The field type. Valid values: \<c>vector\\</c> (vector field), \<c>embeding\\</c> (field that requires embedding), and \<c>description\\</c> (description field).</para>
        /// </description></item>
        /// <item><description><para>value: The name of the field in the schema, such as \<c>[&quot;field_name&quot;]\\</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;vector&quot;:
        ///         [
        ///             &quot;source_image_vector&quot;
        ///         ],
        ///         &quot;embeding&quot;:
        ///         [
        ///             &quot;source_image&quot;
        ///         ],
        ///         &quot;description&quot;:
        ///         []
        ///     }</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        /// <summary>
        /// <para>The concurrency for full index merging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        /// <summary>
        /// <para>The name of the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index_1</para>
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
        /// <para>Specifies whether to perform a dry run. A dry run only checks whether the data source is valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
