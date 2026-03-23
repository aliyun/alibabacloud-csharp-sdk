// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceIpAddressResponseBody : TeaModel {
        [NameInMap("RCInstanceList")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceIpAddressResponseBodyRCInstanceList> RCInstanceList { get; set; }
        public class DescribeRCInstanceIpAddressResponseBodyRCInstanceList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("IpAddressConfig")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceIpAddressResponseBodyRCInstanceListIpAddressConfig> IpAddressConfig { get; set; }
            public class DescribeRCInstanceIpAddressResponseBodyRCInstanceListIpAddressConfig : TeaModel {
                [NameInMap("BlackholeThreshold")]
                [Validation(Required=false)]
                public int? BlackholeThreshold { get; set; }

                [NameInMap("DefenseBpsThreshold")]
                [Validation(Required=false)]
                public int? DefenseBpsThreshold { get; set; }

                [NameInMap("DefensePpsThreshold")]
                [Validation(Required=false)]
                public int? DefensePpsThreshold { get; set; }

                [NameInMap("ElasticThreshold")]
                [Validation(Required=false)]
                public int? ElasticThreshold { get; set; }

                [NameInMap("InstanceIp")]
                [Validation(Required=false)]
                public string InstanceIp { get; set; }

                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("IsBgppack")]
                [Validation(Required=false)]
                public bool? IsBgppack { get; set; }

                [NameInMap("IsFullProtection")]
                [Validation(Required=false)]
                public int? IsFullProtection { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
