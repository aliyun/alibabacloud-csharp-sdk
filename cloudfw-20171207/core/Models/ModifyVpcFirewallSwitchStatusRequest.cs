// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallSwitchStatusRequest : TeaModel {
        /// <summary>
        /// <para>The status of the virtual private cloud (VPC) firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>close</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the member account of the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/342932.html">DescribeVpcFirewallList</a> operation to query the instance ID of the VPC firewall.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
