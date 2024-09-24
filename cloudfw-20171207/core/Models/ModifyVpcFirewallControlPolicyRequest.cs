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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The unique ID of the access control policy.
        /// 
        /// If you want to modify the configurations of an access control policy, you must provide the unique ID of the policy. You can call the [DescribeVpcFirewallControlPolicy](https://help.aliyun.com/document_detail/159758.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The type of the application that the access control policy supports.
        /// 
        /// Valid values:
        /// 
        /// *   ANY: all application types
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
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The application names.
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
        ///     Example: \\*.aliyuncs.com
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The domain name resolution method of the access control policy. By default, an access control policy is enabled after the policy is created. Valid values:
        /// 
        /// * **FQDN**: fully qualified domain name (FQDN)-based resolution
        /// * **DNS**: DNS-based dynamic resolution
        /// * **FQDN_AND_DNS**: FQDN and DNS-based dynamic resolution
        /// </summary>
        [NameInMap("DomainResolveType")]
        [Validation(Required=false)]
        public string DomainResolveType { get; set; }

        /// <summary>
        /// The time when the access control policy stops taking effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of StartTime.
        /// 
        /// >  If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
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
        /// 
        /// This parameter is required.
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

        /// <summary>
        /// The days of a week or of a month on which the access control policy takes effect.
        /// 
        /// *   If you set RepeatType to `Permanent`, `None`, or `Daily`, the value of this parameter is an empty array. Example: [].
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
        /// The point in time when the recurrence ends. Example: 23:30. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of RepeatStartTime.
        /// 
        /// >  If you set RepeatType to Permanent or None, leave this parameter empty. If you set RepeatType to Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("RepeatEndTime")]
        [Validation(Required=false)]
        public string RepeatEndTime { get; set; }

        /// <summary>
        /// The point in time when the recurrence starts. Example: 08:00. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the value of RepeatEndTime.
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
        /// Valid values:
        /// 
        /// *   If **SourceType** is set to `net`, the value of this parameter must be a CIDR block.
        /// 
        ///     Example: 10.2.4.0/24
        /// 
        /// *   If **SourceType** is set to `group`, the value of this parameter must be an address book name.
        /// 
        ///     Example: db_group
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The time when the access control policy starts to take effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes earlier than the value of EndTime.
        /// 
        /// >  If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall. You can call the [DescribeVpcFirewallAclGroupList](https://help.aliyun.com/document_detail/159760.html) operation to query the ID.
        /// 
        /// *   If the VPC firewall is used to protect a CEN instance, the value of this parameter must be the ID of the CEN instance.
        /// 
        ///     Example: cen-ervw0g12b5jbw\\*\\*\\*\\*
        /// 
        /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.
        /// 
        ///     Example: vfw-a42bbb7b887148c9\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
