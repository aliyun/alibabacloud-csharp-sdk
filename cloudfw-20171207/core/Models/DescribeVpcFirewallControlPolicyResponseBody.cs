// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the access control policies.
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeVpcFirewallControlPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// The action that Cloud Firewall performs on the traffic. Valid values:
            /// 
            /// *   **accept**: allows the traffic.
            /// *   **drop**: blocks the traffic.
            /// *   **log**: monitors the traffic.
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
            /// The application ID in the access control policy.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// The application type in the access control policy. Valid values:
            /// 
            /// *   **HTTP**
            /// *   **HTTPS**
            /// *   **MySQL**
            /// *   **SMTP**
            /// *   **SMTPS**
            /// *   **RDP**
            /// *   **VNC**
            /// *   **SSH**
            /// *   **Redis**
            /// *   **MQTT**
            /// *   **MongoDB**
            /// *   **Memcache**
            /// *   **SSL**
            /// *   **ANY**: all application types
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

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
            /// An array that consists of the ports in the destination port address book of the access control policy.
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
            /// The destination address in the access control policy. Valid values:
            /// 
            /// *   If **DestinationType** is set to `net`, the value of this parameter is a CIDR block.
            /// *   If **DestinationType** is set to `domain`, the value of this parameter is a domain name.
            /// *   If **DestinationType** is set to `group`, the value of this parameter is an address book name.
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// An array that consists of the CIDR blocks in the destination address book of the access control policy.
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
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("HitLastTime")]
            [Validation(Required=false)]
            public long? HitLastTime { get; set; }

            /// <summary>
            /// The number of hits for the access control policy.
            /// </summary>
            [NameInMap("HitTimes")]
            [Validation(Required=false)]
            public long? HitTimes { get; set; }

            /// <summary>
            /// The UID of the member that is managed by your Alibaba Cloud account.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The priority of the access control policy.
            /// 
            /// The priority value starts from 1. A smaller priority value indicates a higher priority.
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// The protocol type in the access control policy. Valid values:
            /// 
            /// *   **TCP**
            /// *   **UDP**
            /// *   **ICMP**
            /// *   **ANY**: all protocol types
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// Indicates whether the access control policy is enabled. By default, an access control policy is enabled after the policy is created. Valid values:
            /// 
            /// *   **true**: The access control policy is enabled.
            /// *   **false**: The access control policy is disabled.
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
            /// *   If **SourceType** is set to `net`, the value of this parameter is a CIDR block.
            /// *   If **SourceType** is set to `group`, the value of this parameter is an address book name.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// An array that consists of the CIDR blocks in the source address book of the access control policy.
            /// </summary>
            [NameInMap("SourceGroupCidrs")]
            [Validation(Required=false)]
            public List<string> SourceGroupCidrs { get; set; }

            /// <summary>
            /// The type of the source address in the access control policy. The value is fixed as **ip**. The value indicates an address book that includes one or more CIDR blocks.
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// The type of the source address in the access control policy. Valid values:
            /// 
            /// *   **net**: CIDR block
            /// *   **group**: address book
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public long? SpreadCnt { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of access control policies returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
