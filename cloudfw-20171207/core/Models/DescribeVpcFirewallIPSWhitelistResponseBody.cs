// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5EE02F9<b><b>AA49</b></b>F9F8D69483C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the VPC border firewall IPS whitelist.</para>
        /// </summary>
        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists : TeaModel {
            /// <summary>
            /// <para>The list type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: user-defined type</description></item>
            /// <item><description><b>2</b>: address book type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <para>The value of the corresponding list type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.200.4/32,10.10.200.25/32</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC border firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-l6t5yj5fi762******</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>The content of the list type array.</para>
            /// </summary>
            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <para>The whitelist type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: destination type</description></item>
            /// <item><description><b>2</b>: source type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
