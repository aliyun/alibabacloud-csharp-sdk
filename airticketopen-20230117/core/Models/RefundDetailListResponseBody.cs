// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
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
        public RefundDetailListResponseBodyData Data { get; set; }
        public class RefundDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<RefundDetailListResponseBodyDataList> List { get; set; }
            public class RefundDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether this is a supplementary refund order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_multi_refund")]
                [Validation(Required=false)]
                public bool? IsMultiRefund { get; set; }

                /// <summary>
                /// <para>The order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2345</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>The refund order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****950</para>
                /// </summary>
                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                /// <summary>
                /// <para>The refund order status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: refund requested.</description></item>
                /// <item><description>1: refund being processed.</description></item>
                /// <item><description>2: refund failed.</description></item>
                /// <item><description>3: refund succeeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("refund_order_status")]
                [Validation(Required=false)]
                public int? RefundOrderStatus { get; set; }

                /// <summary>
                /// <para>The refund order number of the original order associated with this supplementary refund order. This field is returned only for supplementary refund orders and indicates the refund order ID of the associated original order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2387</para>
                /// </summary>
                [NameInMap("related_refund_order_num")]
                [Validation(Required=false)]
                public string RelatedRefundOrderNum { get; set; }

                /// <summary>
                /// <para>The transaction number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884**tde-95za</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UTC timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677229002000</para>
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
            public RefundDetailListResponseBodyDataPagination Pagination { get; set; }
            public class RefundDetailListResponseBodyDataPagination : TeaModel {
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
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
