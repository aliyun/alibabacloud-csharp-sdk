// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListRequest : TeaModel {
        /// <summary>
        /// The name or ID of the city.
        /// 
        /// > City names support fuzzy match.
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// Specifies whether to query IPv4 probes. Valid values:
        /// 
        /// *   true (default): IPv4 probes are queried.
        /// *   false: IPv4 probes are not queried.
        /// </summary>
        [NameInMap("IPV4")]
        [Validation(Required=false)]
        public bool? IPV4 { get; set; }

        /// <summary>
        /// Specifies whether to query IPv6 probes. Valid values:
        /// 
        /// *   true (default): IPv6 probes are queried.
        /// *   false: IPv6 probes are not queried.
        /// </summary>
        [NameInMap("IPV6")]
        [Validation(Required=false)]
        public bool? IPV6 { get; set; }

        /// <summary>
        /// The name or ID of the carrier.
        /// 
        /// > Carrier names support fuzzy match.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to return all detection points. Valid values:
        /// 
        /// *   true (default): returns all detection points.
        /// *   false: returns only available detection points.
        /// </summary>
        [NameInMap("ViewAll")]
        [Validation(Required=false)]
        public bool? ViewAll { get; set; }

    }

}
