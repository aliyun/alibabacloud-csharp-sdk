// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The monitored nodes.
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// The code of the city where the monitored node is deployed.
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// The display name of the city where the monitored node is deployed.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// Indicates whether the monitored node is selected for the health check by default.
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// The name of the group to which the monitored node belongs.
                /// 
                /// Valid values: Overseas Nodes, BGP Nodes, and ISP Nodes.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the group to which the monitored node belongs.
                /// 
                /// Valid values: BGP, OVERSEAS, and ISP.
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// The code of the Internet service provider (ISP) to which the monitored node belongs.
                /// 
                /// *   If the value of the GroupType parameter is BGP or OVERSEAS, the value of IspCode is 465 by default.
                /// *   If the value of the GroupType parameter is not BGP or OVERSEAS, valid values of IspCode are 232, 132, and 5. and is used together with CityCode.
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// The display name of the ISP to which the monitored node belongs.
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// Indicates whether the monitored node is deployed in the Chinese mainland.
                /// </summary>
                [NameInMap("Mainland")]
                [Validation(Required=false)]
                public bool? Mainland { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
