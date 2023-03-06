// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaSearchRequest : TeaModel {
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("carrier_flight_no")]
        [Validation(Required=false)]
        public string CarrierFlightNo { get; set; }

        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        [NameInMap("flight_no")]
        [Validation(Required=false)]
        public string FlightNo { get; set; }

    }

}
