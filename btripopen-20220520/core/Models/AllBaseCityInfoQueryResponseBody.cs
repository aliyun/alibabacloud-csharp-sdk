// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AllBaseCityInfoQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public AllBaseCityInfoQueryResponseBodyModule Module { get; set; }
        public class AllBaseCityInfoQueryResponseBodyModule : TeaModel {
            [NameInMap("all_city_base_info_list")]
            [Validation(Required=false)]
            public List<AllBaseCityInfoQueryResponseBodyModuleAllCityBaseInfoList> AllCityBaseInfoList { get; set; }
            public class AllBaseCityInfoQueryResponseBodyModuleAllCityBaseInfoList : TeaModel {
                [NameInMap("adcode")]
                [Validation(Required=false)]
                public string Adcode { get; set; }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("city_level")]
                [Validation(Required=false)]
                public string CityLevel { get; set; }

                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("cn_name_tree")]
                [Validation(Required=false)]
                public string CnNameTree { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("other_name_list")]
                [Validation(Required=false)]
                public List<string> OtherNameList { get; set; }

            }

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
