// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterNetInfoItemsResponseBody : TeaModel {
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                public string ConnectionString { get; set; }
                public string HttpPort { get; set; }
                public string IPAddress { get; set; }
                public string JdbcPort { get; set; }
                public string NetType { get; set; }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
