// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeApplyResponseBodyData Data { get; set; }
        public class ChangeApplyResponseBodyData : TeaModel {
            [NameInMap("change_orders")]
            [Validation(Required=false)]
            public List<ChangeApplyResponseBodyDataChangeOrders> ChangeOrders { get; set; }
            public class ChangeApplyResponseBodyDataChangeOrders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>49884*****950</para>
                /// </summary>
                [NameInMap("change_order_num")]
                [Validation(Required=false)]
                public long? ChangeOrderNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("change_order_status")]
                [Validation(Required=false)]
                public int? ChangeOrderStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>desc reason</para>
                /// </summary>
                [NameInMap("fail_reason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                [NameInMap("passengers")]
                [Validation(Required=false)]
                public List<ChangeApplyResponseBodyDataChangeOrdersPassengers> Passengers { get; set; }
                public class ChangeApplyResponseBodyDataChangeOrdersPassengers : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>411***********4411</para>
                    /// </summary>
                    [NameInMap("document")]
                    [Validation(Required=false)]
                    public string Document { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SAN</para>
                    /// </summary>
                    [NameInMap("first_name")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZHANG</para>
                    /// </summary>
                    [NameInMap("last_name")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4988430***950</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
