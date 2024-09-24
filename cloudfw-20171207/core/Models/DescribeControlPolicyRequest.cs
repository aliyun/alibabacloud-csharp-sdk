// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyRequest : TeaModel {
        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// 
        /// *   **accept**: allows the traffic.
        /// *   **drop**: denies the traffic.
        /// *   **log**: monitors the traffic.
        /// 
        /// >  If you do not specify this parameter, access control policies of all action types are queried.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The unique ID of the access control policy.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The description of the access control policy. Fuzzy match is supported.
        /// 
        /// >  If you do not specify this parameter, access control policies that have descriptions are queried.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination address in the access control policy. Fuzzy match is supported. The value of this parameter varies based on the value of the DestinationType parameter.
        /// 
        /// *   If you set DestinationType to `net`, the value of Destination is a CIDR block. Example: 10.0.3.0/24.
        /// *   If you set DestinationType to `domain`, the value of Destination is a domain name. Example: aliyun.
        /// *   If you set DestinationType to `group`, the value of Destination is the name of an address book. Example: db_group.
        /// *   If you set DestinationType to `location`, the value of Destination is the name of a location. For more information about location codes, see AddControlPolicy. Example: ["BJ11", "ZB"].
        /// 
        /// >  If you do not specify this parameter, access control policies of all destination address types are queried.
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The direction of the traffic to which the access control policies apply. Valid values:
        /// 
        /// *   **in**: inbound.
        /// *   **out**: outbound.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The IP version of the address in the access control policy. Valid values:
        /// 
        /// *   **4**: IPv4 (default)
        /// *   **6**: IPv6
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

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
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The type of the protocol in the access control policy. Valid values:
        /// 
        /// * **TCP**
        /// * **UDP**
        /// * **ICMP**
        /// * **ANY**: all types of protocols
        /// 
        /// >  If you do not specify this parameter, access control policies of all protocol types are queried.
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// Specifies whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values:
        /// 
        /// *   **true**: The access control policy is enabled.
        /// *   **false**: The access control policy is disabled.
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// The recurrence type for the access control policy to take effect. Valid values:
        /// 
        /// *   **Permanent** (default): The policy always takes effect.
        /// *   **None**: The policy takes effect for only once.
        /// *   **Daily**: The policy takes effect on a daily basis.
        /// *   **Weekly**: The policy takes effect on a weekly basis.
        /// *   **Monthly**: The policy takes effect on a monthly basis.
        /// </summary>
        [NameInMap("RepeatType")]
        [Validation(Required=false)]
        public string RepeatType { get; set; }

        /// <summary>
        /// The source address in the access control policy. Fuzzy match is supported. The value of this parameter depends on the value of the SourceType parameter.
        /// 
        /// *   If SourceType is set to `net`, the value of Source must be a CIDR block. Example: 192.0.XX.XX/24.
        /// *   If SourceType is set to `group`, the value of Source must be the name of an address book. Example: db_group. If the db_group address book does not contain addresses, all source addresses are queried.
        /// *   If SourceType is set to `location`, the value of Source must be a location. Example: beijing.
        /// 
        /// >  If you do not specify this parameter, access control policies of all source address types are queried.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
