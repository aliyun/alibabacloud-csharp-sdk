// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterNetInfoResponseBody : TeaModel {
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyItemsAddress : TeaModel {
                public string ConnectionString { get; set; }
                public string ConnectionStringPrefix { get; set; }
                public string IPAddress { get; set; }
                public string NetType { get; set; }
                public string Port { get; set; }
                public string VPCId { get; set; }
                public string VSwitchId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
