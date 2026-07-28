// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CheckCanAllocateVpcPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The type of the private IP address to check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ipv4</b>: IPv4. This parameter is optional when the private IP address is of the IPv4 type.</description></item>
        /// <item><description><b>ipv6</b>: IPv6. This parameter is required when the private IP address is of the IPv6 type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The private IP address to check. The private IP address must belong to the vSwitch specified by the <b>VSwitchId</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.7</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch to which the private IP address belongs.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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

        /// <summary>
        /// <para>The ID of the vSwitch to which the private IP address belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-m5ew3t46z2drmifnt****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
