// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorAvailableConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Ipv4IspCityNodes")]
        [Validation(Required=true)]
        public DescribeDnsGtmMonitorAvailableConfigResponseIpv4IspCityNodes Ipv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseIpv4IspCityNodes : TeaModel {
            [NameInMap("Ipv4IspCityNode")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseIpv4IspCityNodesIpv4IspCityNode> Ipv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseIpv4IspCityNodesIpv4IspCityNode : TeaModel {
                public string IspName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string CityCode { get; set; }
                public bool? DefaultSelected { get; set; }
                public string GroupType { get; set; }
                public string GroupName { get; set; }
            }
        };

        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=true)]
        public DescribeDnsGtmMonitorAvailableConfigResponseIpv6IspCityNodes Ipv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseIpv6IspCityNodes : TeaModel {
            [NameInMap("Ipv6IspCityNode")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseIpv6IspCityNodesIpv6IspCityNode> Ipv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseIpv6IspCityNodesIpv6IspCityNode : TeaModel {
                public string IspName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string CityCode { get; set; }
                public bool? DefaultSelected { get; set; }
                public string GroupType { get; set; }
                public string GroupName { get; set; }
            }
        };

        [NameInMap("DomainIpv4IspCityNodes")]
        [Validation(Required=true)]
        public DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv4IspCityNodes DomainIpv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv4IspCityNodes : TeaModel {
            [NameInMap("DomainIpv4IspCityNode")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv4IspCityNodesDomainIpv4IspCityNode> DomainIpv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv4IspCityNodesDomainIpv4IspCityNode : TeaModel {
                public string IspName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string CityCode { get; set; }
                public bool? DefaultSelected { get; set; }
                public string GroupType { get; set; }
                public string GroupName { get; set; }
            }
        };

        [NameInMap("DomainIpv6IspCityNodes")]
        [Validation(Required=true)]
        public DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv6IspCityNodes DomainIpv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv6IspCityNodes : TeaModel {
            [NameInMap("DomainIpv6IspCityNode")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv6IspCityNodesDomainIpv6IspCityNode> DomainIpv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseDomainIpv6IspCityNodesDomainIpv6IspCityNode : TeaModel {
                public string IspName { get; set; }
                public string IspCode { get; set; }
                public string CityName { get; set; }
                public string CityCode { get; set; }
                public bool? DefaultSelected { get; set; }
                public string GroupType { get; set; }
                public string GroupName { get; set; }
            }
        };

    }

}
