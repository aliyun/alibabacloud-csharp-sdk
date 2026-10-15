// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeCouponResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCouponResponseBodyData> Data { get; set; }
        public class DescribeCouponResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The face value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9929.750000</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>CertainAmount</para>
            /// </summary>
            [NameInMap("CertainAmount")]
            [Validation(Required=false)]
            public string CertainAmount { get; set; }

            /// <summary>
            /// <para>The coupon ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59243658</para>
            /// </summary>
            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public long? CouponId { get; set; }

            /// <summary>
            /// <para>The coupon code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>731074910070</para>
            /// </summary>
            [NameInMap("CouponNo")]
            [Validation(Required=false)]
            public string CouponNo { get; set; }

            /// <summary>
            /// <para>The coupon type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CERTAIN</para>
            /// </summary>
            [NameInMap("CouponType")]
            [Validation(Required=false)]
            public string CouponType { get; set; }

            /// <summary>
            /// <para>The coupon type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Threshold discount coupon</para>
            /// </summary>
            [NameInMap("CouponTypeName")]
            [Validation(Required=false)]
            public string CouponTypeName { get; set; }

            /// <summary>
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The end time in ISO 8601 format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-06T15:12Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the coupon is limited to first-time purchases.</para>
            /// </summary>
            [NameInMap("FirstBuy")]
            [Validation(Required=false)]
            public bool? FirstBuy { get; set; }

            /// <summary>
            /// <para>The time when the coupon was issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The list of product codes.</para>
            /// </summary>
            [NameInMap("ItemNames")]
            [Validation(Required=false)]
            public List<string> ItemNames { get; set; }

            /// <summary>
            /// <para>The amount limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No order amount limit</para>
            /// </summary>
            [NameInMap("MoneyLimit")]
            [Validation(Required=false)]
            public string MoneyLimit { get; set; }

            /// <summary>
            /// <para>The order duration limit rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription rule: The coupon can be used only for purchase orders with a duration greater than 3,600 seconds</para>
            /// </summary>
            [NameInMap("OrderTimeRule")]
            [Validation(Required=false)]
            public string OrderTimeRule { get; set; }

            /// <summary>
            /// <para>The remaining amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("RemainAmount")]
            [Validation(Required=false)]
            public string RemainAmount { get; set; }

            /// <summary>
            /// <para>The remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>New purchase on the 28th</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The list of shared accounts.</para>
            /// </summary>
            [NameInMap("ShareUidList")]
            [Validation(Required=false)]
            public List<DescribeCouponResponseBodyDataShareUidList> ShareUidList { get; set; }
            public class DescribeCouponResponseBodyDataShareUidList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1902671110151254</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Computing Ltd</para>
                /// </summary>
                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the tag deduction button is displayed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowSetDeductTagButton")]
            [Validation(Required=false)]
            public bool? ShowSetDeductTagButton { get; set; }

            /// <summary>
            /// <para>The site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHINA</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Official website direct sales</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The start time in ISO 8601 format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The applicable account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1902671110151254</para>
            /// </summary>
            [NameInMap("SuitAccount")]
            [Validation(Required=false)]
            public string SuitAccount { get; set; }

            /// <summary>
            /// <para>The applicable product type: all for all products, white for specified applicable products, and black for specified inapplicable products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("SuitItemType")]
            [Validation(Required=false)]
            public string SuitItemType { get; set; }

            /// <summary>
            /// <para>The application scope of the coupon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNIVERSAL</para>
            /// </summary>
            [NameInMap("UniversalType")]
            [Validation(Required=false)]
            public string UniversalType { get; set; }

            /// <summary>
            /// <para>The list of applicable order types for the coupon.</para>
            /// </summary>
            [NameInMap("YhOrderTypes")]
            [Validation(Required=false)]
            public List<string> YhOrderTypes { get; set; }

        }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C880B065-A781-4F19-B6DD-3E0E3B715C64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
