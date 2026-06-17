// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud order ID. This can be a virtual order ID.</para>
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
        /// <para>The package type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>single_node_subscribe: single node (subscription)</para>
        /// </description></item>
        /// <item><description><para>single_node_long_term: single node (long-term)</para>
        /// </description></item>
        /// <item><description><para>primary_backup_subscribe: primary/standby (subscription)</para>
        /// </description></item>
        /// <item><description><para>primary_backup_long_term: primary/standby (long-term)</para>
        /// </description></item>
        /// <item><description><para>pre_generation_long_term: pre-generated (long-term)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single_node_subscribe</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The page number to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The purchase channel. Valid values: \<c>aliyun_market\\</c> (Alibaba Cloud Marketplace) and \<c>aliyun_public\\</c> (standard purchase page).</para>
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
