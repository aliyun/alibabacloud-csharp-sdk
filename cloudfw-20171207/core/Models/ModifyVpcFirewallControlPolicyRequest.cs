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
        /// - **accept**: allows the traffic.
        /// - **drop**: denies the traffic.
        /// - **log**: monitors the traffic.
        /// </summary>
        [NameInMap("AclAction")]
        [Validation(Required=false)]
        public string AclAction { get; set; }

        /// <summary>
        /// The ID of the access control policy. 
        /// 
        /// If you want to modify the configurations of an access control policy, you must provide the ID of the policy. You can call the [DescribeVpcFirewallControlPolicy](https://www.alibabacloud.com/help/en/cloud-firewall/latest/describevpcfirewallcontrolpolicy#doc-api-Cloudfw-DescribeVpcFirewallControlPolicy) operation to query the ID.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The type of the application that the access control policy supports. 
        /// 
        /// Valid values:
        /// 
        /// - FTP
        /// - HTTP
        /// - HTTPS
        /// - MySQL
        /// - SMTP
        /// - SMTPS
        /// - RDP
        /// - VNC
        /// - SSH
        /// - Redis
        /// - MQTT
        /// - MongoDB
        /// - Memcache
        /// - SSL
        /// - ANY: all types of applications
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

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
        /// - **port**: port
        /// - **group**: port address book
        /// </summary>
        [NameInMap("DestPortType")]
        [Validation(Required=false)]
        public string DestPortType { get; set; }

        /// <summary>
        /// The destination address in the access control policy. 
        /// 
        /// - If **DestinationType** is set to `net`, the value of Destination is a CIDR block.  
        /// 
        /// Example: 10.2.3.0/24
        /// - If **DestinationType** is set to `group`, the value of Destination is an address book.  
        /// 
        /// Example: db_group
        /// - If **DestinationType** is set to `domain`, the value of Destination is a domain name.  
        /// 
        /// Example: *.aliyuncs.com
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// The type of the destination address in the access control policy. 
        /// 
        /// Valid values:
        /// 
        /// - **net**: destination CIDR block
        /// - **group**: destination address book
        /// - **domain**: destination domain name
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The natural language of the request and response. 
        /// 
        /// Valid values:
        /// 
        /// - **zh**: Chinese
        /// - **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the protocol in the access control policy. 
        /// 
        /// Valid values:
        /// 
        /// - ANY: all types of protocols
        /// - TCP
        /// - UDP
        /// - ICMP
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// Indicates whether the access control policy is enabled. By default, an access control policy is enabled after it is created. Valid values: 
        /// 
        /// - **true**: The access control policy is enabled.
        /// - **false**: The access control policy is disabled.
        /// </summary>
        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        /// <summary>
        /// The source address in the access control policy. 
        /// 
        /// Valid values:
        /// 
        /// - If **SourceType** is set to `net`, the value of Source is a CIDR block.  
        /// 
        /// Example: 10.2.4.0/24
        /// - If **SourceType** is set to `group`, the value of Source is an address book.  
        /// 
        /// Example: db_group
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the source address in the access control policy. 
        /// 
        /// Valid values:
        /// 
        /// - **net**: source CIDR block
        /// - **group**: source address book
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The ID of the policy group to which the access control policy belongs. You can call the DescribeVpcFirewallAclGroupList operation to query the ID.  
        /// 
        /// - If the VPC firewall is used to protect a CEN instance, the value of this parameter is the ID of the CEN instance.  
        /// 
        /// Example: cen-ervw0g12b5jbw****
        /// - If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall.  
        /// 
        /// Example: vfw-a42bbb7b887148c9****
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
