// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnassociateHaVipRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <c>ClientToken</c> value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully disassociate HaVip from the ECS instance or network interface controller (NIC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>True</b>: forcefully disassociates the instance.</para>
        /// </description></item>
        /// <item><description><para><b>False</b> (default): does not forcefully disassociate the instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>False</b>, the primary instance attached to the HaVip cannot be disassociated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public string Force { get; set; }

        /// <summary>
        /// <para>The ID of the HaVip to be disassociated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-2zeo05qre24nhrqpy****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance or network interface controller (NIC) to disassociate HaVip from.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-faf344422ffsfad****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance to disassociate HaVip from. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>EcsInstance</b>: ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: network interface controller (NIC) instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the instance to be disassociated is a network interface controller (NIC) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the HaVip.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
