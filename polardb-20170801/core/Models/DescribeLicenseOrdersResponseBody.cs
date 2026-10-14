// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of orders.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLicenseOrdersResponseBodyItems> Items { get; set; }
        public class DescribeLicenseOrdersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of activation codes that have been generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivatedCodeCount")]
            [Validation(Required=false)]
            public int? ActivatedCodeCount { get; set; }

            /// <summary>
            /// <para>The quota of activation codes that can be requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivationCodeQuota")]
            [Validation(Required=false)]
            public int? ActivationCodeQuota { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud order ID or virtual order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public string AliyunOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the System Identifier field can be left empty when generating an activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowEmptySystemIdentifier")]
            [Validation(Required=false)]
            public bool? AllowEmptySystemIdentifier { get; set; }

            /// <summary>
            /// <para>The database engine type, such as PG, Oracle, or MySQL.</para>
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
            /// <para>The time when the order was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-11 03:14:15</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the order is a virtual order. Virtual orders allow pre-generation of activation codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVirtualOrder")]
            [Validation(Required=false)]
            public bool? IsVirtualOrder { get; set; }

            /// <summary>
            /// <para>Indicates whether the virtual order is frozen. A frozen virtual order does not allow further generation of activation codes.</para>
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
            /// <item><description>single_node_subscribe: single node (subscription).</description></item>
            /// <item><description>single_node_long_term: single node (long-term).</description></item>
            /// <item><description>primary_backup_subscribe: primary/secondary (subscription).</description></item>
            /// <item><description>primary_backup_long_term: primary/secondary (long-term).</description></item>
            /// <item><description>pre_generation_long_term: pre-generation (long-term).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>single_node_subscribe</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The validity period of the package. Typical values are one year or long-term (30 years).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 year</para>
            /// </summary>
            [NameInMap("PackageValidity")]
            [Validation(Required=false)]
            public string PackageValidity { get; set; }

            /// <summary>
            /// <para>The purchase channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>aliyun_market: Alibaba Cloud Marketplace.</description></item>
            /// <item><description>aliyun_public: standard purchase page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_public</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>The virtual order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("VirtualAliyunOrderId")]
            [Validation(Required=false)]
            public string VirtualAliyunOrderId { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
