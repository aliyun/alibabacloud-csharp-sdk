// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeWebsiteStatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("WebsiteStatList")]
        [Validation(Required=false)]
        public List<DescribeWebsiteStatResponseBodyWebsiteStatList> WebsiteStatList { get; set; }
        public class DescribeWebsiteStatResponseBodyWebsiteStatList : TeaModel {
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public int? ScanCount { get; set; }

            [NameInMap("SubServiceModule")]
            [Validation(Required=false)]
            public string SubServiceModule { get; set; }

        }

    }

}
