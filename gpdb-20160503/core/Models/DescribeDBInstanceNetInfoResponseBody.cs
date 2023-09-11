// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// The connection information of the instance.
        /// </summary>
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                /// <summary>
                /// The type of the endpoint.
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// The endpoint that is used to connect to the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The type of the IP address.
                /// 
                /// *   Valid values for instances in the classic network: Inner and Public.
                /// *   Valid values for instances in a virtual private cloud (VPC): Private and Public.
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID. Multiple IDs are separated by commas (,).
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the instance that is deployed in a VPC.
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

        }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   Classic: classic network.
        /// *   VPC: VPC.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
