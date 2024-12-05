// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F43E8AB4-419C-5F4C-90D6-615590DFAA3C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyResult> Result { get; set; }
        public class ListClustersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// <para>The time when the configuration was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("configUpdateTime")]
            [Validation(Required=false)]
            public string ConfigUpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-21 16:05:26</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The effective advanced configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("currentAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string CurrentAdvanceConfigVersion { get; set; }

            /// <summary>
            /// <para>The effective dictionary configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_offline_adv_v1</para>
            /// </summary>
            [NameInMap("currentOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOfflineDictConfigVersion { get; set; }

            /// <summary>
            /// <para>The effective online configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("currentOnlineConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineConfigVersion { get; set; }

            /// <summary>
            /// <para>The effective query configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_offline_adv_v1</para>
            /// </summary>
            [NameInMap("currentOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// <para>The information about Searcher workers.</para>
            /// </summary>
            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultDataNode DataNode { get; set; }
            public class ListClustersResponseBodyResultDataNode : TeaModel {
                /// <summary>
                /// <para>The name of the Searcher worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-8ed2k7brm05_qrs</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of Searcher workers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The ID of the partition that is stored on the Searcher worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dt=20220216</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// <para>The description of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fzz_test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The latest advanced configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("latestAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string LatestAdvanceConfigVersion { get; set; }

            /// <summary>
            /// <para>The latest dictionary configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_offline_adv_v1</para>
            /// </summary>
            [NameInMap("latestOfflineDictConfigVersion")]
            [Validation(Required=false)]
            public string LatestOfflineDictConfigVersion { get; set; }

            /// <summary>
            /// <para>The latest online configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("latestOnlineConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineConfigVersion { get; set; }

            /// <summary>
            /// <para>The latest query configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_offline_adv_v1</para>
            /// </summary>
            [NameInMap("latestOnlineQueryConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineQueryConfigVersion { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-7pp2pcna701_qrs</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about Query Result Searcher (QRS) workers.</para>
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public ListClustersResponseBodyResultQueryNode QueryNode { get; set; }
            public class ListClustersResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// <para>The name of the QRS worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_0704</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of QRS workers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The ID of the partition that is stored on the QRS worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dt=20211216</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// <para>The cluster status. Valid values: running: The cluster is running. starting: The cluster is being started. stopping: The cluster is being stopped. stopped: The cluster is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;starting&quot;</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
