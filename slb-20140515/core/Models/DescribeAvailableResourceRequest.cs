// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the IP address.</para>
        /// <para>Valid values: <b>ipv4 and ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// <para>Valid values: <b>vpc, classic-internet, and classic-intranet</b>.</para>
        /// <para>vpc: an internal Classic Load Balancer (CLB) instance that is deployed in a virtual private cloud (VPC).</para>
        /// <para>classic_internet: a public-facing CLB instance.</para>
        /// <para>classic_intranet: an internal CLB instance that is deployed in a classic network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
