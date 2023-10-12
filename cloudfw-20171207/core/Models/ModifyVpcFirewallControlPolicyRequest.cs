// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The action that Cloud Firewall performs on the traffic.
        /// 
        /// Valid values:
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
        /// 
        /// If you want to modify the configurations of an access control policy, you must provide the unique ID of the policy. You can call the [DescribeVpcFirewallControlPolicy](~~159758~~) operation to query the ID.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The application type in the access control policy.
        /// 
        /// Valid values:
        /// 
        /// *   ANY
        /// *   FTP
        /// *   HTTP
        /// *   HTTPS
        /// *   MySQL
        /// *   SMTP
        /// *   SMTPS
        /// *   RDP
        /// *   VNC
        /// *   SSH
        /// *   Redis
        /// *   MQTT
        /// *   MongoDB
        /// *   Memcache
        /// *   SSL
        /// *   ANY: all application types
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

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
        /// The type of the destination port in the access control policy.
        /// 
        /// *   **port**: port
        /// *   **group**: port address book
        /// </summary>
        [NameInMap("DestPortType")]
        [Validation(Required=false)]
        public string DestPortType { get; set; }

        /// <summary>
        /// The destination address in the access control policy.
        /// 
        /// *   If **DestinationType** is set to `net`, the value of this parameter must be a CIDR block.
        /// 
        ///     Example: 10.2.3.0/24
        /// 
        /// *   If **DestinationType** is set to `group`, the value of this parameter must be an address book name.
        /// 
        ///     Example: db_group
        /// 
        /// *   If **DestinationType** is set to `domain`, the value of this parameter must be a domain name.
        /// 
        ///     Example: \*.aliyuncs.com
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The type of the destination address in the access control policy.
        /// 
        /// Valid values:
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

        /// <summary>
        /// The language of the content within the response.
        /// 
        /// Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The protocol type in the access control policy.
        /// 
        /// Valid values:
        /// 
        /// *   ANY: all protocol types
        /// *   TCP
        /// *   UDP
        /// *   ICMP
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// Specifies whether to enable the access control policy. By default, an access control policy is enabled after the policy is created. Valid values:
        /// 
        /// *   **true**: enables the access control policy.
        /// *   **false**: disables the access control policy.
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
        /// The source address in the access control policy.
        /// 
        /// Valid values:
        /// 
        /// *   If **SourceType** is set to `net`, the value of this parameter must be a CIDR block.
        /// 
        ///     Example: 10.2.4.0/24
        /// 
        /// *   If **SourceType** is set to `group`, the value of this parameter must be an address book name.
        /// 
        ///     Example: db_group
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the source address in the access control policy.
        /// 
        /// Valid values:
        /// 
        /// *   **net**: CIDR block
        /// *   **group**: address book
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall. You can call the [DescribeVpcFirewallAclGroupList](~~159760~~) operation to query the ID.
        /// 
        /// *   If the VPC firewall is used to protect a CEN instance, the value of this parameter must be the ID of the CEN instance.
        /// 
        ///     Example: cen-ervw0g12b5jbw\*\*\*\*
        /// 
        /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.
        /// 
        ///     Example: vfw-a42bbb7b887148c9\*\*\*\*
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
