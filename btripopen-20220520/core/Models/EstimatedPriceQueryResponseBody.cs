// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public EstimatedPriceQueryResponseBodyModule Module { get; set; }
        public class EstimatedPriceQueryResponseBodyModule : TeaModel {
            [NameInMap("hotel_fee_detail")]
            [Validation(Required=false)]
            public List<EstimatedPriceQueryResponseBodyModuleHotelFeeDetail> HotelFeeDetail { get; set; }
            public class EstimatedPriceQueryResponseBodyModuleHotelFeeDetail : TeaModel {
                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("criterion")]
                [Validation(Required=false)]
                public long? Criterion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1245</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_days")]
                [Validation(Required=false)]
                public int? TripDays { get; set; }

            }

            /// <summary>
            /// <para>酒店费用总额，单位为元</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("total_hotel_fee")]
            [Validation(Required=false)]
            public long? TotalHotelFee { get; set; }

            [NameInMap("traffic_fee")]
            [Validation(Required=false)]
            public EstimatedPriceQueryResponseBodyModuleTrafficFee TrafficFee { get; set; }
            public class EstimatedPriceQueryResponseBodyModuleTrafficFee : TeaModel {
                [NameInMap("btrip_routes")]
                [Validation(Required=false)]
                public List<EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutes> BtripRoutes { get; set; }
                public class EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutes : TeaModel {
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    [NameInMap("arr_date")]
                    [Validation(Required=false)]
                    public long? ArrDate { get; set; }

                    [NameInMap("cheapest")]
                    [Validation(Required=false)]
                    public EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesCheapest Cheapest { get; set; }
                    public class EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesCheapest : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>00:40</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22:20</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30100</para>
                        /// </summary>
                        [NameInMap("fee")]
                        [Validation(Required=false)]
                        public long? Fee { get; set; }

                        [NameInMap("seat_grade")]
                        [Validation(Required=false)]
                        public string SeatGrade { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU9668</para>
                        /// </summary>
                        [NameInMap("vehicle_no")]
                        [Validation(Required=false)]
                        public string VehicleNo { get; set; }

                    }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    [NameInMap("dep_date")]
                    [Validation(Required=false)]
                    public long? DepDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("err_msg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1245</para>
                    /// </summary>
                    [NameInMap("itinerary_id")]
                    [Validation(Required=false)]
                    public string ItineraryId { get; set; }

                    [NameInMap("most_expensive")]
                    [Validation(Required=false)]
                    public EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesMostExpensive MostExpensive { get; set; }
                    public class EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesMostExpensive : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>19:20</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>17:00</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>265000</para>
                        /// </summary>
                        [NameInMap("fee")]
                        [Validation(Required=false)]
                        public long? Fee { get; set; }

                        [NameInMap("seat_grade")]
                        [Validation(Required=false)]
                        public string SeatGrade { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA1721</para>
                        /// </summary>
                        [NameInMap("vehicle_no")]
                        [Validation(Required=false)]
                        public string VehicleNo { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("err_msg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>265000</para>
                /// </summary>
                [NameInMap("max_fee")]
                [Validation(Required=false)]
                public long? MaxFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30100</para>
                /// </summary>
                [NameInMap("min_fee")]
                [Validation(Required=false)]
                public long? MinFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
