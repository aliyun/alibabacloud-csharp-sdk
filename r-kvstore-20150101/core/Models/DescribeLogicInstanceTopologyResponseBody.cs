// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeLogicInstanceTopologyResponseBody : TeaModel {
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
                public string Bandwidth { get; set; }
                public string Capacity { get; set; }
                public string Connection { get; set; }
                public string NodeId { get; set; }
                public string NodeType { get; set; }
            }
        };

        [NameInMap("RedisShardList")]
        [Validation(Required=false)]
        public DescribeLogicInstanceTopologyResponseBodyRedisShardList RedisShardList { get; set; }
        public class DescribeLogicInstanceTopologyResponseBodyRedisShardList : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo> NodeInfo { get; set; }
            public class DescribeLogicInstanceTopologyResponseBodyRedisShardListNodeInfo : TeaModel {
                public string Bandwidth { get; set; }
                public string Capacity { get; set; }
                public string Connection { get; set; }
                public string NodeId { get; set; }
                public string NodeType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
