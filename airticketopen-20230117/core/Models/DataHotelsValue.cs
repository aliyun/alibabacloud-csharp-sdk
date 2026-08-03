// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataHotelsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("CheckInDate")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-02</para>
        /// </summary>
        [NameInMap("CheckOutDate")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public List<DataHotelsValueRooms> Rooms { get; set; }
        public class DataHotelsValueRooms : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>R001</para>
            /// </summary>
            [NameInMap("StandardRoomId")]
            [Validation(Required=false)]
            public string StandardRoomId { get; set; }

            [NameInMap("LowestSellingPrice")]
            [Validation(Required=false)]
            public DataHotelsValueRoomsLowestSellingPrice LowestSellingPrice { get; set; }
            public class DataHotelsValueRoomsLowestSellingPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

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

            [NameInMap("Offers")]
            [Validation(Required=false)]
            public List<DataHotelsValueRoomsOffers> Offers { get; set; }
            public class DataHotelsValueRoomsOffers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>itemOffer_123</para>
                /// </summary>
                [NameInMap("ItemOfferKey")]
                [Validation(Required=false)]
                public string ItemOfferKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>含早房</para>
                /// </summary>
                [NameInMap("RatePlanName")]
                [Validation(Required=false)]
                public string RatePlanName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BREAKFAST</para>
                /// </summary>
                [NameInMap("MealType")]
                [Validation(Required=false)]
                public string MealType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MealCount")]
                [Validation(Required=false)]
                public int? MealCount { get; set; }

                [NameInMap("CancelPolicy")]
                [Validation(Required=false)]
                public DataHotelsValueRoomsOffersCancelPolicy CancelPolicy { get; set; }
                public class DataHotelsValueRoomsOffersCancelPolicy : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FREE_CANCELLATION</para>
                    /// </summary>
                    [NameInMap("PolicyType")]
                    [Validation(Required=false)]
                    public string PolicyType { get; set; }

                    [NameInMap("Penalties")]
                    [Validation(Required=false)]
                    public List<DataHotelsValueRoomsOffersCancelPolicyPenalties> Penalties { get; set; }
                    public class DataHotelsValueRoomsOffersCancelPolicyPenalties : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1672531200000</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public long? Start { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TraceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                [NameInMap("SellingTotalPrice")]
                [Validation(Required=false)]
                public DataHotelsValueRoomsOffersSellingTotalPrice SellingTotalPrice { get; set; }
                public class DataHotelsValueRoomsOffersSellingTotalPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100.00</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public double? Amount { get; set; }

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

                [NameInMap("SellingDailyPrices")]
                [Validation(Required=false)]
                public List<DataHotelsValueRoomsOffersSellingDailyPrices> SellingDailyPrices { get; set; }
                public class DataHotelsValueRoomsOffersSellingDailyPrices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-07-01</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public DataHotelsValueRoomsOffersSellingDailyPricesPrice Price { get; set; }
                    public class DataHotelsValueRoomsOffersSellingDailyPricesPrice : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100.00</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public double? Amount { get; set; }

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
                /// <para>5</para>
                /// </summary>
                [NameInMap("AvailableRooms")]
                [Validation(Required=false)]
                public int? AvailableRooms { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxOccupancy")]
                [Validation(Required=false)]
                public int? MaxOccupancy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INSTANT_CONFIRM</para>
                /// </summary>
                [NameInMap("ConfirmType")]
                [Validation(Required=false)]
                public string ConfirmType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>R001</para>
        /// </summary>
        [NameInMap("StandardRoomId")]
        [Validation(Required=false)]
        public string StandardRoomId { get; set; }

        [NameInMap("Offers")]
        [Validation(Required=false)]
        public List<DataHotelsValueOffers> Offers { get; set; }
        public class DataHotelsValueOffers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>itemOffer_123</para>
            /// </summary>
            [NameInMap("ItemOfferKey")]
            [Validation(Required=false)]
            public string ItemOfferKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>含早房</para>
            /// </summary>
            [NameInMap("RatePlanName")]
            [Validation(Required=false)]
            public string RatePlanName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BREAKFAST</para>
            /// </summary>
            [NameInMap("MealType")]
            [Validation(Required=false)]
            public string MealType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MealCount")]
            [Validation(Required=false)]
            public int? MealCount { get; set; }

            [NameInMap("CancelPolicy")]
            [Validation(Required=false)]
            public DataHotelsValueOffersCancelPolicy CancelPolicy { get; set; }
            public class DataHotelsValueOffersCancelPolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FREE_CANCELLATION</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                [NameInMap("Penalties")]
                [Validation(Required=false)]
                public List<DataHotelsValueOffersCancelPolicyPenalties> Penalties { get; set; }
                public class DataHotelsValueOffersCancelPolicyPenalties : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1672531200000</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public long? Start { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            [NameInMap("SellingTotalPrice")]
            [Validation(Required=false)]
            public DataHotelsValueOffersSellingTotalPrice SellingTotalPrice { get; set; }
            public class DataHotelsValueOffersSellingTotalPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

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

            [NameInMap("SellingDailyPrices")]
            [Validation(Required=false)]
            public List<DataHotelsValueOffersSellingDailyPrices> SellingDailyPrices { get; set; }
            public class DataHotelsValueOffersSellingDailyPrices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-01</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public DataHotelsValueOffersSellingDailyPricesPrice Price { get; set; }
                public class DataHotelsValueOffersSellingDailyPricesPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100.00</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public double? Amount { get; set; }

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
            /// <para>5</para>
            /// </summary>
            [NameInMap("AvailableRooms")]
            [Validation(Required=false)]
            public int? AvailableRooms { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxOccupancy")]
            [Validation(Required=false)]
            public int? MaxOccupancy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSTANT_CONFIRM</para>
            /// </summary>
            [NameInMap("ConfirmType")]
            [Validation(Required=false)]
            public string ConfirmType { get; set; }

        }

    }

}
