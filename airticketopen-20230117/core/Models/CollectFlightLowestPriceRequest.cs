// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class CollectFlightLowestPriceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("lowest_price_flight_info_list")]
        [Validation(Required=false)]
        public List<CollectFlightLowestPriceRequestLowestPriceFlightInfoList> LowestPriceFlightInfoList { get; set; }
        public class CollectFlightLowestPriceRequestLowestPriceFlightInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFM</para>
            /// </summary>
            [NameInMap("arrival_city")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("departure_city")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-11</para>
            /// </summary>
            [NameInMap("departure_date")]
            [Validation(Required=false)]
            public string DepartureDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CA123,CA456</para>
            /// </summary>
            [NameInMap("departure_flight_number")]
            [Validation(Required=false)]
            public string DepartureFlightNumber { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("market_total_price")]
            [Validation(Required=false)]
            public double? MarketTotalPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789dacd</para>
            /// </summary>
            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-11</para>
            /// </summary>
            [NameInMap("return_date")]
            [Validation(Required=false)]
            public string ReturnDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CA123,CA456</para>
            /// </summary>
            [NameInMap("return_flight_number")]
            [Validation(Required=false)]
            public string ReturnFlightNumber { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
            /// </summary>
            [NameInMap("solution_id")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.1</para>
            /// </summary>
            [NameInMap("suez_total_price")]
            [Validation(Required=false)]
            public double? SuezTotalPrice { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

    }

}
