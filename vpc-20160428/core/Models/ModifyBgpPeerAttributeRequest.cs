// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyBgpPeerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The BFD hop count. Valid values: <b>1</b> to <b>255</b>.</para>
        /// <para>This parameter is required when BFD is enabled.
        /// Enter the BFD hop count, which specifies the maximum number of devices that data passes through from the source to the destination. You can configure different hop counts based on the actual physical link conditions.</para>
        /// <remarks>
        /// <para>If you use BFD in a multi-cloud environment or a direct fiber connection topology where no bridging devices exist, change the default BFD hop count from <b>255</b> to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BfdMultiHop")]
        [Validation(Required=false)]
        public int? BfdMultiHop { get; set; }

        /// <summary>
        /// <para>The ID of the BGP group to which the BGP peer belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bgpg-m5eo12jxuw2hc0uqq****</para>
        /// </summary>
        [NameInMap("BgpGroupId")]
        [Validation(Required=false)]
        public string BgpGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the BGP peer whose attributes you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bgp-m5eoyp2mwegk8ce9v****</para>
        /// </summary>
        [NameInMap("BgpPeerId")]
        [Validation(Required=false)]
        public string BgpPeerId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>The client generates the value. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Bidirectional Forwarding Detection (BFD). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables BFD.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not enable BFD.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableBfd")]
        [Validation(Required=false)]
        public bool? EnableBfd { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IP address of the BGP peer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("PeerIpAddress")]
        [Validation(Required=false)]
        public string PeerIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the BGP group to which the BGP peer belongs. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
