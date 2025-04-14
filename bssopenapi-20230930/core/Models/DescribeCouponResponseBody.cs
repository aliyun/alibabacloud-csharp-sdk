// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeCouponResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCouponResponseBodyData> Data { get; set; }
        public class DescribeCouponResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>9929.750000</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>59243658</para>
            /// </summary>
            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public long? CouponId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>731074910070</para>
            /// </summary>
            [NameInMap("CouponNo")]
            [Validation(Required=false)]
            public string CouponNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CERTAIN</para>
            /// </summary>
            [NameInMap("CouponType")]
            [Validation(Required=false)]
            public string CouponType { get; set; }

            [NameInMap("CouponTypeName")]
            [Validation(Required=false)]
            public string CouponTypeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-06T15:12Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("ItemNames")]
            [Validation(Required=false)]
            public List<string> ItemNames { get; set; }

            [NameInMap("MoneyLimit")]
            [Validation(Required=false)]
            public string MoneyLimit { get; set; }

            [NameInMap("OrderTimeRule")]
            [Validation(Required=false)]
            public string OrderTimeRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("RemainAmount")]
            [Validation(Required=false)]
            public string RemainAmount { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("ShareUidList")]
            [Validation(Required=false)]
            public List<DescribeCouponResponseBodyDataShareUidList> ShareUidList { get; set; }
            public class DescribeCouponResponseBodyDataShareUidList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1902671110151254</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowSetDeductTagButton")]
            [Validation(Required=false)]
            public bool? ShowSetDeductTagButton { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CHINA</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1902671110151254</para>
            /// </summary>
            [NameInMap("SuitAccount")]
            [Validation(Required=false)]
            public string SuitAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("SuitItemType")]
            [Validation(Required=false)]
            public string SuitItemType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNIVERSAL</para>
            /// </summary>
            [NameInMap("UniversalType")]
            [Validation(Required=false)]
            public string UniversalType { get; set; }

            [NameInMap("YhOrderTypes")]
            [Validation(Required=false)]
            public List<string> YhOrderTypes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C880B065-A781-4F19-B6DD-3E0E3B715C64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
