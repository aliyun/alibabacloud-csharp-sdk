// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichRequest : TeaModel {
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        [NameInMap("journey_param_list")]
        [Validation(Required=false)]
        public List<EnrichRequestJourneyParamList> JourneyParamList { get; set; }
        public class EnrichRequestJourneyParamList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("segment_param_list")]
            [Validation(Required=false)]
            public List<EnrichRequestJourneyParamListSegmentParamList> SegmentParamList { get; set; }
            public class EnrichRequestJourneyParamListSegmentParamList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("child_cabin")]
                [Validation(Required=false)]
                public string ChildCabin { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public string DepartureTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("marketing_flight_no")]
                [Validation(Required=false)]
                public string MarketingFlightNo { get; set; }

            }

        }

        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
