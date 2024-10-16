// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetFeatureViewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;save_original_field&quot;:true}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>featureEntity1</para>
        /// </summary>
        [NameInMap("FeatureEntityName")]
        [Validation(Required=false)]
        public string FeatureEntityName { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetFeatureViewResponseBodyFields> Fields { get; set; }
        public class GetFeatureViewResponseBodyFields : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>int</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtSyncTime")]
        [Validation(Required=false)]
        public string GmtSyncTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user_id</para>
        /// </summary>
        [NameInMap("JoinId")]
        [Validation(Required=false)]
        public string JoinId { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>featureView1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12321421412****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>from feature_store_py.fs_client import FeatureStoreClient\nimport datetime\nfrom feature_store_py.fs_datasource import MaxComputeDataSource\nimport sys\n\ncur_day = args[&quot;dt&quot;]\nprint(&quot;cur_day = &quot;, cur_day)\n\naccess_key_id = o.account.access_id\naccess_key_secret = o.account.secret_access_key\nfs = FeatureStoreClient(access_key_id=access_key_id, access_key_secret=access_key_secret, region=&quot;cn-beijing&quot;)\ncur_project_name = &quot;p1&quot;\nproject = fs.get_project(cur_project_name)\n\nfeature_view_name = &quot;user_fea&quot;\nbatch_feature_view = project.get_feature_view(feature_view_name)\ntask = batch_feature_view.publish_table(partitions={&quot;ds&quot;:cur_day}, mode=&quot;Overwrite&quot;)\ntask.wait()\ntask.print_summary()\n</para>
        /// </summary>
        [NameInMap("PublishTableScript")]
        [Validation(Required=false)]
        public string PublishTableScript { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RegisterDatasourceId")]
        [Validation(Required=false)]
        public string RegisterDatasourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>datasource1</para>
        /// </summary>
        [NameInMap("RegisterDatasourceName")]
        [Validation(Required=false)]
        public string RegisterDatasourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("RegisterTable")]
        [Validation(Required=false)]
        public string RegisterTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72F15A8A-5A28-5B18-A0DE-0EABD7D3245A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SyncOnlineTable")]
        [Validation(Required=false)]
        public bool? SyncOnlineTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public int? TTL { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Batch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("WriteMethod")]
        [Validation(Required=false)]
        public string WriteMethod { get; set; }

        [NameInMap("WriteToFeatureDB")]
        [Validation(Required=false)]
        public bool? WriteToFeatureDB { get; set; }

    }

}
