// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:testuser@aliyun.com">testuser@aliyun.com</a></para>
        /// </summary>
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1171915672241348</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Server Load Balancer (SLB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>ResourceOwnerAccount</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:cmdb@5397832129092425.onaliyun.com">cmdb@5397832129092425.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the asset owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1592622395492712</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
