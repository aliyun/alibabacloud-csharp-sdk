// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelQueryOrderResponseBodyData Data { get; set; }
        public class GlobalHotelQueryOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The buyer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            /// <summary>
            /// <para>The external order number of the buyer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXT_ORDER_001</para>
            /// </summary>
            [NameInMap("ExternalOrderNo")]
            [Validation(Required=false)]
            public string ExternalOrderNo { get; set; }

            /// <summary>
            /// <para>The creation time (UTC millisecond timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672531200000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The item information.</para>
            /// </summary>
            [NameInMap("ItemInfo")]
            [Validation(Required=false)]
            public GlobalHotelQueryOrderResponseBodyDataItemInfo ItemInfo { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataItemInfo : TeaModel {
                /// <summary>
                /// <para>The cancellation policy.</para>
                /// </summary>
                [NameInMap("CancelPolicy")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicy CancelPolicy { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicy : TeaModel {
                    /// <summary>
                    /// <para>The list of cancellation penalty details.</para>
                    /// </summary>
                    [NameInMap("Penalties")]
                    [Validation(Required=false)]
                    public List<GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicyPenalties> Penalties { get; set; }
                    public class GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicyPenalties : TeaModel {
                        /// <summary>
                        /// <para>The currency code (present only for AMOUNT type).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>The effective end time (UTC millisecond timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672617600000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public string End { get; set; }

                        /// <summary>
                        /// <para>The penalty type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PERCENTAGE</para>
                        /// </summary>
                        [NameInMap("PenaltyType")]
                        [Validation(Required=false)]
                        public string PenaltyType { get; set; }

                        /// <summary>
                        /// <para>The penalty value (percentage/amount/number of nights).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("PenaltyValue")]
                        [Validation(Required=false)]
                        public string PenaltyValue { get; set; }

                        /// <summary>
                        /// <para>The effective start time (UTC millisecond timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672531200000</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                        /// <summary>
                        /// <para>TracerId</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TracerId</para>
                        /// </summary>
                        [NameInMap("TracerId")]
                        [Validation(Required=false)]
                        public string TracerId { get; set; }

                    }

                    /// <summary>
                    /// <para>The cancellation policy type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FREE_CANCELLATION</para>
                    /// </summary>
                    [NameInMap("PolicyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                    /// <summary>
                    /// <para>TracerId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The check-in date (yyyy-MM-dd).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-01</para>
                /// </summary>
                [NameInMap("CheckIn")]
                [Validation(Required=false)]
                public string CheckIn { get; set; }

                /// <summary>
                /// <para>The number of guests checking in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CheckInNumber")]
                [Validation(Required=false)]
                public int? CheckInNumber { get; set; }

                /// <summary>
                /// <para>The check-out date (yyyy-MM-dd).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-03</para>
                /// </summary>
                [NameInMap("CheckOut")]
                [Validation(Required=false)]
                public string CheckOut { get; set; }

                /// <summary>
                /// <para>The list of nightly rates.</para>
                /// </summary>
                [NameInMap("DailyPrices")]
                [Validation(Required=false)]
                public List<GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPrices> DailyPrices { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPrices : TeaModel {
                    /// <summary>
                    /// <para>LocalDate</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LocalDate</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>The price.</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPrice Price { get; set; }
                    public class GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPrice : TeaModel {
                        /// <summary>
                        /// <para>The amount in the smallest currency unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public string Amount { get; set; }

                        /// <summary>
                        /// <para>The currency.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>null</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("TracerId")]
                        [Validation(Required=false)]
                        public string TracerId { get; set; }

                    }

                    /// <summary>
                    /// <para>null</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The meal information.</para>
                /// </summary>
                [NameInMap("Meal")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoMeal Meal { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoMeal : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Breakfast included</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The meal type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BREAKFAST</para>
                    /// </summary>
                    [NameInMap("MealType")]
                    [Validation(Required=false)]
                    public string MealType { get; set; }

                    /// <summary>
                    /// <para>TracerId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The number of rooms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RoomCount")]
                [Validation(Required=false)]
                public int? RoomCount { get; set; }

                /// <summary>
                /// <para>The total selling price.</para>
                /// </summary>
                [NameInMap("TotalPrice")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoTotalPrice TotalPrice { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoTotalPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>574</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code (ISO 4217).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>null</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

            }

            /// <summary>
            /// <para>The order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SO202606290001</para>
            /// </summary>
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            /// <summary>
            /// <para>The payment information.</para>
            /// </summary>
            [NameInMap("Payment")]
            [Validation(Required=false)]
            public GlobalHotelQueryOrderResponseBodyDataPayment Payment { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataPayment : TeaModel {
                /// <summary>
                /// <para>The payment amount.</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataPaymentAmount Amount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataPaymentAmount : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code (ISO 4217).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>TracerId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The payment completion time (UTC millisecond timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672531200000</para>
                /// </summary>
                [NameInMap("GmtPaid")]
                [Validation(Required=false)]
                public string GmtPaid { get; set; }

                /// <summary>
                /// <para>The payment method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BALANCE</para>
                /// </summary>
                [NameInMap("PaymentMethod")]
                [Validation(Required=false)]
                public string PaymentMethod { get; set; }

                /// <summary>
                /// <para>The payment transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PAY202606290001</para>
                /// </summary>
                [NameInMap("PaymentTransactionId")]
                [Validation(Required=false)]
                public string PaymentTransactionId { get; set; }

            }

            /// <summary>
            /// <para>The list of refund orders.</para>
            /// </summary>
            [NameInMap("RefundOrders")]
            [Validation(Required=false)]
            public List<GlobalHotelQueryOrderResponseBodyDataRefundOrders> RefundOrders { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataRefundOrders : TeaModel {
                /// <summary>
                /// <para>The refund order creation time (UTC millisecond timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672531200000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The external refund order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RF202606290001</para>
                /// </summary>
                [NameInMap("RefundOrderNo")]
                [Validation(Required=false)]
                public string RefundOrderNo { get; set; }

                /// <summary>
                /// <para>The refund transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TXN001</para>
                /// </summary>
                [NameInMap("RefundTransactionId")]
                [Validation(Required=false)]
                public string RefundTransactionId { get; set; }

                /// <summary>
                /// <para>The rejection reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Supplier rejected</para>
                /// </summary>
                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                /// <summary>
                /// <para>The unified refund status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFUNDED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The penalty amount on the sales side.</para>
                /// </summary>
                [NameInMap("TotalPenaltyAmount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalPenaltyAmount TotalPenaltyAmount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalPenaltyAmount : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code (ISO 4217).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>TraceId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The actual refund amount.</para>
                /// </summary>
                [NameInMap("TotalRefundAmount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalRefundAmount TotalRefundAmount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalRefundAmount : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code (ISO 4217).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>TraceId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of room stays.</para>
            /// </summary>
            [NameInMap("RoomStays")]
            [Validation(Required=false)]
            public List<GlobalHotelQueryOrderResponseBodyDataRoomStays> RoomStays { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataRoomStays : TeaModel {
                /// <summary>
                /// <para>The room confirmation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONF001</para>
                /// </summary>
                [NameInMap("ConfirmationId")]
                [Validation(Required=false)]
                public string ConfirmationId { get; set; }

                /// <summary>
                /// <para>The list of guests.</para>
                /// </summary>
                [NameInMap("Guests")]
                [Validation(Required=false)]
                public List<GlobalHotelQueryOrderResponseBodyDataRoomStaysGuests> Guests { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRoomStaysGuests : TeaModel {
                    /// <summary>
                    /// <para>The first name of the guest.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("FirstName")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <para>The last name of the guest.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Doe</para>
                    /// </summary>
                    [NameInMap("LastName")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <para>TraceId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The room index, starting from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RoomIndex")]
                [Validation(Required=false)]
                public int? RoomIndex { get; set; }

                /// <summary>
                /// <para>The fulfillment status (PENDING_CHECKIN/CHECKED_IN/CHECKED_OUT/CANCELLED). The value is null before the fulfillment is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECKED_IN</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The sales channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POP</para>
            /// </summary>
            [NameInMap("SalesChannel")]
            [Validation(Required=false)]
            public string SalesChannel { get; set; }

            /// <summary>
            /// <para>The unified order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONFIRMED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>TracerId</para>
            /// 
            /// <b>Example:</b>
            /// <para>TracerId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to create order</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TracerId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TracerId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
