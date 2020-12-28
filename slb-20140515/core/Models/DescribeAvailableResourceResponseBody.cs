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
        public List<DescribeAvailableResourceResponseBodyAvailableResources> AvailableResources { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableResources : TeaModel {
            [NameInMap("SlaveZoneId")]
            [Validation(Required=false)]
            public string SlaveZoneId { get; set; }

            [NameInMap("SupportResources")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableResourcesSupportResources> SupportResources { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableResourcesSupportResources : TeaModel {
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

            }

            [NameInMap("MasterZoneId")]
            [Validation(Required=false)]
            public string MasterZoneId { get; set; }

        }

    }

}
