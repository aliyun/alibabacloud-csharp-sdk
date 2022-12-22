// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddControlPolicyRequest : TeaModel {
        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// 
        /// * **accept**: allows the traffic.
        /// * **drop**: denies the traffic.
        /// * **log**: monitors the traffic.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The type of the application that the access control policy supports. Valid values:
        /// 
        /// * **FTP**
        /// * **HTTP**
        /// * **HTTPS**
        /// * **Memcache**
        /// * **MongoDB**
        /// * **MQTT**
        /// * **MySQL**
        /// * **RDP**
        /// * **Redis**
        /// * **SMTP**
        /// * **SMTPS**
        /// * **SSH**
        /// * **SSL_No_Cert**
        /// * **SSL**
        /// * **VNC**
        /// * **ANY**: all types of applications
        /// 
        /// > The value of this parameter depends on the value of Proto. If Proto is set to TCP, you can set ApplicationName to any valid value. If Proto is set to UDP, ICMP, or ANY, you can set ApplicationName only to ANY.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The types of the application that the access control policy supports.
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
        /// The destination port in the access control policy. Valid values:
        /// 
        /// * If Proto is set to ICMP, the value of DestPort is empty.
        /// 
        /// > If Proto is set to ICMP, access control does not take effect on the destination port.
        /// 
        /// * If Proto is set to TCP, UDP, or ANY and DestPortType is set to group, the value of DestPort is empty.
        /// 
        /// > If DestPortType is set to group, you do not need to specify the destination port number. All ports that the access control policy controls are included in the destination port address book.
        /// 
        /// * If Proto is set to TCP, UDP, or ANY and DestPortType is set to port, the value of DestPort is the destination port number.
        /// </summary>
        [NameInMap("DestPort")]
        [Validation(Required=false)]
        public string DestPort { get; set; }

        /// <summary>
        /// The name of the destination port address book in the access control policy.
        /// 
        /// >  If DestPortType is set to group, you must specify the name of the destination port address book.
        /// </summary>
        [NameInMap("DestPortGroup")]
        [Validation(Required=false)]
        public string DestPortGroup { get; set; }

        /// <summary>
        /// The type of the destination port in the access control policy.
        /// 
        /// Valid values:
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
        /// Valid values:
        /// 
        /// * If DestinationType is set to net, the value of this parameter is a CIDR block.
        /// 
        ///     Example: 1.2.XX.XX/24
        /// 
        /// * If DestinationType is set to group, the value of this parameter is an address book.
        /// 
        ///     Example: db_group
        /// 
        /// * If DestinationType is set to domain, the value of this parameter is a domain name.
        /// 
        ///     Example: \*.aliyuncs.com
        /// 
        /// * If DestinationType is set to location, the value of this parameter is a location.
        /// 
        ///     Example: \["BJ11", "ZB"]
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The type of the destination address in the access control policy. Valid values:
        /// 
        /// * **net**: destination CIDR block
        /// * **group**: destination address book
        /// * **domain**: destination domain name
        /// * **location**: destination location
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The direction of the traffic to which the access control policy applies. Valid values:
        /// 
        /// * **in**: inbound traffic
        /// * **out**: outbound traffic
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The IP version of the address in the access control policy.
        /// 
        /// Valid values:
        /// 
        /// * **4**: IPv4
        /// * **6**: IPv6
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// * **zh**: Chinese (default)
        /// * **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The priority of the access control policy. The priority value starts from 1. A small priority value indicates a high priority.
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// The type of the protocol in the access control policy. Valid values:
        /// 
        /// * **ANY**: any protocol type
        /// * **TCP**
        /// * **UDP**
        /// * **ICMP**
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
        /// The source address in the access control policy. Valid values:
        /// 
        /// * If SourceType is set to net, the value of this parameter is a CIDR block.
        /// 
        ///     Example: 1.1.XX.XX/24
        /// 
        /// * If SourceType is set to group, the value of this parameter is an address book.
        /// 
        ///     Example: db_group
        /// 
        /// * If SourceType is set to location, the value of this parameter is a location.
        /// 
        ///     Example: \["BJ11", "ZB"]
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the source address book in the access control policy. Valid values:
        /// 
        /// * **net**: source CIDR block
        /// * **group**: source address book
        /// * **location**: source location
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
