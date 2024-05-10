// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateTrafficMirrorFilterRuleAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The new destination CIDR block of the inbound or outbound traffic.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The new destination port range of the inbound or outbound traffic.
        /// 
        /// >  If you set **Protocol** to **ICMP**, you cannot change the port range.
        /// </summary>
        [NameInMap("DestinationPortRange")]
        [Validation(Required=false)]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: only checks the API request. The configuration of the inbound or outbound rule is not modified. The system checks the required parameters, request syntax, and limits. If the request fails to pass the check, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. This is the default value. If the request passes the check, a 2xx HTTP status code is returned and the configuration of the inbound or outbound rule is modified.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The new priority of the inbound or outbound rule. A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The new protocol that is used by the traffic to be mirrored by the inbound or outbound rule. Valid values:
        /// 
        /// *   **ALL**: all protocols
        /// *   **ICMP**: Internet Control Message Protocol (ICMP)
        /// *   **TCP**: TCP
        /// *   **UDP**: User Datagram Protocol (UDP)
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the region to which the mirrored traffic belongs.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list. For more information about regions that support traffic mirroring, see [Overview of traffic mirroring](https://help.aliyun.com/document_detail/207513.html).
        /// 
        /// This parameter is required.
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
        /// The new action of the inbound or outbound rule. Valid values:
        /// 
        /// *   **accept**: accepts network traffic.
        /// *   **drop**: drops network traffic.
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// The new source CIDR block of the inbound or outbound traffic.
        /// </summary>
        [NameInMap("SourceCidrBlock")]
        [Validation(Required=false)]
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// The new source port range of the inbound or outbound traffic.
        /// 
        /// >  If you set **Protocol** to **ICMP**, you cannot change the port range.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// The ID of the inbound or outbound rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficMirrorFilterRuleId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterRuleId { get; set; }

    }

}
