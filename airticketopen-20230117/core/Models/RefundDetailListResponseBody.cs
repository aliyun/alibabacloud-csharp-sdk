// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundDetailListResponseBodyData Data { get; set; }
        public class RefundDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>refund order list</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<RefundDetailListResponseBodyDataList> List { get; set; }
            public class RefundDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>whether it is a supplementary refund order (if the refund amount is not enough, you can use RefundApply to create a supplementary refund order)</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_multi_refund")]
                [Validation(Required=false)]
                public bool? IsMultiRefund { get; set; }

                /// <summary>
                /// <para>order number that returned by Book</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2345</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                /// <summary>
                /// <para>refund order number that returned by RefundApply</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****950</para>
                /// </summary>
                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                /// <summary>
                /// <para>refund order status </para>
                /// <para>0: refund application</para>
                /// <para>1: refund in progress</para>
                /// <para>2: refund failed</para>
                /// <para>3: refund succeeded</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("refund_order_status")]
                [Validation(Required=false)]
                public int? RefundOrderStatus { get; set; }

                /// <summary>
                /// <para>the original refund order number associated with this supplementary refund order, only avaliable when is_multi_refund=true</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884*****2387</para>
                /// </summary>
                [NameInMap("related_refund_order_num")]
                [Validation(Required=false)]
                public string RelatedRefundOrderNum { get; set; }

                /// <summary>
                /// <para>transaction number</para>
                /// 
                /// <b>Example:</b>
                /// <para>49884**tde-95za</para>
                /// </summary>
                [NameInMap("transaction_no")]
                [Validation(Required=false)]
                public string TransactionNo { get; set; }

                /// <summary>
                /// <para>refund time(timestamp)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677229002000</para>
                /// </summary>
                [NameInMap("utc_create_time")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

            /// <summary>
            /// <para>information of pagination</para>
            /// </summary>
            [NameInMap("pagination")]
            [Validation(Required=false)]
            public RefundDetailListResponseBodyDataPagination Pagination { get; set; }
            public class RefundDetailListResponseBodyDataPagination : TeaModel {
                /// <summary>
                /// <para>current page index</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("current_page")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>page size</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("page_size")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>the number of total refund orders</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("total_count")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>the number of total pages</para>
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
        /// <para>error data</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http reqeust has been processed successfully，status code is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
