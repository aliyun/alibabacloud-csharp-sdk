// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallRuleRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The port range.
        /// 
        /// *   When the transport layer protocol is TCP and/or UDP, the port range is 1 to 65535. Specify a port range in the format of \\<start port number>/\\<end port number>. Example: 1024/1055, which specifies the port range from 1024 to 1055.
        /// *   When the transport layer protocol is ICMP, the port range is -1/-1, which indicates all ports.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The region ID of the simple application server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The remarks of the firewall rule.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The transport layer protocol. Valid values:
        /// 
        /// *   TCP
        /// *   UDP
        /// *   TCP+UDP
        /// *   ICMP
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleProtocol")]
        [Validation(Required=false)]
        public string RuleProtocol { get; set; }

    }

}
