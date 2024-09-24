// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5EE02F9-4F21-56CA-AA49-F9F8D69483C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the IPS whitelist of the VPC firewall.</para>
        /// </summary>
        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeVpcFirewallIPSWhitelistResponseBodyWhitelists : TeaModel {
            /// <summary>
            /// <para>The type of the list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: user-defined</description></item>
            /// <item><description><b>2</b>: address book</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            /// <summary>
            /// <para>The entries in the list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.200.4/32,10.10.200.25/32</para>
            /// </summary>
            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-57431e9abe424852a578</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>An array of entries in the list.</para>
            /// </summary>
            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            /// <summary>
            /// <para>The type of the whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: destination</description></item>
            /// <item><description><b>2</b>: source</description></item>
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
