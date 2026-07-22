// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPrecheckDetailRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-hxsqf2bv6di1a****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The language type. Valid values:</para>
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
        /// <para>The UID of the Cloud Firewall member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>134388541648****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cen_firewall</b>: CEN basic edition firewall</para>
        /// </description></item>
        /// <item><description><para><b>cen_tr_firewall</b>: CEN-TR firewall</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cen_firewall</para>
        /// </summary>
        [NameInMap("NetworkInstanceType")]
        [Validation(Required=false)]
        public string NetworkInstanceType { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required. If it is not specified, ErrorParameters is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The transit router instance ID. You must specify at least one of VpcId and TransitRouterId. Specify VpcId when querying a basic edition firewall, or specify TransitRouterId when querying a transit router (TR) scenario. If neither is specified, ErrorParameters is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-2vcn4u2g86tm72****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The VPC-connected instance ID. You must specify at least one of VpcId and TransitRouterId. Specify VpcId when querying a basic edition firewall, or specify TransitRouterId when querying a forward routing (TR) scenario. If neither is specified, ErrorParameters is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zev8s8rxao33xt****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
