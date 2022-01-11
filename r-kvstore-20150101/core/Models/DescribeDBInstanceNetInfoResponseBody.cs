// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyNetInfoItems : TeaModel {
            [NameInMap("InstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo> InstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo : TeaModel {
                public string ConnectionString { get; set; }
                public string DBInstanceNetType { get; set; }
                public int? DirectConnection { get; set; }
                public string ExpiredTime { get; set; }
                public string IPAddress { get; set; }
                public string IPType { get; set; }
                public string Port { get; set; }
                public string Upgradeable { get; set; }
                public string VPCId { get; set; }
                public string VPCInstanceId { get; set; }
                public string VSwitchId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
