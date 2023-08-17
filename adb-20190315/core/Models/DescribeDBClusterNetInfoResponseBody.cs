// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// The network type of the cluster.
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// The network information of the cluster.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyItemsAddress : TeaModel {
                /// <summary>
                /// The endpoint of the cluster.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The prefix of the cluster endpoint.
                /// </summary>
                [NameInMap("ConnectionStringPrefix")]
                [Validation(Required=false)]
                public string ConnectionStringPrefix { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   **Public**: public endpoint
                /// *   **VPC**: Virtual Private Cloud (VPC) endpoint
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the cluster.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// 
                /// >  This parameter is empty when Public is returned for NetType.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// 
                /// >  This parameter is empty when Public is returned for NetType.
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
