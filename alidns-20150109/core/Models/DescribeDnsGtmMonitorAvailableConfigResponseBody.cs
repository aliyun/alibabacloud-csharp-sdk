// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorAvailableConfigResponseBody : TeaModel {
        [NameInMap("Ipv4IspCityNodes")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes> Ipv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

        }

        [NameInMap("DomainIpv4IspCityNodes")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes> DomainIpv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainIpv6IspCityNodes")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes> DomainIpv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

        }

        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes> Ipv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("DefaultSelected")]
            [Validation(Required=false)]
            public bool? DefaultSelected { get; set; }

        }

    }

}
