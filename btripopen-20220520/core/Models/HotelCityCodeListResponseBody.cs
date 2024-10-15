// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelCityCodeListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>response is empty.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelCityCodeListResponseBodyModule> Module { get; set; }
        public class HotelCityCodeListResponseBodyModule : TeaModel {
            [NameInMap("citys")]
            [Validation(Required=false)]
            public List<HotelCityCodeListResponseBodyModuleCitys> Citys { get; set; }
            public class HotelCityCodeListResponseBodyModuleCitys : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>445222</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("districts")]
                [Validation(Required=false)]
                public List<HotelCityCodeListResponseBodyModuleCitysDistricts> Districts { get; set; }
                public class HotelCityCodeListResponseBodyModuleCitysDistricts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>330000</para>
                    /// </summary>
                    [NameInMap("district_code")]
                    [Validation(Required=false)]
                    public string DistrictCode { get; set; }

                    [NameInMap("district_name")]
                    [Validation(Required=false)]
                    public string DistrictName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>108800</para>
            /// </summary>
            [NameInMap("provice_code")]
            [Validation(Required=false)]
            public string ProviceCode { get; set; }

            [NameInMap("province_name")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
