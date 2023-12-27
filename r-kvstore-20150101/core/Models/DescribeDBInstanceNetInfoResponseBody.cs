// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   **CLASSIC**: The instance runs in a classic network.
        /// *   **VPC**: The instance runs in a virtual private cloud (VPC).
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The list of network information about the instance.
        /// </summary>
        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyNetInfoItems : TeaModel {
            [NameInMap("InstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo> InstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo : TeaModel {
                /// <summary>
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **0**: the Internet.
                /// *   **1**: classic network.
                /// *   **2**: VPC.
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// Indicates whether the address is a private endpoint. Valid values:
                /// 
                /// *   **0**: no.
                /// *   **1**: yes.
                /// </summary>
                [NameInMap("DirectConnection")]
                [Validation(Required=false)]
                public int? DirectConnection { get; set; }

                /// <summary>
                /// The expiration time of the classic network address of an ApsaraDB for Redis instance. Unit: seconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the IP address. Valid values:
                /// 
                /// *   **Public**: Internet.
                /// *   **Inner**: classic network.
                /// *   **Private**: VPC.
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                [NameInMap("IsSlaveProxy")]
                [Validation(Required=false)]
                public int? IsSlaveProxy { get; set; }

                /// <summary>
                /// The service port of the ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The remaining validity period of the endpoint of the classic network. Unit: seconds.
                /// 
                /// >  A value of **0** indicates that the endpoint never expires.
                /// </summary>
                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                /// <summary>
                /// The ID of the VPC where the instance is deployed.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("VPCInstanceId")]
                [Validation(Required=false)]
                public string VPCInstanceId { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

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
