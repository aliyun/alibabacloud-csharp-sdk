// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorAvailableConfigResponseBody : TeaModel {
        [NameInMap("DomainIpv4IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes DomainIpv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodes : TeaModel {
            [NameInMap("DomainIpv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode> DomainIpv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv4IspCityNodesDomainIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        [NameInMap("DomainIpv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes DomainIpv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodes : TeaModel {
            [NameInMap("DomainIpv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode> DomainIpv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyDomainIpv6IspCityNodesDomainIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        [NameInMap("Ipv4IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes Ipv4IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodes : TeaModel {
            [NameInMap("Ipv4IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode> Ipv4IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv4IspCityNodesIpv4IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        [NameInMap("Ipv6IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes Ipv6IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodes : TeaModel {
            [NameInMap("Ipv6IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode> Ipv6IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps Ips { get; set; }
                public class DescribeDnsGtmMonitorAvailableConfigResponseBodyIpv6IspCityNodesIpv6IspCityNodeIps : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
