// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelQueryOrderResponseBodyData Data { get; set; }
        public class GlobalHotelQueryOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXT_ORDER_001</para>
            /// </summary>
            [NameInMap("ExternalOrderNo")]
            [Validation(Required=false)]
            public string ExternalOrderNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1672531200000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("ItemInfo")]
            [Validation(Required=false)]
            public GlobalHotelQueryOrderResponseBodyDataItemInfo ItemInfo { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataItemInfo : TeaModel {
                [NameInMap("CancelPolicy")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicy CancelPolicy { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicy : TeaModel {
                    [NameInMap("Penalties")]
                    [Validation(Required=false)]
                    public List<GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicyPenalties> Penalties { get; set; }
                    public class GlobalHotelQueryOrderResponseBodyDataItemInfoCancelPolicyPenalties : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>USD</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1672617600000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PERCENTAGE</para>
                        /// </summary>
                        [NameInMap("PenaltyType")]
                        [Validation(Required=false)]
                        public string PenaltyType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("PenaltyValue")]
                        [Validation(Required=false)]
                        public string PenaltyValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1672531200000</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public long? Start { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TracerId</para>
                        /// </summary>
                        [NameInMap("TracerId")]
                        [Validation(Required=false)]
                        public string TracerId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FREE_CANCELLATION</para>
                    /// </summary>
                    [NameInMap("PolicyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-01</para>
                /// </summary>
                [NameInMap("CheckIn")]
                [Validation(Required=false)]
                public string CheckIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CheckInNumber")]
                [Validation(Required=false)]
                public int? CheckInNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-03</para>
                /// </summary>
                [NameInMap("CheckOut")]
                [Validation(Required=false)]
                public string CheckOut { get; set; }

                [NameInMap("DailyPrices")]
                [Validation(Required=false)]
                public List<GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPrices> DailyPrices { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPrices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LocalDate</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPrice Price { get; set; }
                    public class GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPrice : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Cent")]
                        [Validation(Required=false)]
                        public long? Cent { get; set; }

                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPriceCurrency Currency { get; set; }
                        public class GlobalHotelQueryOrderResponseBodyDataItemInfoDailyPricesPriceCurrency : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>USD</para>
                            /// </summary>
                            [NameInMap("CurrencyCode")]
                            [Validation(Required=false)]
                            public string CurrencyCode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("DefaultFractionDigits")]
                            [Validation(Required=false)]
                            public int? DefaultFractionDigits { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("NumericCode")]
                            [Validation(Required=false)]
                            public int? NumericCode { get; set; }

                        }

                    }

                }

                [NameInMap("Meal")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoMeal Meal { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoMeal : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>含早餐</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BREAKFAST</para>
                    /// </summary>
                    [NameInMap("MealType")]
                    [Validation(Required=false)]
                    public string MealType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RoomCount")]
                [Validation(Required=false)]
                public int? RoomCount { get; set; }

                [NameInMap("SellingTotalPrice")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataItemInfoSellingTotalPrice SellingTotalPrice { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataItemInfoSellingTotalPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SO202606290001</para>
            /// </summary>
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("Payment")]
            [Validation(Required=false)]
            public GlobalHotelQueryOrderResponseBodyDataPayment Payment { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataPayment : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataPaymentAmount Amount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataPaymentAmount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1672531200000</para>
                /// </summary>
                [NameInMap("GmtPaid")]
                [Validation(Required=false)]
                public long? GmtPaid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BALANCE</para>
                /// </summary>
                [NameInMap("PaymentMethod")]
                [Validation(Required=false)]
                public string PaymentMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PAY202606290001</para>
                /// </summary>
                [NameInMap("PaymentTransactionId")]
                [Validation(Required=false)]
                public string PaymentTransactionId { get; set; }

            }

            [NameInMap("RefundOrders")]
            [Validation(Required=false)]
            public List<GlobalHotelQueryOrderResponseBodyDataRefundOrders> RefundOrders { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataRefundOrders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1672531200000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TXN001</para>
                /// </summary>
                [NameInMap("RefundTransactionId")]
                [Validation(Required=false)]
                public string RefundTransactionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>供应商拒绝</para>
                /// </summary>
                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RF202606290001</para>
                /// </summary>
                [NameInMap("SellRefundOrderNo")]
                [Validation(Required=false)]
                public string SellRefundOrderNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFUNDED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalPenaltyAmount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalPenaltyAmount TotalPenaltyAmount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalPenaltyAmount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                [NameInMap("TotalRefundAmount")]
                [Validation(Required=false)]
                public GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalRefundAmount TotalRefundAmount { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRefundOrdersTotalRefundAmount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

            }

            [NameInMap("RoomStays")]
            [Validation(Required=false)]
            public List<GlobalHotelQueryOrderResponseBodyDataRoomStays> RoomStays { get; set; }
            public class GlobalHotelQueryOrderResponseBodyDataRoomStays : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CONF001</para>
                /// </summary>
                [NameInMap("ConfirmationId")]
                [Validation(Required=false)]
                public string ConfirmationId { get; set; }

                [NameInMap("Guests")]
                [Validation(Required=false)]
                public List<GlobalHotelQueryOrderResponseBodyDataRoomStaysGuests> Guests { get; set; }
                public class GlobalHotelQueryOrderResponseBodyDataRoomStaysGuests : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("FirstName")]
                    [Validation(Required=false)]
                    public string FirstName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Doe</para>
                    /// </summary>
                    [NameInMap("LastName")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RoomIndex")]
                [Validation(Required=false)]
                public int? RoomIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>豪华大床房</para>
                /// </summary>
                [NameInMap("RoomName")]
                [Validation(Required=false)]
                public string RoomName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>POP</para>
            /// </summary>
            [NameInMap("SalesChannel")]
            [Validation(Required=false)]
            public string SalesChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CONFIRMED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TracerId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建订单失败</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TracerId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
