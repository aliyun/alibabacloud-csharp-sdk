// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightSearchListRequest : TeaModel {
        /// <summary>
        /// <para>The two-letter code of the airline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA</para>
        /// </summary>
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        /// <summary>
        /// <para>The three-letter code of the arrival city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// <para>The arrival city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("arr_city_name")]
        [Validation(Required=false)]
        public string ArrCityName { get; set; }

        /// <summary>
        /// <para>The return date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-00-01 00:00:00</para>
        /// </summary>
        [NameInMap("arr_date")]
        [Validation(Required=false)]
        public string ArrDate { get; set; }

        /// <summary>
        /// <para>The cabin class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>The three-letter code of the departure city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
        /// <para>The departure city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("dep_city_name")]
        [Validation(Required=false)]
        public string DepCityName { get; set; }

        /// <summary>
        /// <para>The departure date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-00-00 00:00:00</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>The flight number. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA2323</para>
        /// </summary>
        [NameInMap("flight_no")]
        [Validation(Required=false)]
        public string FlightNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to query multi-cabin prices. Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_multi_class_price")]
        [Validation(Required=false)]
        public bool? NeedMultiClassPrice { get; set; }

        /// <summary>
        /// <para>The three-letter code of the transfer city. Optional. Required if the transfer flight number is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("transfer_city_code")]
        [Validation(Required=false)]
        public string TransferCityCode { get; set; }

        /// <summary>
        /// <para>The transfer flight number (second leg). Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA2323</para>
        /// </summary>
        [NameInMap("transfer_flight_no")]
        [Validation(Required=false)]
        public string TransferFlightNo { get; set; }

        /// <summary>
        /// <para>The departure time of the transfer flight. Optional. Required if the transfer flight number is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("transfer_leave_date")]
        [Validation(Required=false)]
        public string TransferLeaveDate { get; set; }

        /// <summary>
        /// <para>The trip type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public string TripType { get; set; }

    }

}
