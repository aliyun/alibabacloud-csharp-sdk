// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateOrGetVirtualLicenseOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of generated activation codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The Alibaba Cloud order ID (including the virtual order ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2233****445566</para>
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
        /// <para>The time when the order was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
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
        /// <para>true</para>
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
        /// <para>The plan type.</para>
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
        /// <para>30 years</para>
        /// </summary>
        [NameInMap("PackageValidity")]
        [Validation(Required=false)]
        public string PackageValidity { get; set; }

        /// <summary>
        /// <para>The purchase channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_market</para>
        /// </summary>
        [NameInMap("PurchaseChannel")]
        [Validation(Required=false)]
        public string PurchaseChannel { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024********483</para>
        /// </summary>
        [NameInMap("VirtualOrderId")]
        [Validation(Required=false)]
        public string VirtualOrderId { get; set; }

    }

}
