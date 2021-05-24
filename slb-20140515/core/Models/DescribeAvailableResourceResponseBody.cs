// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableResources AvailableResources { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableResources : TeaModel {
            [NameInMap("AvailableResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource> AvailableResource { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource : TeaModel {
                public string SlaveZoneId { get; set; }
                public string MasterZoneId { get; set; }
                public DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources SupportResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources : TeaModel {
                    [NameInMap("SupportResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource> SupportResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource : TeaModel {
                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                        [NameInMap("AddressIPVersion")]
                        [Validation(Required=false)]
                        public string AddressIPVersion { get; set; }

                    }

                }
            }
        };

    }

}
