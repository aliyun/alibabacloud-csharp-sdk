// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateTrafficMirrorSessionAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run, without performing the actual request. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the check, a 2xx HTTP status code is returned and the operation is performed. This is the default value.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable the traffic mirror session. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The maximum transmission unit (MTU).
        /// 
        /// Valid values: **64 to 9600**. Default value: **1500**.
        /// </summary>
        [NameInMap("PacketLength")]
        [Validation(Required=false)]
        public int? PacketLength { get; set; }

        /// <summary>
        /// The new priority of the traffic mirror session. Valid values: **1** to **32766**.
        /// 
        /// A smaller value indicates a higher priority. You cannot specify identical priorities for traffic mirror sessions that are created in the same region by using the same account.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The region ID of the traffic mirror session. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list. For more information about the regions that support traffic mirroring, see [Overview of traffic mirroring](~~207513~~).
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
        /// The ID of the traffic mirror filter.
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// The new description of the traffic mirror session.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorSessionDescription")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionDescription { get; set; }

        /// <summary>
        /// The ID of the traffic mirror session.
        /// </summary>
        [NameInMap("TrafficMirrorSessionId")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionId { get; set; }

        /// <summary>
        /// The new name of the traffic mirror session.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// The ID of the traffic mirror destination.
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// The new type of the traffic mirror destination. Valid values:
        /// 
        /// *   **NetworkInterface**: an elastic network interface (ENI)
        /// *   **SLB**: an internal-facing Server Load Balancer (SLB) instance
        /// </summary>
        [NameInMap("TrafficMirrorTargetType")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// The VXLAN network identifier (VNI) that is used to distinguish different mirrored traffic. Valid values: **0** to **16777215**.
        /// 
        /// You can use VNIs to identify mirrored traffic from different sessions at the traffic mirror destination. If you do not specify a VNI, the system randomly allocates a VNI. If you want the system to randomly allocate a VNI, ignore this parameter.
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
