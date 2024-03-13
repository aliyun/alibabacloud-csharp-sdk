// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyControlPolicyRequest : TeaModel {
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
        /// 
        /// >  To modify an access control policy, you must specify the UUID of the policy. You can call the [DescribeControlPolicy](~~138866~~) interface to query the UUID.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The type of the application that the access control policy supports. Valid values:
        /// 
        /// *   **ANY**
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
        /// 
        /// >  The value *ANY* indicates all types of applications.
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
        /// The type of the destination port in the access control policy. Valid values:
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
        /// *   If **DestinationType** is set to net, the value of **Destination** is a CIDR block. Example: 1.2.XX.XX/24.
        /// *   If **DestinationType** is set to group, the value of **Destination** is an address book. Example: db_group.
        /// *   If **DestinationType** is set to domain, the value of **Destination** is a domain name. Example: \*.aliyuncs.com.
        /// *   If **DestinationType** is set to location, the value of **Destination** is a location. For more information about the location codes, see the "AddControlPolicy" topic. Example: \["BJ11", "ZB"].
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The type of the destination address in the access control policy. Valid values:
        /// 
        /// *   **net**: CIDR block
        /// *   **group**: address book
        /// *   **domain**: domain name
        /// *   **location**: location
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
        /// The time when the access control policy stops taking effect. The value is a UNIX timestamp. Unit: seconds. The value must be on the hour or on the half hour, and at least 30 minutes later than the value of StartTime.
        /// 
        /// >  If you set RepeatType to Permanent, leave this parameter empty. If you set RepeatType to None, Daily, Weekly, or Monthly, you must specify this parameter.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The protocol type supported by the access control policy. Valid values:
        /// 
        /// *   **ANY**
        /// *   **TCP**
        /// *   **UDP**
        /// *   **ICMP**
        /// 
        /// >  The value *ANY* indicates all types of applications.
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// The status of the access control policy. Valid values:
        /// 
        /// *   true: enabled
        /// *   false: disabled
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// The days of a week or of a month on which the access control policy takes effect.
        /// 
        /// *   If you set RepeatType to `Permanent`, `None`, or `Daily`, the value of this parameter is an empty array. Example: \[]
        /// *   If you set RepeatType to Weekly, you must specify this parameter. Example: \[0, 6]
        /// 
        /// >  If you set RepeatType to Weekly, the fields in the value of this parameter cannot be repeated.
        /// 
        /// *   If you set RepeatType to `Monthly`, you must specify this parameter. Example: \[1, 31]
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
        /// *   If **SourceType** is set to net, the value of **Source** is a CIDR block. Example: 1.2.XX.XX/24.
        /// *   If **SourceType** is set to group, the value of **Source** is an address book. Example: db_group.
        /// *   If **SourceType** is set to location, the value of **Source** is a location. For more information about the location codes, see the "AddControlPolicy" topic. Example: \["BJ11", "ZB"]
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the source address in the access control policy. Valid values:
        /// 
        /// *   **net**: CIDR block
        /// *   **group**: address book
        /// *   **location**: location
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

    }

}
