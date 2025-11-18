// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyResponseBody : TeaModel {
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
        /// <para>Correctly processed return data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RefundApplyResponseBodyData Data { get; set; }
        public class RefundApplyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>4966***617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <para>List of refund application results</para>
            /// </summary>
            [NameInMap("refund_results")]
            [Validation(Required=false)]
            public List<RefundApplyResponseBodyDataRefundResults> RefundResults { get; set; }
            public class RefundApplyResponseBodyDataRefundResults : TeaModel {
                /// <summary>
                /// <para>Reason for refund application failure</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc reason</para>
                /// </summary>
                [NameInMap("fail_reason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                /// <summary>
                /// <para>Refund order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>4966***617202</para>
                /// </summary>
                [NameInMap("refund_order_num")]
                [Validation(Required=false)]
                public long? RefundOrderNum { get; set; }

                /// <summary>
                /// <para>List of passengers for the refund order</para>
                /// </summary>
                [NameInMap("refund_passengers")]
                [Validation(Required=false)]
                public List<RefundApplyResponseBodyDataRefundResultsRefundPassengers> RefundPassengers { get; set; }
                public class RefundApplyResponseBodyDataRefundResultsRefundPassengers : TeaModel {
                    /// <summary>
                    /// <para>Document number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>411***********4411</para>
                    /// </summary>
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    /// <summary>
                    /// <para>Passenger first name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>Passenger last name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

                /// <summary>
                /// <para>Refund order status 0: Refund order created successfully; 1: Refund order creation failed</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
        /// <para>HTTP request successful, status value is always 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
