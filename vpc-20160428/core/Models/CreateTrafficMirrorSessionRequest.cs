// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorSessionRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that the value is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** might be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request format, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable the traffic mirror session. Valid values:
        /// 
        /// *   **false** (default): does not enable the traffic mirror session.
        /// *   **true**: enables the traffic mirror session.
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
        /// The maximum transmission unit.
        /// 
        /// Valid values: **64 to 9600**. Default value: **1500**.
        /// </summary>
        [NameInMap("PacketLength")]
        [Validation(Required=false)]
        public int? PacketLength { get; set; }

        /// <summary>
        /// The priority of the traffic mirror session. Valid values: **1** to **32766**.
        /// 
        /// A smaller value indicates a higher priority. You cannot specify identical priorities for traffic mirror sessions that are created in the same region by using the same account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ID of the region to which the traffic mirror session belongs. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list. For more information about regions that support traffic mirroring, see [Overview of traffic mirroring](https://help.aliyun.com/document_detail/207513.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the mirrored traffic belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorSessionRequestTag> Tag { get; set; }
        public class CreateTrafficMirrorSessionRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the filter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// The description of the traffic mirror session.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorSessionDescription")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionDescription { get; set; }

        /// <summary>
        /// The name of the traffic mirror session.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// The ID of the traffic mirror source. You can specify only an elastic network interface (ENI) as the traffic mirror source. The default value of **N** is **1**, which indicates that you can add only one traffic mirror source to a traffic mirror session.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMirrorSourceIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSourceIds { get; set; }

        /// <summary>
        /// The ID of the traffic mirror destination. You can specify only an elastic network interface (ENI) or a Server Load Balancer (SLB) instance as a traffic mirror destination.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// The type of the traffic mirror destination. Valid values:
        /// 
        /// *   **NetworkInterface**: an ENI
        /// *   **SLB**: an SLB instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMirrorTargetType")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// The VXLAN network identifier (VNI). Valid values: **0** to **16777215**.
        /// 
        /// You can use VNIs to identify mirrored traffic from different sessions at the traffic mirror destination. You can specify a custom VNI or use a random VNI allocated by the system. If you want the system to randomly allocate a VNI, do not enter a value.
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
