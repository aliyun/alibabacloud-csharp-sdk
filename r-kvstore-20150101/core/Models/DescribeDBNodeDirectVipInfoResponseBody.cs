// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBNodeDirectVipInfoResponseBody : TeaModel {
        /// <summary>
        /// The virtual IP addresses (VIPs) of shards in an ApsaraDB for Redis cluster instance.
        /// </summary>
        [NameInMap("DirectVipInfo")]
        [Validation(Required=false)]
        public DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo DirectVipInfo { get; set; }
        public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo : TeaModel {
            [NameInMap("VipInfo")]
            [Validation(Required=false)]
            public List<DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo> VipInfo { get; set; }
            public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo : TeaModel {
                /// <summary>
                /// The network type of the security group. Valid values:
                /// 
                /// *   **vpc**: Virtual Private Cloud (VPC)
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The shard ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The port number. Valid values: **1024** to **65535**. Default value: **6379**.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The VIP of the shard.
                /// </summary>
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

            }

        }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
