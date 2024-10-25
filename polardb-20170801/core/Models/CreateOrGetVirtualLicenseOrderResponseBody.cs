// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateOrGetVirtualLicenseOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>2233****445566</para>
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
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-10-16 16:46:20</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>pre_generation_long_term</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30 years</para>
        /// </summary>
        [NameInMap("PackageValidity")]
        [Validation(Required=false)]
        public string PackageValidity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun_market</para>
        /// </summary>
        [NameInMap("PurchaseChannel")]
        [Validation(Required=false)]
        public string PurchaseChannel { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024********483</para>
        /// </summary>
        [NameInMap("VirtualOrderId")]
        [Validation(Required=false)]
        public string VirtualOrderId { get; set; }

    }

}
