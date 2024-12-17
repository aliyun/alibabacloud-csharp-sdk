// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeLogicInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The information about proxy nodes.</para>
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
                /// <para>The maximum bandwidth of the node. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The storage capacity of the node. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5120</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                /// <summary>
                /// <para>The maximum number of connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>320000</para>
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp10noxlhcoim2****-proxy-3#542****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>db</b>: a data node.</description></item>
                /// <item><description><b>normal</b>: a management node, which can be a proxy node or a Configserver node. For specific instances, the return value of this parameter is proxy or cs, instead of normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>proxy</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

        /// <summary>
        /// <para>Details of data shards, including node information such as NodeInfo.</para>
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
                /// <para>The maximum bandwidth of the node. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The storage capacity of the node. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                /// <summary>
                /// <para>The maximum number of connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp10noxlhcoim2****-db-0#688****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>proxy</b>: proxy node</description></item>
                /// <item><description><b>db</b>: data node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The type of the child instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: master node</description></item>
                /// <item><description><b>readonly</b>: read-only instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("SubInstanceType")]
                [Validation(Required=false)]
                public string SubInstanceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>794120D1-E0CF-4713-BAE4-EBAEA04506AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
