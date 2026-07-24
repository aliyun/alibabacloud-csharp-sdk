// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailListOfBuyerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeDetailListOfBuyerResponseBodyData Data { get; set; }
        public class ChangeDetailListOfBuyerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ChangeDetailListOfBuyerResponseBodyDataList> List { get; set; }
            public class ChangeDetailListOfBuyerResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The change order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4988430***950</para>
                /// </summary>
                [NameInMap("change_order_num")]
                [Validation(Required=false)]
                public long? ChangeOrderNum { get; set; }

                /// <summary>
                /// <para>The order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4988430***971</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>The application order status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: initial state</description></item>
                /// <item><description>1: pending payment</description></item>
                /// <item><description>2: payment successful</description></item>
                /// <item><description>3: change successful</description></item>
                /// <item><description>4: change closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <para>The payment status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: initial state</description></item>
                /// <item><description>1: pending payment</description></item>
                /// <item><description>2: payment successful</description></item>
                /// <item><description>3: transaction successful</description></item>
                /// <item><description>4: paid order closed successfully</description></item>
                /// <item><description>5: unpaid order closed successfully.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("pay_status")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                /// <summary>
                /// <para>The transaction number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkduendkd-2023-dj0</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                /// <summary>
                /// <para>The order creation time. The value is a UTC timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677415274000</para>
                /// </summary>
                [NameInMap("utc_create_time")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public ChangeDetailListOfBuyerResponseBodyDataPagination Pagination { get; set; }
            public class ChangeDetailListOfBuyerResponseBodyDataPagination : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of records per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>The total number of pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("total_page")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful HTTP requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
