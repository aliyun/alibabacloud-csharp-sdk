// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried firewall templates.</para>
        /// </summary>
        [NameInMap("FirewallTemplates")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplatesResponseBodyFirewallTemplates> FirewallTemplates { get; set; }
        public class DescribeFirewallTemplatesResponseBodyFirewallTemplates : TeaModel {
            /// <summary>
            /// <para>The time when the firewall template was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// <remarks>
            /// <para> The time displayed in the Simple Application Server console is in the format of UTC+8.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-29T02:01:38Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the firewall template was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10T02:10:14Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the firewall template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the firewall template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ft-bcf1a7hrdq717****</para>
            /// </summary>
            [NameInMap("FirewallTemplateId")]
            [Validation(Required=false)]
            public string FirewallTemplateId { get; set; }

            /// <summary>
            /// <para>The details of the firewall template rules.</para>
            /// </summary>
            [NameInMap("FirewallTemplateRules")]
            [Validation(Required=false)]
            public List<DescribeFirewallTemplatesResponseBodyFirewallTemplatesFirewallTemplateRules> FirewallTemplateRules { get; set; }
            public class DescribeFirewallTemplatesResponseBodyFirewallTemplatesFirewallTemplateRules : TeaModel {
                /// <summary>
                /// <para>The ID of the firewall template rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eeea34d9867b4d55a4ff8d5fcfbd****</para>
                /// </summary>
                [NameInMap("FirewallTemplateRuleId")]
                [Validation(Required=false)]
                public string FirewallTemplateRuleId { get; set; }

                /// <summary>
                /// <para>The port range. Valid values: 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: <c>1024/1055</c>, which indicates that the port range of 1024 to 1055.</para>
                /// <remarks>
                /// <para> If you set RuleProtocol to ICMP, you must set Port to -1/-1.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The remarks of the firewall template rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The transport layer protocol that the rule supports. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// <item><description>TCP+UDP</description></item>
                /// <item><description>ICMP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("RuleProtocol")]
                [Validation(Required=false)]
                public string RuleProtocol { get; set; }

                /// <summary>
                /// <para>The source address to which you want to grant access permissions. CIDR blocks and IPv4 addresses are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>119.145.XX.XX</para>
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

            }

            /// <summary>
            /// <para>The name of the firewall template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
