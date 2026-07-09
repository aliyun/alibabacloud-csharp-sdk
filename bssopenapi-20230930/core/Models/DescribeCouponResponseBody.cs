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
            /// <para>满减券</para>
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
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-06T15:12Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a first purchase restriction.</para>
            /// </summary>
            [NameInMap("FirstBuy")]
            [Validation(Required=false)]
            public bool? FirstBuy { get; set; }

            /// <summary>
            /// <para>The coupon issuance time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The product code list.</para>
            /// </summary>
            [NameInMap("ItemNames")]
            [Validation(Required=false)]
            public List<string> ItemNames { get; set; }

            /// <summary>
            /// <para>The amount limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无订单金额限制</para>
            /// </summary>
            [NameInMap("MoneyLimit")]
            [Validation(Required=false)]
            public string MoneyLimit { get; set; }

            /// <summary>
            /// <para>The order duration limit rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>预付费规则：购买订单时长大于3600s才能使用</para>
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
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新买28号</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The shared account list.</para>
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
                /// <para>阿里云计算有限公司</para>
                /// </summary>
                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether to display the tag deduction button.</para>
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
            /// <para>官网自营</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The start time.</para>
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
            /// <para>The applicable product type. Valid values: all, which indicates that the coupon is applicable to all products. white, which indicates that the coupon is applicable to specified products. black, which indicates that the coupon is not applicable to specified products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("SuitItemType")]
            [Validation(Required=false)]
            public string SuitItemType { get; set; }

            /// <summary>
            /// <para>The coupon applicable scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNIVERSAL</para>
            /// </summary>
            [NameInMap("UniversalType")]
            [Validation(Required=false)]
            public string UniversalType { get; set; }

            /// <summary>
            /// <para>The list of order types applicable to the coupon.</para>
            /// </summary>
            [NameInMap("YhOrderTypes")]
            [Validation(Required=false)]
            public List<string> YhOrderTypes { get; set; }

        }

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
