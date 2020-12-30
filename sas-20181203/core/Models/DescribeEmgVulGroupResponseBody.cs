// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulGroupResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EmgVulGroupList")]
        [Validation(Required=false)]
        public List<DescribeEmgVulGroupResponseBodyEmgVulGroupList> EmgVulGroupList { get; set; }
        public class DescribeEmgVulGroupResponseBodyEmgVulGroupList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public long? GmtPublish { get; set; }

            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
