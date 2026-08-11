// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexRequest : TeaModel {
        /// <summary>
        /// <para>The number of concurrent full-indexing build threads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// <para>The cluster information.</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Cluster { get; set; }

        /// <summary>
        /// <para>The cluster.json file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****@a-cn-pl32rf0****_test_api@hz_pre_vpc_domain_1@test_api@index_config_v1</para>
        /// </summary>
        [NameInMap("clusterConfigName")]
        [Validation(Required=false)]
        public string ClusterConfigName { get; set; }

        /// <summary>
        /// <para>The offline configuration information.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, ConfigValue> Config { get; set; }

        /// <summary>
        /// <para>The file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;summarys\&quot;:{\&quot;summary_fields\&quot;:[\&quot;id\&quot;]},\&quot;indexs\&quot;:[{\&quot;index_name\&quot;:\&quot;index_id\&quot;,\&quot;index_type\&quot;:\&quot;PRIMARYKEY64\&quot;,\&quot;index_fields\&quot;:\&quot;id\&quot;,\&quot;has_primary_key_attribute\&quot;:true,\&quot;is_primary_key_sorted\&quot;:false}],\&quot;attributes\&quot;:[\&quot;id\&quot;],\&quot;fields\&quot;:[{\&quot;field_name\&quot;:\&quot;id\&quot;,\&quot;field_type\&quot;:\&quot;UINT16\&quot;}],\&quot;table_name\&quot;:\&quot;index_2\&quot;}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_index_1</para>
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter is required for the new version of AISearch.</para>
        /// </summary>
        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public ModifyIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class ModifyIndexRequestDataSourceInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic full indexing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            /// <summary>
            /// <para>The index rebuild mode. Valid values: api (push data source through API) and indexRecover (recover data source from the index).</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("buildMode")]
            [Validation(Required=false)]
            public string BuildMode { get; set; }

            /// <summary>
            /// <para>The ODPS datasource config.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoConfig Config { get; set; }
            public class ModifyIndexRequestDataSourceInfoConfig : TeaModel {
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
                /// <para>The data catalog ID for DLF data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-catalog</para>
                /// </summary>
                [NameInMap("catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The database for DLF data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-database</para>
                /// </summary>
                [NameInMap("database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The ODPS endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The OSS file format type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ha3</description></item>
                /// <item><description>json.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ha3</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The namespace for saro data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-namespace</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The path for OSS data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opensearch/oss.json</para>
                /// </summary>
                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The ODPS partition. Example: ds=20180102.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20230114</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The path for HDFS data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-hdfs-path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The ODPS data source project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbt_algo_pai</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The table name for saro or ODPS data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item</para>
                /// </summary>
                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                /// <summary>
                /// <para>The table format for DLF data sources.</para>
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
                /// <para>The tag for DLF data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-tag</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The timestamp for incremental data tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709715164</para>
            /// </summary>
            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            /// <summary>
            /// <para>The offline deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc_hz_domain_1</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The generation of the dump table when recovering the data source from the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1718698593</para>
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_index_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The file path selected for index rebuilding from an OSS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opensearch/oss.json</para>
            /// </summary>
            [NameInMap("ossDataPath")]
            [Validation(Required=false)]
            public string OssDataPath { get; set; }

            /// <summary>
            /// <para>The ODPS data source partition. This parameter is required when the data source type is ODPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20230114</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The number of concurrent full-indexing processes.</para>
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
            /// <para>The saro datasource config.</para>
            /// </summary>
            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class ModifyIndexRequestDataSourceInfoSaroConfig : TeaModel {
                /// <summary>
                /// <para>The namespace of the saro data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink-test-fjx-default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The saro data table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device_event_shy_summary_</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The data source type. Valid values: odps, swift, saro, oss, and unKnow.</para>
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
        /// <para>&quot;test&quot;</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The data source deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The extended content for field configurations. key: vector (vector field), embeding (field requiring embedding), or description (remarks field). value: [&quot;schema field name&quot;].</para>
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
        /// <para>The number of concurrent full-indexing merge threads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        /// <summary>
        /// <para>The data partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// <para>The push configuration mode. Default value: push configuration only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUSH_ONLY</para>
        /// </summary>
        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to only validate the input parameters without performing the actual operation. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Only validates the parameter validity.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Validates the parameter validity and creates the attribution configuration.</para>
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
