// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeCapabilitiesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public DescribeCapabilitiesResponseBodyCapabilities Capabilities { get; set; }
        public class DescribeCapabilitiesResponseBodyCapabilities : TeaModel {
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public List<DescribeCapabilitiesResponseBodyCapabilitiesCapability> Capability { get; set; }
            public class DescribeCapabilitiesResponseBodyCapabilitiesCapability : TeaModel {
                public string CapabilityId { get; set; }
                public string CapabilityName { get; set; }
            }
        };

    }

}
