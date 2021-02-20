// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeAllVulnerabilitiesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeAllVulnerabilitiesResponseBodyList> List { get; set; }
        public class DescribeAllVulnerabilitiesResponseBodyList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public int? Severity { get; set; }

            [NameInMap("LastDiscoveredAt")]
            [Validation(Required=false)]
            public long? LastDiscoveredAt { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("VulnerabilityTypeDes")]
            [Validation(Required=false)]
            public string VulnerabilityTypeDes { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
