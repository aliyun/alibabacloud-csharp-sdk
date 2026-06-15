// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetFeatureViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;save_original_field&quot;:true}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The feature entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        /// <summary>
        /// <para>The feature entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>featureEntity1</para>
        /// </summary>
        [NameInMap("FeatureEntityName")]
        [Validation(Required=false)]
        public string FeatureEntityName { get; set; }

        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetFeatureViewResponseBodyFields> Fields { get; set; }
        public class GetFeatureViewResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>The list of field attributes. Valid values:</para>
            /// <para>● <c>Partition</c>: The partition field.</para>
            /// <para>● <c>PrimaryKey</c>: The primary key.</para>
            /// <para>● <c>EventTime</c>: The event time.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The feature transformation.</para>
            /// </summary>
            [NameInMap("Transform")]
            [Validation(Required=false)]
            public List<GetFeatureViewResponseBodyFieldsTransform> Transform { get; set; }
            public class GetFeatureViewResponseBodyFieldsTransform : TeaModel {
                /// <summary>
                /// <para>The input for the feature transformation.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public List<GetFeatureViewResponseBodyFieldsTransformInput> Input { get; set; }
                public class GetFeatureViewResponseBodyFieldsTransformInput : TeaModel {
                    /// <summary>
                    /// <para>The modality type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEXT</para>
                    /// </summary>
                    [NameInMap("Modality")]
                    [Validation(Required=false)]
                    public string Modality { get; set; }

                    /// <summary>
                    /// <para>The feature name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>feature1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The feature type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The LLM configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LLMConfigId")]
                [Validation(Required=false)]
                public int? LLMConfigId { get; set; }

                /// <summary>
                /// <para>The feature transformation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LLMEmbedding</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data type of the field. Valid values:</para>
            /// <para>● <c>int</c></para>
            /// <para>● <c>string</c></para>
            /// <para>● <c>float</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>int</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The synchronization time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtSyncTime")]
        [Validation(Required=false)]
        public string GmtSyncTime { get; set; }

        /// <summary>
        /// <para>The join ID of the feature entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_id</para>
        /// </summary>
        [NameInMap("JoinId")]
        [Validation(Required=false)]
        public string JoinId { get; set; }

        /// <summary>
        /// <para>The most recent synchronization configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;mode&quot;: &quot;overwrite&quot;,
        ///     &quot;partitions&quot;: {
        ///         &quot;ds&quot;: {
        ///             &quot;value&quot;: &quot;20230820&quot;
        ///         }
        ///     },
        ///     &quot;event_time&quot;: &quot;&quot;,
        ///     &quot;config&quot;: {},
        ///     &quot;offline_to_online&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("LastSyncConfig")]
        [Validation(Required=false)]
        public string LastSyncConfig { get; set; }

        /// <summary>
        /// <para>The name of the mock data table for the stream feature view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item_table_mock_1</para>
        /// </summary>
        [NameInMap("MockTableName")]
        [Validation(Required=false)]
        public string MockTableName { get; set; }

        /// <summary>
        /// <para>The feature view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>featureView1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12321421412****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The script for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>from feature_store_py.fs_client import FeatureStoreClient\nimport datetime\nfrom feature_store_py.fs_datasource import MaxComputeDataSource\nimport sys\n\ncur_day = args[\&quot;dt\&quot;]\nprint(\&quot;cur_day = \&quot;, cur_day)\n\naccess_key_id = o.account.access_id\naccess_key_secret = o.account.secret_access_key\nfs = FeatureStoreClient(access_key_id=access_key_id, access_key_secret=access_key_secret, region=\&quot;cn-beijing\&quot;)\ncur_project_name = \&quot;p1\&quot;\nproject = fs.get_project(cur_project_name)\n\nfeature_view_name = \&quot;user_fea\&quot;\nbatch_feature_view = project.get_feature_view(feature_view_name)\ntask = batch_feature_view.publish_table(partitions={\&quot;ds\&quot;:cur_day}, mode=\&quot;Overwrite\&quot;)\ntask.wait()\ntask.print_summary()\n</para>
        /// </summary>
        [NameInMap("PublishTableScript")]
        [Validation(Required=false)]
        public string PublishTableScript { get; set; }

        /// <summary>
        /// <para>The ID of the data source where the registered table resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RegisterDatasourceId")]
        [Validation(Required=false)]
        public string RegisterDatasourceId { get; set; }

        /// <summary>
        /// <para>The name of the data source where the registered table resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource1</para>
        /// </summary>
        [NameInMap("RegisterDatasourceName")]
        [Validation(Required=false)]
        public string RegisterDatasourceName { get; set; }

        /// <summary>
        /// <para>The name of the registered table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72F15A8A-5A28-5B18-A0DE-0EABD7D3245A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether to synchronize the online feature table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncOnlineTable")]
        [Validation(Required=false)]
        public bool? SyncOnlineTable { get; set; }

        /// <summary>
        /// <para>The time to live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The type of the feature view. Valid values:</para>
        /// <para>● <c>Batch</c>: A batch feature.</para>
        /// <para>● <c>Stream</c>: A stream feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The write method. Valid values:</para>
        /// <para>● <c>ByReadyMadeTable</c>: Registers the feature view by using an existing table.</para>
        /// <para>● <c>Custom</c>: Uses a custom table structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("WriteMethod")]
        [Validation(Required=false)]
        public string WriteMethod { get; set; }

        /// <summary>
        /// <para>Indicates whether to write data to the online managed storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WriteToFeatureDB")]
        [Validation(Required=false)]
        public bool? WriteToFeatureDB { get; set; }

    }

}
