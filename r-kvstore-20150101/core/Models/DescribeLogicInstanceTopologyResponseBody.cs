// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeLogicInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The detailed proxy information, including information about proxy nodes.
        /// </summary>
        [NameInMap("RedisProxyList")]
        [Validation(Required=false)]
        public DescribeLogicInstanceTopologyResponseBodyRedisProxyList RedisProxyList { get; set; }
        public class DescribeLogicInstanceTopologyResponseBodyRedisProxyList : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLogicInstanceTopologyResponseBodyRedisProxyListNodeInfo> NodeInfo { get; set; }
            public class DescribeLogicInstanceTopologyResponseBodyRedisProxyListNodeInfo : TeaModel {
                /// <summary>
                /// The maximum bandwidth of the node. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The storage capacity of the node. Unit: MB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                /// <summary>
                /// The maximum number of connections.
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **proxy**: proxy node
                /// *   **db**: data node
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

        /// <summary>
        /// Details of data shards, including node information such as NodeInfo.
        /// </summary>
        [NameInMap("RedisShardList")]
        [Validation(Required=false)]
        public DescribeLogicInstanceTopologyResponseBodyRedisShardList RedisShardList { get; set; }
        public class DescribeLogicInstanceTopologyResponseBodyRedisShardList : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo> NodeInfo { get; set; }
            public class DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo : TeaModel {
                /// <summary>
                /// The maximum bandwidth of the node. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The storage capacity of the node. Unit: MB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                /// <summary>
                /// The maximum number of connections.
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **proxy**: proxy node
                /// *   **db**: data node
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The type of the child instance. Valid values:
                /// 
                /// *   **master**: master node
                /// *   **readonly**: read-only instance
                /// </summary>
                [NameInMap("SubInstanceType")]
                [Validation(Required=false)]
                public string SubInstanceType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
