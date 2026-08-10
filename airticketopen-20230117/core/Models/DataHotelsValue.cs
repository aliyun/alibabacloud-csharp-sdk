// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataHotelsValue : TeaModel {
        /// <summary>
        /// <para>The check-in date in the format of yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("CheckInDate")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>The check-out date in the format of yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02</para>
        /// </summary>
        [NameInMap("CheckOutDate")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// <para>The list of available room types for the day.</para>
        /// </summary>
        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public List<DataHotelsValueRooms> Rooms { get; set; }
        public class DataHotelsValueRooms : TeaModel {
            /// <summary>
            /// <para>The standard room type ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R001</para>
            /// </summary>
            [NameInMap("StandardRoomId")]
            [Validation(Required=false)]
            public string StandardRoomId { get; set; }

            /// <summary>
            /// <para>The lowest selling price for the room type on the day.</para>
            /// </summary>
            [NameInMap("LowestSellingPrice")]
            [Validation(Required=false)]
            public DataHotelsValueRoomsLowestSellingPrice LowestSellingPrice { get; set; }
            public class DataHotelsValueRoomsLowestSellingPrice : TeaModel {
                /// <summary>
                /// <para>The amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <para>The currency code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>traceId</para>
                /// 
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>The list of all available offers for the room type. Calendar quotes cannot be used for price verification, so itemOfferKey is not returned.</para>
            /// </summary>
            [NameInMap("Offers")]
            [Validation(Required=false)]
            public List<DataHotelsValueRoomsOffers> Offers { get; set; }
            public class DataHotelsValueRoomsOffers : TeaModel {
                /// <summary>
                /// <para>The item-level offer identifier (price verification key, passed through as-is).</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemOffer_123</para>
                /// </summary>
                [NameInMap("ItemOfferKey")]
                [Validation(Required=false)]
                public string ItemOfferKey { get; set; }

                /// <summary>
                /// <para>The rate plan name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Room with breakfast</para>
                /// </summary>
                [NameInMap("RatePlanName")]
                [Validation(Required=false)]
                public string RatePlanName { get; set; }

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
                /// <para>The number of meals included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MealCount")]
                [Validation(Required=false)]
                public int? MealCount { get; set; }

                /// <summary>
                /// <para>The cancellation policy.</para>
                /// </summary>
                [NameInMap("CancelPolicy")]
                [Validation(Required=false)]
                public DataHotelsValueRoomsOffersCancelPolicy CancelPolicy { get; set; }
                public class DataHotelsValueRoomsOffersCancelPolicy : TeaModel {
                    /// <summary>
                    /// <para>The policy type. Valid values: NON_REFUNDABLE, FREE_CANCELLATION, and PARTIAL_REFUND.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FREE_CANCELLATION</para>
                    /// </summary>
                    [NameInMap("PolicyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                    /// <summary>
                    /// <para>The list of penalty details.</para>
                    /// </summary>
                    [NameInMap("Penalties")]
                    [Validation(Required=false)]
                    public List<DataHotelsValueRoomsOffersCancelPolicyPenalties> Penalties { get; set; }
                    public class DataHotelsValueRoomsOffersCancelPolicyPenalties : TeaModel {
                        /// <summary>
                        /// <para>The effective start time, in UTC millisecond timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672531200000</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public long? Start { get; set; }

                        /// <summary>
                        /// <para>The effective end time, in UTC millisecond timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672617600000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        /// <summary>
                        /// <para>The penalty type. Valid values: PERCENTAGE, AMOUNT, and NIGHTS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PERCENTAGE</para>
                        /// </summary>
                        [NameInMap("PenaltyType")]
                        [Validation(Required=false)]
                        public string PenaltyType { get; set; }

                        /// <summary>
                        /// <para>The penalty value (percentage, amount, or number of nights).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("PenaltyValue")]
                        [Validation(Required=false)]
                        public string PenaltyValue { get; set; }

                        /// <summary>
                        /// <para>The currency. This parameter has a value only when PenaltyType is set to AMOUNT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>traceId</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TraceId</para>
                        /// </summary>
                        [NameInMap("TracerId")]
                        [Validation(Required=false)]
                        public string TracerId { get; set; }

                    }

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
                /// <para>The total selling price.</para>
                /// </summary>
                [NameInMap("SellingTotalPrice")]
                [Validation(Required=false)]
                public DataHotelsValueRoomsOffersSellingTotalPrice SellingTotalPrice { get; set; }
                public class DataHotelsValueRoomsOffersSellingTotalPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public double? Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code.</para>
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
                /// <para>The list of daily selling prices.</para>
                /// </summary>
                [NameInMap("SellingDailyPrices")]
                [Validation(Required=false)]
                public List<DataHotelsValueRoomsOffersSellingDailyPrices> SellingDailyPrices { get; set; }
                public class DataHotelsValueRoomsOffersSellingDailyPrices : TeaModel {
                    /// <summary>
                    /// <para>The check-in date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-07-01</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>The price for the day.</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public DataHotelsValueRoomsOffersSellingDailyPricesPrice Price { get; set; }
                    public class DataHotelsValueRoomsOffersSellingDailyPricesPrice : TeaModel {
                        /// <summary>
                        /// <para>The amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.00</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public double? Amount { get; set; }

                        /// <summary>
                        /// <para>The currency code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USD</para>
                        /// </summary>
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>traceId</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TraceId</para>
                        /// </summary>
                        [NameInMap("TracerId")]
                        [Validation(Required=false)]
                        public string TracerId { get; set; }

                    }

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
                /// <para>The number of available rooms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AvailableRooms")]
                [Validation(Required=false)]
                public int? AvailableRooms { get; set; }

                /// <summary>
                /// <para>The maximum number of guests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxOccupancy")]
                [Validation(Required=false)]
                public int? MaxOccupancy { get; set; }

                /// <summary>
                /// <para>The confirmation type. Valid values: INSTANT_CONFIRM and NON_INSTANT_CONFIRM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANT_CONFIRM</para>
                /// </summary>
                [NameInMap("ConfirmType")]
                [Validation(Required=false)]
                public string ConfirmType { get; set; }

            }

        }

        /// <summary>
        /// <para>The standard room type ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R001</para>
        /// </summary>
        [NameInMap("StandardRoomId")]
        [Validation(Required=false)]
        public string StandardRoomId { get; set; }

        /// <summary>
        /// <para>All available offers for the room type.</para>
        /// </summary>
        [NameInMap("Offers")]
        [Validation(Required=false)]
        public List<DataHotelsValueOffers> Offers { get; set; }
        public class DataHotelsValueOffers : TeaModel {
            /// <summary>
            /// <para>The item-domain offer identifier (price verification key, passed through as-is).</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemOffer_123</para>
            /// </summary>
            [NameInMap("ItemOfferKey")]
            [Validation(Required=false)]
            public string ItemOfferKey { get; set; }

            /// <summary>
            /// <para>The rate plan name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Breakfast Included</para>
            /// </summary>
            [NameInMap("RatePlanName")]
            [Validation(Required=false)]
            public string RatePlanName { get; set; }

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
            /// <para>The number of meals included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MealCount")]
            [Validation(Required=false)]
            public int? MealCount { get; set; }

            /// <summary>
            /// <para>The cancellation and modification policy.</para>
            /// </summary>
            [NameInMap("CancelPolicy")]
            [Validation(Required=false)]
            public DataHotelsValueOffersCancelPolicy CancelPolicy { get; set; }
            public class DataHotelsValueOffersCancelPolicy : TeaModel {
                /// <summary>
                /// <para>The policy type (NON_REFUNDABLE/FREE_CANCELLATION/PARTIAL_REFUND).</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE_CANCELLATION</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The list of penalty details.</para>
                /// </summary>
                [NameInMap("Penalties")]
                [Validation(Required=false)]
                public List<DataHotelsValueOffersCancelPolicyPenalties> Penalties { get; set; }
                public class DataHotelsValueOffersCancelPolicyPenalties : TeaModel {
                    /// <summary>
                    /// <para>The effective start time (UTC millisecond timestamp).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672531200000</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public long? Start { get; set; }

                    /// <summary>
                    /// <para>The effective end time (UTC millisecond timestamp).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672617600000</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public long? End { get; set; }

                    /// <summary>
                    /// <para>The penalty type (PERCENTAGE/AMOUNT/NIGHTS).</para>
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
                    /// <para>The currency code (only applicable when the penalty type is AMOUNT).</para>
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
            /// <para>The total selling price.</para>
            /// </summary>
            [NameInMap("SellingTotalPrice")]
            [Validation(Required=false)]
            public DataHotelsValueOffersSellingTotalPrice SellingTotalPrice { get; set; }
            public class DataHotelsValueOffersSellingTotalPrice : TeaModel {
                /// <summary>
                /// <para>The amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <para>The currency code.</para>
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
            /// <para>The list of daily selling prices.</para>
            /// </summary>
            [NameInMap("SellingDailyPrices")]
            [Validation(Required=false)]
            public List<DataHotelsValueOffersSellingDailyPrices> SellingDailyPrices { get; set; }
            public class DataHotelsValueOffersSellingDailyPrices : TeaModel {
                /// <summary>
                /// <para>The check-in date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-01</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The price for the day.</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public DataHotelsValueOffersSellingDailyPricesPrice Price { get; set; }
                public class DataHotelsValueOffersSellingDailyPricesPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public double? Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code.</para>
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
            /// <para>The number of available rooms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AvailableRooms")]
            [Validation(Required=false)]
            public int? AvailableRooms { get; set; }

            /// <summary>
            /// <para>The maximum number of guests allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxOccupancy")]
            [Validation(Required=false)]
            public int? MaxOccupancy { get; set; }

            /// <summary>
            /// <para>The confirmation type (INSTANT_CONFIRM/NON_INSTANT_CONFIRM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANT_CONFIRM</para>
            /// </summary>
            [NameInMap("ConfirmType")]
            [Validation(Required=false)]
            public string ConfirmType { get; set; }

        }

    }

}
