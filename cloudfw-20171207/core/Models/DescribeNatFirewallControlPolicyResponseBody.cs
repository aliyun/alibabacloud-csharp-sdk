// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the access control policies.
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeNatFirewallControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// The action that Cloud Firewall performs on the traffic. Valid values:
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
            /// The application names.
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// The time at which the access control policy was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the access control policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination port in the access control policy.
            /// </summary>
            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public string DestPort { get; set; }

            /// <summary>
            /// The name of the destination port address book in the access control policy.
            /// </summary>
            [NameInMap("DestPortGroup")]
            [Validation(Required=false)]
            public string DestPortGroup { get; set; }

            /// <summary>
            /// The ports in the destination port address book.
            /// </summary>
            [NameInMap("DestPortGroupPorts")]
            [Validation(Required=false)]
            public List<string> DestPortGroupPorts { get; set; }

            /// <summary>
            /// The type of the destination port in the access control policy. Valid values:
            /// 
            /// *   **port**: port
            /// *   **group**: port address book
            /// </summary>
            [NameInMap("DestPortType")]
            [Validation(Required=false)]
            public string DestPortType { get; set; }

            /// <summary>
            /// The destination address in the access control policy. The value of this parameter varies based on the value of the DestinationType parameter. Valid values:
            /// 
            /// *   If **DestinationType** is set to **net**, the value of Destination is a CIDR block. Example: 192.0.XX.XX/24.
            /// *   If **DestinationType** is set to **domain**, the value of Destination is a domain name. Example: aliyuncs.com.
            /// *   If **DestinationType** is set to **group**, the value of Destination is the name of an address book. Example: db_group.
            /// *   If **DestinationType** is set to **location**, the value of Destination is a location. For more information about location codes, see [AddControlPolicy](~~138867~~). Example: \["BJ11", "ZB"].
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// The CIDR blocks in the destination address book.
            /// </summary>
            [NameInMap("DestinationGroupCidrs")]
            [Validation(Required=false)]
            public List<string> DestinationGroupCidrs { get; set; }

            /// <summary>
            /// The type of the destination address book in the access control policy. Valid values:
            /// 
            /// *   **ip**: an address book that includes one or more CIDR blocks
            /// *   **domain**: an address book that includes one or more domain names
            /// </summary>
            [NameInMap("DestinationGroupType")]
            [Validation(Required=false)]
            public string DestinationGroupType { get; set; }

            /// <summary>
            /// The type of the destination address in the access control policy. Valid values:
            /// 
            /// *   **net**: CIDR block
            /// *   **group**: address book
            /// *   **domain**: domain name
            /// *   **location**
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// The DNS resolution result.
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            public string DnsResult { get; set; }

            /// <summary>
            /// The time of the DNS resolution result. The value is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            /// <summary>
            /// The domain name resolution method of the access control policy. By default, an access control policy is enabled after it is created. Valid values:
            /// 
            /// *   **1**: Fully qualified domain name (FQDN)-based
            /// *   **2**: Domain Name System (DNS)-based
            /// *   **3**: FQDN and DNS-based
            /// </summary>
            [NameInMap("DomainResolveType")]
            [Validation(Required=false)]
            public int? DomainResolveType { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The times when the access control policy was last hit. The value is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// The number of hits for the access control policy.
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public int? HitTimes { get; set; }

            /// <summary>
            /// The time at which the access control policy was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The ID of the NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The priority of the access control policy.
            /// 
            /// The priority value starts from 1. A smaller priority value indicates a higher priority.
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// The type of the protocol in the access control policy. Valid values:
            /// 
            /// *   **ANY**
            /// *   **TCP**
            /// *   **UDP**
            /// *   **ICMP**
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// Indicates whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public string Release { get; set; }

            [NameInMap("RepeatDays")]
            [Validation(Required=false)]
            public List<long?> RepeatDays { get; set; }

            [NameInMap("RepeatEndTime")]
            [Validation(Required=false)]
            public string RepeatEndTime { get; set; }

            [NameInMap("RepeatStartTime")]
            [Validation(Required=false)]
            public string RepeatStartTime { get; set; }

            [NameInMap("RepeatType")]
            [Validation(Required=false)]
            public string RepeatType { get; set; }

            /// <summary>
            /// The source address in the access control policy. Valid values:
            /// 
            /// *   If **SourceType** is set to `net`, the value of Source is a CIDR block. Example: 192.0.XX.XX/24.
            /// *   If **SourceType** is set to `group`, the value of Source is the name of an address book. Example: db_group.
            /// *   If **SourceType** is set to `location`, the value of Source is a location. For more information about location codes, see [AddControlPolicy](~~138867~~). Example: \["BJ11", "ZB"].
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The CIDR blocks in the source address book.
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// The type of the source address book in the access control policy. The value is fixed as **ip**. The value indicates an address book that includes one or more CIDR blocks.
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// The type of the source address book in the access control policy. Valid values:
            /// 
            /// *   **net**: CIDR block
            /// *   **group**: address book
            /// *   **location**: location
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The total quota consumed by the returned access control policies, which is the sum of the quota consumed by each policy. The quota that is consumed by an access control policy is calculated based on the following formula: Quota that is consumed by an access control policy = Number of source CIDR blocks × Number of destination CIDR blocks, regions, or resolved domain names × *Number of applications* × Number of ports.
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public string SpreadCnt { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
