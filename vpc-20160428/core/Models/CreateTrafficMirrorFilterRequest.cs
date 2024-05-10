// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorFilterRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that the value is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed. This is the default value.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The list of outbound rules.
        /// </summary>
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRequestEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRequestEgressRules : TeaModel {
            /// <summary>
            /// The action of the outbound rule. Valid values:
            /// 
            /// *   **accept**: collects network traffic.
            /// *   **drop**: does not collect network traffic.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The destination CIDR block of the outbound traffic.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// The destination port range of the outbound traffic. Valid values for a port: **1** to **65535**. Separate the first port and the last port with a forward slash (/). Examples: **1/200** and **80/80**. You cannot set this parameter to only **-1/-1**. The value -1/-1 specifies all ports.
            /// 
            /// >  If you set **EgressRules.N.Protocol** to **ALL** or **ICMP**, you do not need to set this parameter. In this case, all ports are available.
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            /// <summary>
            /// The priority of the outbound rule. A smaller value indicates a higher priority.
            /// 
            /// The maximum value of **N** is **10**. You can configure up to 10 outbound rules for a filter.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The protocol that is used by the outbound traffic to be mirrored. Valid values:
            /// 
            /// *   **ALL**: all protocols
            /// *   **ICMP**: ICMP
            /// *   **TCP**: TCP
            /// *   **UDP**: UDP
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block of the outbound traffic.
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// The source port range of the outbound traffic. Valid values for a port: **1** to **65535**. Separate the first port and the last port with a forward slash (/). Examples: **1/200** and **80/80**. You cannot set this parameter to only **-1/-1**. The value -1/-1 specifies all ports.
            /// 
            /// >  If you set **EgressRules.N.Protocol** to **ALL** or **ICMP**, you do not need to set this parameter. In this case, all ports are available.
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        /// <summary>
        /// The list of inbound rules.
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRequestIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRequestIngressRules : TeaModel {
            /// <summary>
            /// The action of the inbound rule. Valid values:
            /// 
            /// *   **accept**: collects network traffic.
            /// *   **drop**: does not collect network traffic.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The destination CIDR block of the inbound traffic.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// The destination port range of the inbound traffic. Valid values for a port: **1** to **65535**. Separate the first port and the last port with a forward slash (/). Examples: **1/200** and **80/80**.
            /// 
            /// >  If you set **IngressRules.N.Protocol** to **ALL** or **ICMP**, you do not need to set this parameter. In this case, all ports are available.
            /// </summary>
            [NameInMap("DestinationPortRange")]
            [Validation(Required=false)]
            public string DestinationPortRange { get; set; }

            /// <summary>
            /// The priority of the inbound rule. A smaller value indicates a higher priority.
            /// 
            /// The maximum value of **N** is **10**. You can configure up to 10 inbound rules for a filter.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The protocol that is used by the inbound traffic to be mirrored. Valid values:
            /// 
            /// *   **ALL**: all protocols
            /// *   **ICMP**: ICMP
            /// *   **TCP**: TCP
            /// *   **UDP**: UDP
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The source CIDR block of the inbound traffic.
            /// </summary>
            [NameInMap("SourceCidrBlock")]
            [Validation(Required=false)]
            public string SourceCidrBlock { get; set; }

            /// <summary>
            /// The source port range of the inbound traffic. Valid values for a port: **1** to **65535**. Separate the first port and the last port with a forward slash (/). Examples: **1/200** and **80/80**.
            /// 
            /// >  If you set **IngressRules.N.Protocol** to **ALL** or **ICMP**, you do not need to set this parameter. In this case, all ports are available.
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        public List<CreateTrafficMirrorFilterRequestTag> Tag { get; set; }
        public class CreateTrafficMirrorFilterRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length. The tag key cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
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
        /// The description of the filter.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorFilterDescription")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterDescription { get; set; }

        /// <summary>
        /// The name of the filter.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorFilterName")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterName { get; set; }

    }

}
