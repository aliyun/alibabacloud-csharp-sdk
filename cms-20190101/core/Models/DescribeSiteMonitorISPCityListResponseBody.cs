// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public DescribeSiteMonitorISPCityListResponseBodyIspCityList IspCityList { get; set; }
        public class DescribeSiteMonitorISPCityListResponseBodyIspCityList : TeaModel {
            [NameInMap("IspCity")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity> IspCity { get; set; }
            public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity : TeaModel {
                public string Area_en { get; set; }
                public string Area_zh_cN { get; set; }
                public string City { get; set; }
                public string CityName_en { get; set; }
                public string CityName_zh_cN { get; set; }
                public string Country { get; set; }
                public string Country_en { get; set; }
                public string Country_zh_cN { get; set; }
                public DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool IPPool { get; set; }
                public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool : TeaModel {
                    [NameInMap("IPPool")]
                    [Validation(Required=false)]
                    public List<string> IPPool { get; set; }

                }
                public string IPV4ProbeCount { get; set; }
                public string IPV6ProbeCount { get; set; }
                public string Isp { get; set; }
                public string IspName_en { get; set; }
                public string IspName_zh_cN { get; set; }
                public string Region { get; set; }
                public string Region_en { get; set; }
                public string Region_zh_cN { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
