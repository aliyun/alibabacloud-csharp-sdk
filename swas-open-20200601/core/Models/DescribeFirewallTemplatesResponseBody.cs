// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The information about the queried firewall templates.
        /// </summary>
        [NameInMap("FirewallTemplates")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplatesResponseBodyFirewallTemplates> FirewallTemplates { get; set; }
        public class DescribeFirewallTemplatesResponseBodyFirewallTemplates : TeaModel {
            /// <summary>
            /// The time when the firewall template was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// 
            /// >  The time displayed in the Simple Application Server console is in the format of UTC+8.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the firewall template was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the firewall template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the firewall template.
            /// </summary>
            [NameInMap("FirewallTemplateId")]
            [Validation(Required=false)]
            public string FirewallTemplateId { get; set; }

            /// <summary>
            /// The details of the firewall template rules.
            /// </summary>
            [NameInMap("FirewallTemplateRules")]
            [Validation(Required=false)]
            public List<DescribeFirewallTemplatesResponseBodyFirewallTemplatesFirewallTemplateRules> FirewallTemplateRules { get; set; }
            public class DescribeFirewallTemplatesResponseBodyFirewallTemplatesFirewallTemplateRules : TeaModel {
                /// <summary>
                /// The ID of the firewall template rule.
                /// </summary>
                [NameInMap("FirewallTemplateRuleId")]
                [Validation(Required=false)]
                public string FirewallTemplateRuleId { get; set; }

                /// <summary>
                /// The port range. Valid values: 1 to 65535. Specify a port range in the format of \\<start port number>/\\<end port number>. Example: `1024/1055`, which indicates that the port range of 1024 to 1055.
                /// 
                /// >  If you set RuleProtocol to ICMP, you must set Port to -1/-1.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The remarks of the firewall template rule.
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

            }

            /// <summary>
            /// The name of the firewall template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
