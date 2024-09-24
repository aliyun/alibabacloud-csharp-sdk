// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// 
        /// - **accept**: allows the traffic.
        /// - **drop**: blocks the traffic.
        /// - **log**: monitors the traffic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The type of the applications that the access control policy supports. Valid values:
        /// 
        /// - **FTP**
        /// - **HTTP**
        /// - **HTTPS**
        /// - **MySQL**
        /// - **SMTP**
        /// - **SMTPS**
        /// - **RDP**
        /// - **VNC**
        /// - **SSH**
        /// - **Redis**
        /// - **MQTT**
        /// - **MongoDB**
        /// - **Memcache**
        /// - **SSL**
        /// - **ANY**: all types of applications
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The application types supported by the access control policy.
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// The description of the access control policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination port in the access control policy. 
        /// 
        /// >  If **DestPortType** is set to `port`, you must specify this parameter.
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// The name of the destination port address book in the access control policy. 
        /// 
        /// >  If **DestPortType** is set to `group`, you must specify this parameter.
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// The type of the destination port in the access control policy. Valid values:
        /// 
        /// - **port**: port
        /// - **group**: port address book
        /// </summary>
        [NameInMap("DestPortType")]
        [Validation(Required=false)]
        public string DestPortType { get; set; }

        /// <summary>
        /// The destination address in the access control policy. Valid values:
        /// 
        /// - If **DestinationType** is set to `net`, the value of **Destination** must be a CIDR block.
        /// - If **DestinationType** is set to `group`, the value of **Destination** must be an address book.
        /// - If **DestinationType** is set to `domain`, the value of **Destination** must be a domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The type of the destination address in the access control policy. Valid values:
        /// 
        /// - **net**: CIDR block
        /// - **group**: address book
        /// - **domain**: domain name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The domain name resolution method of the access control policy. Valid values:
        /// 
        /// * **FQDN**: fully qualified domain name (FQDN)-based resolution
        /// * **DNS**: DNS-based dynamic resolution
        /// * **FQDN_AND_DNS**: FQDN and DNS-based dynamic resolution
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// The time when the access control policy stops taking effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the start time.
        /// 
        /// >  If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// - **zh**: Chinese (default)
        /// - **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The priority of the access control policy. 
        /// 
        /// The priority value starts from 1. A smaller priority value indicates a higher priority.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// The type of the protocol in the access control policy. Valid values:
        /// 
        /// - **ANY** (If you are not sure about the protocol type, you can set this parameter to ANY.)
        /// - **TCP**
        /// - **UDP**
        /// - **ICMP**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// Specifies whether to enable the access control policy. By default, an access control policy is enabled after the policy is created. Valid values: 
        /// 
        /// - **true**: enables the access control policy.
        /// - **false**: disables the access control policy.
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// The days of a week or of a month on which the access control policy takes effect.
        /// 
        /// *   If you set RepeatType to `Permanent`, `None`, or `Daily`, leave this parameter empty. Example: [].
        /// *   If you set RepeatType to Weekly, you must specify this parameter. Example: [0, 6].
        /// 
        /// >  If you set RepeatType to Weekly, the fields in the value of this parameter cannot be repeated.
        /// 
        /// *   If you set RepeatType to `Monthly`, you must specify this parameter. Example: [1, 31].
        /// 
        /// >  If you set RepeatType to Monthly, the fields in the value of this parameter cannot be repeated.
        /// </summary>
        [NameInMap("RepeatDays")]
        [Validation(Required=false)]
        public List<long?> RepeatDays { get; set; }

        /// <summary>
        /// The point in time when the recurrence ends. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the start time.
        /// 
        /// >  If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// The point in time when the recurrence starts. Example: 08:00. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.
        /// 
        /// >  If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("RepeatStartTime")]
        [Validation(Required=false)]
        public string RepeatStartTime { get; set; }

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
        /// The source address in the access control policy. 
        /// 
        /// - If SourceType is set to `net`, the value of Source must be a CIDR block.
        /// - If SourceType is set to `group`, the value of Source must be an address book.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the source address in the access control policy. Valid values:
        /// 
        /// - **net**: CIDR block
        /// - **group**: address book
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The time when the access control policy starts to take effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the end time.
        /// 
        /// >  If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The ID of the policy group in which you want to create the access control policy. 
        /// 
        /// - If a VPC firewall protects the traffic between two VPCs that are connected by using a CEN instance, the value of this parameter must be the ID of the CEN instance.
        /// - If a VPC firewall protects the traffic between two VPCs that are connected by using an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.
        /// 
        /// >  You can call the [DescribeVpcFirewallAclGroupList](https://www.alibabacloud.com/help/en/cloud-firewall/latest/describevpcfirewallaclgrouplist) operation to query the IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
