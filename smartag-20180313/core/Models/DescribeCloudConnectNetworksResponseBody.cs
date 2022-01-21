// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeCloudConnectNetworksResponseBody : TeaModel {
        [NameInMap("CloudConnectNetworks")]
        [Validation(Required=false)]
        public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworks CloudConnectNetworks { get; set; }
        public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworks : TeaModel {
            [NameInMap("CloudConnectNetwork")]
            [Validation(Required=false)]
            public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetwork> CloudConnectNetwork { get; set; }
            public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetwork : TeaModel {
                public string AssociatedCenId { get; set; }
                public string AssociatedCenOwnerId { get; set; }
                public string AssociatedCloudBoxCount { get; set; }
                public string AvailableCloudBoxCount { get; set; }
                public string CcnId { get; set; }
                public string CidrBlock { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public string InterworkingStatus { get; set; }
                public string Name { get; set; }
                public string ResourceGroupId { get; set; }
                public string SnatCidrBlock { get; set; }
                public DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTags Tags { get; set; }
                public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTagsTag> Tag { get; set; }
                    public class DescribeCloudConnectNetworksResponseBodyCloudConnectNetworksCloudConnectNetworkTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
