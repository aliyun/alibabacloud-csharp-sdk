// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListCouponUsageRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud customer account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:oqevfbveuadcrduzmf@ttirv.net">oqevfbveuadcrduzmf@ttirv.net</a></para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The ID of the coupon template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5075915</para>
        /// </summary>
        [NameInMap("CouponTemplateId")]
        [Validation(Required=false)]
        public long? CouponTemplateId { get; set; }

        /// <summary>
        /// <para>The page number.</br> 
        /// Default value: 1. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</br>
        /// Default value: 20. Maximum value: 50. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The coupon status. Valid values:</br>
        /// AVAILABLE: Normal.</br>
        /// EXHAUSTED: Used up.</br>
        /// EXPIRED: Expired.</br>
        /// ABANDONED: Voided.</br></para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The UID of the T2 partner. Example: 123456789.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456768</para>
        /// </summary>
        [NameInMap("T2PartnerUid")]
        [Validation(Required=false)]
        public long? T2PartnerUid { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
