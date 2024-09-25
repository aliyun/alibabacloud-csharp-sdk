// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class MoveResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which you want to move the resource.</para>
        /// <remarks>
        /// <para> You can use resource groups to facilitate resource grouping and permission management for an Alibaba Cloud. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">What is resource management?</a></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3peow3k****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the cloud resource belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp31psbg8ec3023s6****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource for which you want to modify the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Vpc</b></description></item>
        /// <item><description><b>Eip</b></description></item>
        /// <item><description><b>BandwidthPackage</b></description></item>
        /// <item><description><b>PrefixList</b></description></item>
        /// <item><description><b>PublicIpAddressPool</b></description></item>
        /// <item><description><b>FlowLog</b></description></item>
        /// <item><description><b>HaVip</b></description></item>
        /// <item><description><b>TrafficMirrorFilter</b></description></item>
        /// <item><description><b>TrafficMirrorSession</b></description></item>
        /// <item><description><b>IPv4Gateway</b></description></item>
        /// <item><description><b>IPv6Gateway</b></description></item>
        /// <item><description><b>DhcpOptionsSet</b></description></item>
        /// <item><description><b>GatewayEndpoint</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
