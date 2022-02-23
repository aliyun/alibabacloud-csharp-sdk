// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableResources AvailableResources { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableResources : TeaModel {
            [NameInMap("AvailableResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource> AvailableResource { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource : TeaModel {
                public string MasterZoneId { get; set; }
                public string SlaveZoneId { get; set; }
                public DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources SupportResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources : TeaModel {
                    [NameInMap("SupportResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource> SupportResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource : TeaModel {
                        [NameInMap("AddressIPVersion")]
                        [Validation(Required=false)]
                        public string AddressIPVersion { get; set; }

                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
