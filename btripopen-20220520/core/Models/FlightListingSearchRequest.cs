// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MU</para>
        /// </summary>
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
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
