// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelCityCodeListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                    [NameInMap("district_code")]
                    [Validation(Required=false)]
                    public string DistrictCode { get; set; }

                    [NameInMap("district_name")]
                    [Validation(Required=false)]
                    public string DistrictName { get; set; }

                }

            }

            [NameInMap("provice_code")]
            [Validation(Required=false)]
            public string ProviceCode { get; set; }

            [NameInMap("province_name")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
