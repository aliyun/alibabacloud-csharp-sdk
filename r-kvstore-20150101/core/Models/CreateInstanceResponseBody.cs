// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// The maximum bandwidth of the instance. Unit: MB/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: MB.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The configurations of the instance.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The internal endpoint of the instance.
        /// </summary>
        [NameInMap("ConnectionDomain")]
        [Validation(Required=false)]
        public string ConnectionDomain { get; set; }

        /// <summary>
        /// The maximum number of connections supported by the instance.
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public long? Connections { get; set; }

        /// <summary>
        /// The time when the subscription expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The GUID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The state of the instance. The return value is Creating.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **CLASSIC**: classic network
        /// *   **VPC**: VPC
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   **STAND_ALONE**: standalone
        /// *   **MASTER_SLAVE**: master-replica
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The port number that is used to connect to the instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// </summary>
        [NameInMap("PrivateIpAddr")]
        [Validation(Required=false)]
        public string PrivateIpAddr { get; set; }

        /// <summary>
        /// The expected maximum queries per second (QPS).
        /// </summary>
        [NameInMap("QPS")]
        [Validation(Required=false)]
        public long? QPS { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The username that is used to connect to the instance. By default, ApsaraDB for Redis provides a username that is named after the instance ID.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the instance is connected.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
