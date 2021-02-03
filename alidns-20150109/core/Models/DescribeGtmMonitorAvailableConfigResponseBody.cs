// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorAvailableConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                public string CityCode { get; set; }
                public bool? Mainland { get; set; }
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
