// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksResponseBody : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePlaybooksResponseBodyPage Page { get; set; }
        public class DescribePlaybooksResponseBodyPage : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribePlaybooksResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribePlaybooksResponseBodyPlaybooks : TeaModel {
            [NameInMap("Active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
