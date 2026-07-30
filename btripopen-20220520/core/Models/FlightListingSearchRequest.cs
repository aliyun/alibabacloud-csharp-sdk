// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchRequest : TeaModel {
        /// <summary>
        /// <para>The two-letter code of the airline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MU</para>
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
        /// <para>The cabin class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: all cabin classes</description></item>
        /// <item><description>1: economy class</description></item>
        /// <item><description>2: business class</description></item>
        /// </list>
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
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
        /// <para>The departure time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-26</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

    }

}
