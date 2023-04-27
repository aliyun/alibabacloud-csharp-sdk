// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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

                [NameInMap("criterion")]
                [Validation(Required=false)]
                public long? Criterion { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("trip_days")]
                [Validation(Required=false)]
                public int? TripDays { get; set; }

            }

            /// <summary>
            /// 酒店费用总额，单位为元
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
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("fee")]
                        [Validation(Required=false)]
                        public long? Fee { get; set; }

                        [NameInMap("seat_grade")]
                        [Validation(Required=false)]
                        public string SeatGrade { get; set; }

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

                    [NameInMap("err_msg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    [NameInMap("itinerary_id")]
                    [Validation(Required=false)]
                    public string ItineraryId { get; set; }

                    [NameInMap("most_expensive")]
                    [Validation(Required=false)]
                    public EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesMostExpensive MostExpensive { get; set; }
                    public class EstimatedPriceQueryResponseBodyModuleTrafficFeeBtripRoutesMostExpensive : TeaModel {
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("fee")]
                        [Validation(Required=false)]
                        public long? Fee { get; set; }

                        [NameInMap("seat_grade")]
                        [Validation(Required=false)]
                        public string SeatGrade { get; set; }

                        [NameInMap("vehicle_no")]
                        [Validation(Required=false)]
                        public string VehicleNo { get; set; }

                    }

                    [NameInMap("success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                [NameInMap("err_msg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("max_fee")]
                [Validation(Required=false)]
                public long? MaxFee { get; set; }

                [NameInMap("min_fee")]
                [Validation(Required=false)]
                public long? MinFee { get; set; }

                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
