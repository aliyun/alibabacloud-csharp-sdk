// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The queried detection points.
        /// </summary>
        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public DescribeSiteMonitorISPCityListResponseBodyIspCityList IspCityList { get; set; }
        public class DescribeSiteMonitorISPCityListResponseBodyIspCityList : TeaModel {
            [NameInMap("IspCity")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity> IspCity { get; set; }
            public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity : TeaModel {
                [NameInMap("Area.en")]
                [Validation(Required=false)]
                public string Area_en { get; set; }

                [NameInMap("Area.zh_CN")]
                [Validation(Required=false)]
                public string Area_zh_cN { get; set; }

                /// <summary>
                /// The city ID.
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("CityName.en")]
                [Validation(Required=false)]
                public string CityName_en { get; set; }

                [NameInMap("CityName.zh_CN")]
                [Validation(Required=false)]
                public string CityName_zh_cN { get; set; }

                /// <summary>
                /// The country name.
                /// 
                /// > This parameter is valid only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("Country.en")]
                [Validation(Required=false)]
                public string Country_en { get; set; }

                [NameInMap("Country.zh_CN")]
                [Validation(Required=false)]
                public string Country_zh_cN { get; set; }

                /// <summary>
                /// The IP address pool.
                /// </summary>
                [NameInMap("IPPool")]
                [Validation(Required=false)]
                public DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool IPPool { get; set; }
                public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool : TeaModel {
                    [NameInMap("IPPool")]
                    [Validation(Required=false)]
                    public List<string> IPPool { get; set; }

                }

                /// <summary>
                /// The number of IPv4 probes.
                /// </summary>
                [NameInMap("IPV4ProbeCount")]
                [Validation(Required=false)]
                public string IPV4ProbeCount { get; set; }

                /// <summary>
                /// The number of IPv6 probes.
                /// </summary>
                [NameInMap("IPV6ProbeCount")]
                [Validation(Required=false)]
                public string IPV6ProbeCount { get; set; }

                /// <summary>
                /// The carrier ID.
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("IspName.en")]
                [Validation(Required=false)]
                public string IspName_en { get; set; }

                [NameInMap("IspName.zh_CN")]
                [Validation(Required=false)]
                public string IspName_zh_cN { get; set; }

                /// <summary>
                /// The province name.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Region.en")]
                [Validation(Required=false)]
                public string Region_en { get; set; }

                [NameInMap("Region.zh_CN")]
                [Validation(Required=false)]
                public string Region_zh_cN { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
