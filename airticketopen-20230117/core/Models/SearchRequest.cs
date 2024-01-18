// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchRequest : TeaModel {
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public List<SearchRequestAirLegs> AirLegs { get; set; }
        public class SearchRequestAirLegs : TeaModel {
            [NameInMap("arrival_airport_list")]
            [Validation(Required=false)]
            public List<string> ArrivalAirportList { get; set; }

            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            [NameInMap("departure_airport_list")]
            [Validation(Required=false)]
            public List<string> DepartureAirportList { get; set; }

            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

        }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

    }

}
