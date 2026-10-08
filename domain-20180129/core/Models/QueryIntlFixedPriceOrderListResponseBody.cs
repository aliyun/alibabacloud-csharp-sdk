// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryIntlFixedPriceOrderListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryIntlFixedPriceOrderListResponseBodyModule Module { get; set; }
        public class QueryIntlFixedPriceOrderListResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>The order list data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryIntlFixedPriceOrderListResponseBodyModuleData> Data { get; set; }
            public class QueryIntlFixedPriceOrderListResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>The business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T2023122019031400****</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715134456000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jslxv.cn</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The order type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>11: international fixed-price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                /// <summary>
                /// <para>The price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15000</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The order status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>5: Transaction closed.</description></item>
                /// <item><description>6: Paid.</description></item>
                /// <item><description>7: Pending production.</description></item>
                /// <item><description>9: Transaction completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715134456000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>545684317770****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6CB3623-4726-4947-AC2B-2C6E673B447C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
