// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The action that Cloud Firewall performs on the traffic.
        /// 
        /// Valid values:
        /// 
        /// *   **accept**: allows the traffic.
        /// *   **drop**: denies the traffic.
        /// *   **log**: monitors the traffic.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The UUID of the access control policy.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The description of the access control policy. Fuzzy match is supported.
        /// 
        /// > If you do not specify this parameter, the descriptions of all policies are queried.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination address in the access control policy. Fuzzy match is supported. The value of this parameter varies based on the value of the DestinationType parameter.
        /// 
        /// *   If DestinationType is set to `net`, the value of Destination must be a CIDR block. Example: 10.0.3.0/24.
        /// *   If DestinationType is set to `domain`, the value of Destination must be a domain name. Example: aliyun.
        /// *   If DestinationType is set to `group`, the value of Destination must be the name of an address book. Example: db_group.
        /// *   If DestinationType is set to `location`, the value of Destination is a location. For more information about location codes, see [AddControlPolicy](~~474128~~). Example: \["BJ11", "ZB"].
        /// 
        /// > If you do not specify this parameter, all types of destination addresses are queried.
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The direction of the traffic to which the access control policy applies. Valid values:
        /// 
        /// *   **out**: outbound traffic
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The type of the protocol in the access control policy. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// *   **ICMP**
        /// *   **ANY**: all types of protocols
        /// 
        /// > If you do not specify this parameter, access control policies of all protocol types are queried.
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// Specifies whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// The source address in the access control policy. Fuzzy match is supported. The value of this parameter varies based on the value of the SourceType parameter.
        /// 
        /// *   If SourceType is set to `net`, the value of Source must be a CIDR block. Example: 192.0.XX.XX/24.
        /// *   If SourceType is set to `group`, the value of Source must be the name of an address book. Example: db_group. If the db_group address book does not contain addresses, all source addresses are queried.
        /// *   If SourceType is set to `location`, the value of Source must be a location. Example: beijing.
        /// 
        /// > If you do not specify this parameter, all types of source addresses are queried.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
