// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrderDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of generated activation codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ActivatedCodeCount")]
        [Validation(Required=false)]
        public int? ActivatedCodeCount { get; set; }

        /// <summary>
        /// <para>The maximum number of activation codes that you can apply for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ActivationCodeQuota")]
        [Validation(Required=false)]
        public int? ActivationCodeQuota { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud order ID (including the virtual order ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>239618016570503</para>
        /// </summary>
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        /// <summary>
        /// <para>Indicates whether activation codes can be generated without the system identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowEmptySystemIdentifier")]
        [Validation(Required=false)]
        public bool? AllowEmptySystemIdentifier { get; set; }

        /// <summary>
        /// <para>The type of the engine. Valid values: PG, Oracle, and MySQL.</para>
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
        /// <para>Indicates whether the order is a virtual order (virtual orders allow pre-generation of activation codes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsVirtualOrder")]
        [Validation(Required=false)]
        public bool? IsVirtualOrder { get; set; }

        /// <summary>
        /// <para>Indicates whether the virtual order is frozen (activation codes cannot be generated for a frozen virtual order).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsVirtualOrderFrozen")]
        [Validation(Required=false)]
        public bool? IsVirtualOrderFrozen { get; set; }

        /// <summary>
        /// <para>The plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>single_node_subscribe</description></item>
        /// <item><description>single_node_long_term</description></item>
        /// <item><description>primary_backup_subscribe</description></item>
        /// <item><description>primary_backup_long_term</description></item>
        /// <item><description>pre_generation_long_term</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pre_generation_long_term</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The validity period of the plan, which is one year (common) or thirty years (long-term).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 year</para>
        /// </summary>
        [NameInMap("PackageValidity")]
        [Validation(Required=false)]
        public string PackageValidity { get; set; }

        /// <summary>
        /// <para>The plan validity period, one year (common) or thirty years (long-term).</para>
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
