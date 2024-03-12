// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartTerminalSessionRequest : TeaModel {
        /// <summary>
        /// If you set this parameter to the IP address of an instance, the PortNumber parameter specifies the port number of the instance.
        /// 
        /// >If you specify `CommandLine`, you do not need to specify `PortNumber` or `TargetServer`.
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// The instance IDs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port number of the instance. The port is used to forward data. After this parameter is configured, Cloud Assistant Agent forwards data to the specified port for forwarding. Example: 22.
        /// 
        /// This parameter is empty by default, which indicates that no port is configured to forward data.
        /// </summary>
        [NameInMap("PortNumber")]
        [Validation(Required=false)]
        public int? PortNumber { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IP address of the instance.
        /// 
        /// >If you set this parameter to the IP address of an instance, the `PortNumber` parameter specifies the port number of the instance.
        /// </summary>
        [NameInMap("TargetServer")]
        [Validation(Required=false)]
        public string TargetServer { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
