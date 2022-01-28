// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAttributeResponseBody : TeaModel {
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeNetworkAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                public int? ResourceCount { get; set; }
                public string ResourceType { get; set; }
            }
        };

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyVSwitchIds VSwitchIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyVSwitchIds : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public List<string> VSwitchId { get; set; }
        };

    }

}
