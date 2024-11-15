// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried orders.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLicenseOrdersResponseBodyItems> Items { get; set; }
        public class DescribeLicenseOrdersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of generated activation codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivatedCodeCount")]
            [Validation(Required=false)]
            public int? ActivatedCodeCount { get; set; }

            /// <summary>
            /// <para>The maximum number of activation codes that you can apply for.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivationCodeQuota")]
            [Validation(Required=false)]
            public int? ActivationCodeQuota { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud order. The ID of a virtual order may be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public string AliyunOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the SystemIdentifier parameter can be left empty when the system generates an activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowEmptySystemIdentifier")]
            [Validation(Required=false)]
            public bool? AllowEmptySystemIdentifier { get; set; }

            /// <summary>
            /// <para>The engine of the PolarDB cluster. Valid values: PG, Oracle, and MySQL.</para>
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
            /// <para>2022-02-11 03:14:15</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the order was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-11 03:14:15</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the order is a virtual order. Pre-generation of activation codes is allowed for virtual orders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVirtualOrder")]
            [Validation(Required=false)]
            public bool? IsVirtualOrder { get; set; }

            /// <summary>
            /// <para>Indicates whether the virtual order is frozen. Generation of activation codes is not allowed for frozen virtual orders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVirtualOrderFrozen")]
            [Validation(Required=false)]
            public bool? IsVirtualOrderFrozen { get; set; }

            /// <summary>
            /// <para>The type of the package. Valid values:</para>
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
            /// <para>The validity period of the package. Valid values: 1 year and 30 years.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 year</para>
            /// </summary>
            [NameInMap("PackageValidity")]
            [Validation(Required=false)]
            public string PackageValidity { get; set; }

            /// <summary>
            /// <para>The purchase channel. Valid values: aliyun_market and aliyun_public. aliyun_market indicates Alibaba Cloud Marketplace. aliyun_public indicates the PolarDB buy page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_public</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>The ID of the virtual order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("VirtualAliyunOrderId")]
            [Validation(Required=false)]
            public string VirtualAliyunOrderId { get; set; }

        }

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
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34458CD3-33E0-4624-BFEF-840C15******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
