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
                [NameInMap("AssociatedCenId")]
                [Validation(Required=false)]
                public string AssociatedCenId { get; set; }

                [NameInMap("AssociatedCenOwnerId")]
                [Validation(Required=false)]
                public string AssociatedCenOwnerId { get; set; }

                [NameInMap("AssociatedCloudBoxCount")]
                [Validation(Required=false)]
                public string AssociatedCloudBoxCount { get; set; }

                [NameInMap("AvailableCloudBoxCount")]
                [Validation(Required=false)]
                public string AvailableCloudBoxCount { get; set; }

                [NameInMap("CcnId")]
                [Validation(Required=false)]
                public string CcnId { get; set; }

                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InterworkingStatus")]
                [Validation(Required=false)]
                public string InterworkingStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SnatCidrBlock")]
                [Validation(Required=false)]
                public string SnatCidrBlock { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

        }

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
