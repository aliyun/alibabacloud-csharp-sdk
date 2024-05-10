// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightSearchListRequest : TeaModel {
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        [NameInMap("arr_city_name")]
        [Validation(Required=false)]
        public string ArrCityName { get; set; }

        [NameInMap("arr_date")]
        [Validation(Required=false)]
        public string ArrDate { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        [NameInMap("dep_city_name")]
        [Validation(Required=false)]
        public string DepCityName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        [NameInMap("flight_no")]
        [Validation(Required=false)]
        public string FlightNo { get; set; }

        [NameInMap("need_multi_class_price")]
        [Validation(Required=false)]
        public bool? NeedMultiClassPrice { get; set; }

        [NameInMap("transfer_city_code")]
        [Validation(Required=false)]
        public string TransferCityCode { get; set; }

        [NameInMap("transfer_flight_no")]
        [Validation(Required=false)]
        public string TransferFlightNo { get; set; }

        [NameInMap("transfer_leave_date")]
        [Validation(Required=false)]
        public string TransferLeaveDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public string TripType { get; set; }

    }

}
