// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrderDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of activation codes that have been generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ActivatedCodeCount")]
        [Validation(Required=false)]
        public int? ActivatedCodeCount { get; set; }

        /// <summary>
        /// <para>The quota for requesting activation codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ActivationCodeQuota")]
        [Validation(Required=false)]
        public int? ActivationCodeQuota { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud order, including the virtual order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239618016570503</para>
        /// </summary>
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        /// <summary>
        /// <para>Indicates whether you can leave the System Identifier parameter empty when you generate an activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowEmptySystemIdentifier")]
        [Validation(Required=false)]
        public bool? AllowEmptySystemIdentifier { get; set; }

        /// <summary>
        /// <para>The database type, such as PG, Oracle, or MySQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PG</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The time when the order was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-19 01:13:45</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the order was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether the order is a virtual order. You can pre-generate activation codes for virtual orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsVirtualOrder")]
        [Validation(Required=false)]
        public bool? IsVirtualOrder { get; set; }

        /// <summary>
        /// <para>Indicates whether the virtual order is frozen. If a virtual order is frozen, you can no longer generate activation codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsVirtualOrderFrozen")]
        [Validation(Required=false)]
        public bool? IsVirtualOrderFrozen { get; set; }

        /// <summary>
        /// <para>The package type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>single_node_subscribe: single-node (subscription)</para>
        /// </description></item>
        /// <item><description><para>single_node_long_term: single-node (long-term)</para>
        /// </description></item>
        /// <item><description><para>primary_backup_subscribe: primary/standby (subscription)</para>
        /// </description></item>
        /// <item><description><para>primary_backup_long_term: primary/standby (long-term)</para>
        /// </description></item>
        /// <item><description><para>pre_generation_long_term: pre-generation (long-term)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pre_generation_long_term</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The validity period of the package. The validity period is typically one year or a long-term period of 30 years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 year</para>
        /// </summary>
        [NameInMap("PackageValidity")]
        [Validation(Required=false)]
        public string PackageValidity { get; set; }

        /// <summary>
        /// <para>The purchase channel. Valid values: \<c>aliyun_market\\</c> (Alibaba Cloud Marketplace) and \<c>aliyun_public\\</c> (standard purchase page).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_market</para>
        /// </summary>
        [NameInMap("PurchaseChannel")]
        [Validation(Required=false)]
        public string PurchaseChannel { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C0ACF0-DD29-4B67-9190-B7A48C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The virtual order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239618016570503</para>
        /// </summary>
        [NameInMap("VirtualOrderId")]
        [Validation(Required=false)]
        public string VirtualOrderId { get; set; }

    }

}
