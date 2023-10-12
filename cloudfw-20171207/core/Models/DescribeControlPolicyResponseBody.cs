// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The details about the access control policy.
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DescribeControlPolicyResponseBodyPolicys> Policys { get; set; }
        public class DescribeControlPolicyResponseBodyPolicys : TeaModel {
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
            /// The type of the application that the access control policy supports. Valid values:
            /// 
            /// *   **FTP**
            /// *   **HTTP**
            /// *   **HTTPS**
            /// *   **Memcache**
            /// *   **MongoDB**
            /// *   **MQTT**
            /// *   **MySQL**
            /// *   **RDP**
            /// *   **Redis**
            /// *   **SMTP**
            /// *   **SMTPS**
            /// *   **SSH**
            /// *   **SSL**
            /// *   **VNC**
            /// *   **ANY**: all types of applications
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The names of applications.
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
            /// The destination address in the access control policy. The value of this parameter depends on the value of the DestinationType parameter. Valid values:
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
            /// *   **ip**: an address book that includes one or more IP addresses
            /// *   **tag**: an ECS tag-based address book that includes the IP addresses of the ECS instances with one or more specific tags
            /// *   **domain**: an address book that includes one or more domain names
            /// *   **threat**: an address book that includes one or more malicious IP addresses or domain names
            /// *   **backsrc**: an address book that includes one or more back-to-origin addresses of Anti-DDoS Pro or Anti-DDoS Premium instances or WAF instances
            /// </summary>
            [NameInMap("DestinationGroupType")]
            [Validation(Required=false)]
            public string DestinationGroupType { get; set; }

            /// <summary>
            /// The type of the destination address in the access control policy. Valid values:
            /// 
            /// *   **net**: destination CIDR block
            /// *   **group**: destination address book
            /// *   **domain**: destination domain name
            /// *   **location**: destination location
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// The direction of the traffic to which the access control policy applies. Valid values:
            /// 
            /// *   **in**: inbound traffic
            /// *   **out**: outbound traffic
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The DNS resolution result.
            /// </summary>
            [NameInMap("DnsResult")]
            [Validation(Required=false)]
            public string DnsResult { get; set; }

            /// <summary>
            /// The timestamp of the DNS resolution result. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("DnsResultTime")]
            [Validation(Required=false)]
            public long? DnsResultTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The timestamp when the access control policy was last hit. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
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
            /// The IP version of the address in the access control policy. Valid values:
            /// 
            /// *   **4**: IPv4
            /// *   **6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// The time at which the access control policy was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The priority of the access control policy.
            /// 
            /// The priority value starts from 1. A small priority value indicates a high priority.
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
            /// The type of the source address book in the access control policy. Valid values:
            /// 
            /// *   **ip**: an address book that includes one or more IP addresses
            /// *   **tag**: an Elastic Compute Service (ECS) tag-based address book that includes the IP addresses of the ECS instances with one or more specific tags
            /// *   **domain**: an address book that includes one or more domain names
            /// *   **threat**: an address book that includes one or more malicious IP addresses or domain names
            /// *   **backsrc**: an address book that includes one or more back-to-origin addresses of Anti-DDoS Pro or Anti-DDoS Premium instances or Web Application Firewall (WAF) instances
            /// </summary>
            [NameInMap("SourceGroupType")]
            [Validation(Required=false)]
            public string SourceGroupType { get; set; }

            /// <summary>
            /// The type of the source address in the access control policy. Valid values:
            /// 
            /// *   **net**: source CIDR block
            /// *   **group**: source address book
            /// *   **location**: source location
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The total quota consumed by the returned access control policies, which is the sum of the quota consumed by each policy.
            /// 
            /// Quota that is consumed by an access control policy = Number of source CIDR blocks × Number of destination CIDR blocks, destination locations, or IP addresses that are resolved from destination domain names × Number of applications × Number of ports.
            /// </summary>
            [NameInMap("SpreadCnt")]
            [Validation(Required=false)]
            public int? SpreadCnt { get; set; }

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
        /// The total number of the returned access control policies.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
