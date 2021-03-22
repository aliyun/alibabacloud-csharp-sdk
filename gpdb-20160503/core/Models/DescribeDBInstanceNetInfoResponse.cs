// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceNetInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=true)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=true)]
        public DescribeDBInstanceNetInfoResponseDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=true)]
            public List<DescribeDBInstanceNetInfoResponseDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                public string IPType { get; set; }
                public string VPCId { get; set; }
                public string Port { get; set; }
                public string VSwitchId { get; set; }
                public string VpcInstanceId { get; set; }
                public string AddressType { get; set; }
                public string IPAddress { get; set; }
                public string ConnectionString { get; set; }
            }
        };

    }

}
