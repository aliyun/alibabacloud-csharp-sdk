// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListCouponUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCouponUsageResponseBodyData> Data { get; set; }
        public class ListCouponUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:oqevfbveuadcrduzmf@ttirv.net">oqevfbveuadcrduzmf@ttirv.net</a></para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The face value of the coupon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            /// <summary>
            /// <para>The remaining balance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public double? Balance { get; set; }

            /// <summary>
            /// <para>The ID of the coupon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59226280</para>
            /// </summary>
            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public string CouponId { get; set; }

            /// <summary>
            /// <para>The ID of the coupon template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503802</para>
            /// </summary>
            [NameInMap("CouponTemplateId")]
            [Validation(Required=false)]
            public long? CouponTemplateId { get; set; }

            /// <summary>
            /// <para>The validity period of the coupon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-06 00:00:00 ~ 2023-04-07 00:00:00</para>
            /// </summary>
            [NameInMap("EffDate")]
            [Validation(Required=false)]
            public string EffDate { get; set; }

            /// <summary>
            /// <para>The time when the coupon was issued. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-06 19:32:10</para>
            /// </summary>
            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

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
            /// <para>The UID of the T2 partner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5248516956402795</para>
            /// </summary>
            [NameInMap("T2PartnerUid")]
            [Validation(Required=false)]
            public string T2PartnerUid { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647668856741998</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCouponUsageResponseBodyPageInfo PageInfo { get; set; }
        public class ListCouponUsageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can provide this ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
