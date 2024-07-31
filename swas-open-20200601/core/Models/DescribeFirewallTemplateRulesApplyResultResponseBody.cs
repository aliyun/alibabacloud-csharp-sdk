// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplateRulesApplyResultResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplateRulesApplyResultResponseBodyData> Data { get; set; }
        public class DescribeFirewallTemplateRulesApplyResultResponseBodyData : TeaModel {
            /// <summary>
            /// The error codes when the firewall template rule fails to be applied.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message that is displayed when the firewall template rule fails to be applied.
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// The port range. Valid values: 1 to 65535. Specify a port range in the format of \\<start port number>/\\<end port number>. Example: `1024/1055`, which indicates that the port range of 1024 to 1055.
            /// 
            /// >  If you set RuleProtocol to ICMP, you must set Port to -1/-1.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The remarks of the firewall rule.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The transport layer protocol that the rule supports. Valid values:
            /// 
            /// *   TCP
            /// *   UDP
            /// *   TCP+UDP
            /// *   ICMP
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// The source address to which you want to grant access permissions. CIDR blocks and IPv4 addresses are supported.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// The status of applying the firewall template rule to the simple application servers.
            /// 
            /// *   Pending: The template rule does not start to be applied to the simple application servers.
            /// *   Applying: The template rule is being applied to the simple application servers.
            /// *   Success: The template rule is successfully applied to the simple application servers.
            /// *   PartFailed: The template rule fails to be applied to some simple application servers.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
