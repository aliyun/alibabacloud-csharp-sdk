// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelCityCodeListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>response is empty.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The module information. Null is returned if the value is empty.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelCityCodeListResponseBodyModule> Module { get; set; }
        public class HotelCityCodeListResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of cities. An empty array is returned if the value is empty.</para>
            /// </summary>
            [NameInMap("citys")]
            [Validation(Required=false)]
            public List<HotelCityCodeListResponseBodyModuleCitys> Citys { get; set; }
            public class HotelCityCodeListResponseBodyModuleCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>445222</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The list of districts. An empty array is returned if the value is empty.</para>
                /// </summary>
                [NameInMap("districts")]
                [Validation(Required=false)]
                public List<HotelCityCodeListResponseBodyModuleCitysDistricts> Districts { get; set; }
                public class HotelCityCodeListResponseBodyModuleCitysDistricts : TeaModel {
                    /// <summary>
                    /// <para>The district code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>330000</para>
                    /// </summary>
                    [NameInMap("district_code")]
                    [Validation(Required=false)]
                    public string DistrictCode { get; set; }

                    /// <summary>
                    /// <para>The district name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>余杭区</para>
                    /// </summary>
                    [NameInMap("district_name")]
                    [Validation(Required=false)]
                    public string DistrictName { get; set; }

                }

            }

            /// <summary>
            /// <para>The province code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>108800</para>
            /// </summary>
            [NameInMap("provice_code")]
            [Validation(Required=false)]
            public string ProviceCode { get; set; }

            /// <summary>
            /// <para>The province name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>山西省</para>
            /// </summary>
            [NameInMap("province_name")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
