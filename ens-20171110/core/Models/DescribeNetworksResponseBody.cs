// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworksResponseBody : TeaModel {
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public DescribeNetworksResponseBodyNetworks Networks { get; set; }
        public class DescribeNetworksResponseBodyNetworks : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public List<DescribeNetworksResponseBodyNetworksNetwork> Network { get; set; }
            public class DescribeNetworksResponseBodyNetworksNetwork : TeaModel {
                public string CidrBlock { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string EnsRegionId { get; set; }
                public string NetworkId { get; set; }
                public string NetworkName { get; set; }
                public string RouterTableId { get; set; }
                public string Status { get; set; }
                public DescribeNetworksResponseBodyNetworksNetworkVSwitchIds VSwitchIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
