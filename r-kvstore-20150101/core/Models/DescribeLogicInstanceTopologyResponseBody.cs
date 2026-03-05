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

        [NameInMap("RedisProxyList")]
        [Validation(Required=false)]
        public DescribeLogicInstanceTopologyResponseBodyRedisProxyList RedisProxyList { get; set; }
        public class DescribeLogicInstanceTopologyResponseBodyRedisProxyList : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLogicInstanceTopologyResponseBodyRedisProxyListNodeInfo> NodeInfo { get; set; }
            public class DescribeLogicInstanceTopologyResponseBodyRedisProxyListNodeInfo : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

        [NameInMap("RedisShardList")]
        [Validation(Required=false)]
        public DescribeLogicInstanceTopologyResponseBodyRedisShardList RedisShardList { get; set; }
        public class DescribeLogicInstanceTopologyResponseBodyRedisShardList : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo> NodeInfo { get; set; }
            public class DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

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
