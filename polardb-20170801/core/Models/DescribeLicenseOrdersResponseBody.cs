// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLicenseOrdersResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLicenseOrdersResponseBodyItems> Items { get; set; }
        public class DescribeLicenseOrdersResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivatedCodeCount")]
            [Validation(Required=false)]
            public int? ActivatedCodeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActivationCodeQuota")]
            [Validation(Required=false)]
            public int? ActivationCodeQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public string AliyunOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowEmptySystemIdentifier")]
            [Validation(Required=false)]
            public bool? AllowEmptySystemIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PG</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-02-11 03:14:15</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-02-11 03:14:15</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVirtualOrder")]
            [Validation(Required=false)]
            public bool? IsVirtualOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVirtualOrderFrozen")]
            [Validation(Required=false)]
            public bool? IsVirtualOrderFrozen { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>single_node_subscribe</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1 year</para>
            /// </summary>
            [NameInMap("PackageValidity")]
            [Validation(Required=false)]
            public string PackageValidity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun_public</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>227638319690519</para>
            /// </summary>
            [NameInMap("VirtualAliyunOrderId")]
            [Validation(Required=false)]
            public string VirtualAliyunOrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34458CD3-33E0-4624-BFEF-840C15******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
