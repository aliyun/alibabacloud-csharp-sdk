// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Properly processed return data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundDetailListResponseBodyData Data { get; set; }
        public class RefundDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Data list</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<RefundDetailListResponseBodyDataList> List { get; set; }
            public class RefundDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Whether it is a supplementary refund</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_multi_refund")]
                [Validation(Required=false)]
                public bool? IsMultiRefund { get; set; }

                /// <summary>
                /// <para>Order number （ Ticketing Order Number）</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2345</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>Refund order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****950</para>
                /// </summary>
                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                /// <summary>
                /// <para>Refund order status: 0: Refund application; 1: Refund in progress; 2: Refund failed; 3: Refund succeeded</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("refund_order_status")]
                [Validation(Required=false)]
                public int? RefundOrderStatus { get; set; }

                /// <summary>
                /// <para>The original refund order number associated with this supplementary refund. Only present for supplementary refunds, indicating the ID of the original refund order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2387</para>
                /// </summary>
                [NameInMap("related_refund_order_num")]
                [Validation(Required=false)]
                public string RelatedRefundOrderNum { get; set; }

                /// <summary>
                /// <para>Transaction serial number</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884**tde-95za</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                /// <summary>
                /// <para>Creation time, UTC timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677229002000</para>
                /// </summary>
                [NameInMap("utc_create_time")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

            /// <summary>
            /// <para>Pagination information</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public RefundDetailListResponseBodyDataPagination Pagination { get; set; }
            public class RefundDetailListResponseBodyDataPagination : TeaModel {
                /// <summary>
                /// <para>Current page number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>Number of items per page</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>Total count</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>Total pages</para>
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
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Data carried in error handling</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>HTTP request successful, status value is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Whether the operation was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
