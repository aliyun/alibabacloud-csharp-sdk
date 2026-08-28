// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentInstanceNodesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("node_list")]
        [Validation(Required=false)]
        public List<ListNodePoolComponentInstanceNodesResponseBodyNodeList> NodeList { get; set; }
        public class ListNodePoolComponentInstanceNodesResponseBodyNodeList : TeaModel {
            [NameInMap("component")]
            [Validation(Required=false)]
            public ListNodePoolComponentInstanceNodesResponseBodyNodeListComponent Component { get; set; }
            public class ListNodePoolComponentInstanceNodesResponseBodyNodeListComponent : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListNodePoolComponentInstanceNodesResponseBodyNodeListComponentConfig Config { get; set; }
                public class ListNodePoolComponentInstanceNodesResponseBodyNodeListComponentConfig : TeaModel {
                    [NameInMap("custom_config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> CustomConfig { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("config_revision")]
                [Validation(Required=false)]
                public string ConfigRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kubelet</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.28.9-aliyun.1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-bp1xxxxx</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou.10.91.xx.xx</para>
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("total_count")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
