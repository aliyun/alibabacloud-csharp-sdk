// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud order. The value can be the ID of a virtual order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239618016570503</para>
        /// </summary>
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>single_node_subscribe: Single-node Edition (Subscription).</description></item>
        /// <item><description>single_node_long_term: Single-node Edition (Long-term).</description></item>
        /// <item><description>primary_backup_subscribe: HA Edition (Subscription).</description></item>
        /// <item><description>primary_backup_long_term: HA Edition (Long-term).</description></item>
        /// <item><description>pre_generation_long_term: Pre-generated (Long-term).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single_node_subscribe</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The purchase channel. Valid values: aliyun_market and aliyun_public. aliyun_market specifies Alibaba Cloud Marketplace. aliyun_public specifies the PolarDB buy page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_market</para>
        /// </summary>
        [NameInMap("PurchaseChannel")]
        [Validation(Required=false)]
        public string PurchaseChannel { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only virtual orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VirtualOrder")]
        [Validation(Required=false)]
        public bool? VirtualOrder { get; set; }

    }

}
