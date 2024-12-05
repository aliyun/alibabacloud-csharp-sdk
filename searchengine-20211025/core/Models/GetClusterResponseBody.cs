// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetClusterResponseBodyResult Result { get; set; }
        public class GetClusterResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Config { get; set; }

            /// <summary>
            /// <para>The time when the cluster was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-09 00:01:02</para>
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
            /// <para>test_yyds_data1</para>
            /// </summary>
            [NameInMap("currentAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string CurrentAdvanceConfigVersion { get; set; }

            /// <summary>
            /// <para>The effective online configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_yyds_data1</para>
            /// </summary>
            [NameInMap("currentOnlineConfigVersion")]
            [Validation(Required=false)]
            public string CurrentOnlineConfigVersion { get; set; }

            /// <summary>
            /// <para>The specifications of Searcher workers.</para>
            /// </summary>
            [NameInMap("dataNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyResultDataNode DataNode { get; set; }
            public class GetClusterResponseBodyResultDataNode : TeaModel {
                /// <summary>
                /// <para>The name of the Searcher worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of replicas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The number of partitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
            /// <para>test_yyds_data1</para>
            /// </summary>
            [NameInMap("latestAdvanceConfigVersion")]
            [Validation(Required=false)]
            public string LatestAdvanceConfigVersion { get; set; }

            /// <summary>
            /// <para>The latest online configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_yyds_data1</para>
            /// </summary>
            [NameInMap("latestOnlineConfigVersion")]
            [Validation(Required=false)]
            public string LatestOnlineConfigVersion { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The specifications of Query Result Searcher (QRS) workers.</para>
            /// </summary>
            [NameInMap("queryNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyResultQueryNode QueryNode { get; set; }
            public class GetClusterResponseBodyResultQueryNode : TeaModel {
                /// <summary>
                /// <para>The name of the QRS worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The number of replicas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public int? Partition { get; set; }

            }

            /// <summary>
            /// <para>The creation status of the cluster. Valid values: NEW and PUBLISH. NEW indicates that the cluster is being created. PUBLISH indicates that the cluster is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
