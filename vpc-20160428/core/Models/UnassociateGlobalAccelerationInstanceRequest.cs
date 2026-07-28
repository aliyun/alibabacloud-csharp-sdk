// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnassociateGlobalAccelerationInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-1sxeedefrr33****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance to disassociate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RemoteEcsInstance</b>: ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>RemoteSlbInstance</b>: load balancing instance.</para>
        /// </description></item>
        /// <item><description><para><b>RemoteEniInstance</b>: network interface controller (NIC) instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RemoteEcsInstance</para>
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
        /// <para>The region where the Alibaba Cloud Global Accelerator (GA) instance is deployed. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
