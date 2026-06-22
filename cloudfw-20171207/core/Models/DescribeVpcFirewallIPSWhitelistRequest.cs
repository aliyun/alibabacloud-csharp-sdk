// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallIPSWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
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
        /// <para>The UID of the Cloud Firewall member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618****104675</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the VPC firewall protects network instances in a Cloud Enterprise Network (CEN) instance, the instance ID is the CEN instance ID. For CEN Basic Edition, call the <a href="https://help.aliyun.com/document_detail/345777.html">DescribeVpcFirewallCenList</a> operation to query the CEN instance ID. For CEN Enterprise Edition, call the <a href="https://help.aliyun.com/document_detail/2384695.html">DescribeTrFirewallsV2List</a> operation to query the CEN instance ID.</description></item>
        /// <item><description>If the VPC firewall protects traffic between two VPCs connected through Express Connect, the instance ID is the VPC firewall instance ID. Call the <a href="https://help.aliyun.com/document_detail/342932.html">DescribeVpcFirewallList</a> operation to query the VPC firewall instance ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-***</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
