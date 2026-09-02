// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataHotelsValue : TeaModel {
        /// <summary>
        /// <para>The check-in date (yyyy-MM-dd).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("CheckInDate")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>The check-out date (yyyy-MM-dd).</para>
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
            /// <para>The lowest price for the room type on the day.</para>
            /// </summary>
            [NameInMap("LowestPrice")]
            [Validation(Required=false)]
            public DataHotelsValueRoomsLowestPrice LowestPrice { get; set; }
            public class DataHotelsValueRoomsLowestPrice : TeaModel {
                /// <summary>
                /// <para>The amount in the smallest currency unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>287</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

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
            /// <para>The list of all available offers for the room type.</para>
            /// </summary>
            [NameInMap("Offers")]
            [Validation(Required=false)]
            public List<DataHotelsValueRoomsOffers> Offers { get; set; }
            public class DataHotelsValueRoomsOffers : TeaModel {
                /// <summary>
                /// <para>The item-level offer identifier (price verification key, pass through as-is).</para>
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
                /// <para>Breakfast included</para>
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
                    public List<DataHotelsValueRoomsOffersCancelPolicyPenalties> Penalties { get; set; }
                    public class DataHotelsValueRoomsOffersCancelPolicyPenalties : TeaModel {
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
                        /// <para>The effective end time (UTC millisecond timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672617600000</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public string End { get; set; }

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
                        /// <para>The currency code (present only when the type is AMOUNT).</para>
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
                [NameInMap("TotalPrice")]
                [Validation(Required=false)]
                public DataHotelsValueRoomsOffersTotalPrice TotalPrice { get; set; }
                public class DataHotelsValueRoomsOffersTotalPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>287</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

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
                /// <para>The list of daily prices.</para>
                /// </summary>
                [NameInMap("DailyPrices")]
                [Validation(Required=false)]
                public List<DataHotelsValueRoomsOffersDailyPrices> DailyPrices { get; set; }
                public class DataHotelsValueRoomsOffersDailyPrices : TeaModel {
                    /// <summary>
                    /// <para>The check-in date (yyyy-MM-dd, time zone: hotel local time zone).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-08-16</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>The price for the day.</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public DataHotelsValueRoomsOffersDailyPricesPrice Price { get; set; }
                    public class DataHotelsValueRoomsOffersDailyPricesPrice : TeaModel {
                        /// <summary>
                        /// <para>The amount in the smallest currency unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>287</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public string Amount { get; set; }

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
            /// <para>The item offer key, which is a price verification key. Pass this value through as-is.</para>
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
            /// <para>The cancellation policy.</para>
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
                    /// <para>The effective start time, in UTC millisecond timestamp format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672531200000</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                    /// <summary>
                    /// <para>The effective end time, in UTC millisecond timestamp format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672617600000</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public string End { get; set; }

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
                    /// <para>The penalty value (percentage, amount, or number of nights).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("PenaltyValue")]
                    [Validation(Required=false)]
                    public string PenaltyValue { get; set; }

                    /// <summary>
                    /// <para>The currency code. This field has a value only when the penalty type is AMOUNT.</para>
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
            [NameInMap("TotalPrice")]
            [Validation(Required=false)]
            public DataHotelsValueOffersTotalPrice TotalPrice { get; set; }
            public class DataHotelsValueOffersTotalPrice : TeaModel {
                /// <summary>
                /// <para>The amount in the smallest currency unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>287</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

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
            /// <para>The list of daily prices.</para>
            /// </summary>
            [NameInMap("DailyPrices")]
            [Validation(Required=false)]
            public List<DataHotelsValueOffersDailyPrices> DailyPrices { get; set; }
            public class DataHotelsValueOffersDailyPrices : TeaModel {
                /// <summary>
                /// <para>The check-in date in yyyy-MM-dd format, based on the hotel local time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-16</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The price for the day.</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public DataHotelsValueOffersDailyPricesPrice Price { get; set; }
                public class DataHotelsValueOffersDailyPricesPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>287</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

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
