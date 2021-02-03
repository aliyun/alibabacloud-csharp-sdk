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
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes Ipv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes : TeaModel {
            [NameInMap("Ipv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode> Ipv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode : TeaModel {
                public string CityCode { get; set; }
                public string GroupName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string IspName { get; set; }
                public string GroupType { get; set; }
                public bool? DefaultSelected { get; set; }
            }
        };

        [NameInMap("DomainIpv4IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes DomainIpv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes : TeaModel {
            [NameInMap("DomainIpv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode> DomainIpv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode : TeaModel {
                public string CityCode { get; set; }
                public string GroupName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string IspName { get; set; }
                public string GroupType { get; set; }
                public bool? DefaultSelected { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainIpv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes DomainIpv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes : TeaModel {
            [NameInMap("DomainIpv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode> DomainIpv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode : TeaModel {
                public string CityCode { get; set; }
                public string GroupName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string IspName { get; set; }
                public string GroupType { get; set; }
                public bool? DefaultSelected { get; set; }
            }
        };

        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes Ipv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes : TeaModel {
            [NameInMap("Ipv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode> Ipv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode : TeaModel {
                public string CityCode { get; set; }
                public string GroupName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string IspName { get; set; }
                public string GroupType { get; set; }
                public bool? DefaultSelected { get; set; }
            }
        };

    }

}
