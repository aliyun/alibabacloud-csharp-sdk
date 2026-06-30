// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b> (default): No</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>TagKey.N</b> parameter is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is not required when the resource type is Cen or BandwidthPackage. For all other resource types, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource ID. The value of <b>N</b> ranges from <b>1</b> to <b>50</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Resource type. Valid values:</para>
        /// <para><b>Cen</b>: Cloud Enterprise Network (CEN).</para>
        /// <para><b>BandwidthPackage</b>: Bandwidth package.</para>
        /// <para><b>TransitRouter</b>: Transit router.</para>
        /// <para><b>TransitRouterVpcAttachment</b>: VPC attachment.</para>
        /// <para><b>TransitRouterVbrAttachment</b>: VBR attachment.</para>
        /// <para><b>TransitRouterPeerAttachment</b>: Inter-region attachment.</para>
        /// <para><b>TransitRouterVpnAttachment</b>: VPN attachment.</para>
        /// <para><b>TransitRouterRouteTable</b>: Route table.</para>
        /// <para><b>Flowlog</b>: Flow log.</para>
        /// <para><b>TransitRouterMulticastDomain</b>: Multicast domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Tag key.</para>
        /// <para>A tag key can contain up to 64 characters. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// <para>If you specify multiple tag keys, the logical relation among these tag keys is <b>OR</b>. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceDept</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
