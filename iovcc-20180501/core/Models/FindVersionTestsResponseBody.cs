// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindVersionTestsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionTestList")]
        [Validation(Required=false)]
        public FindVersionTestsResponseBodyVersionTestList VersionTestList { get; set; }
        public class FindVersionTestsResponseBodyVersionTestList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindVersionTestsResponseBodyVersionTestListItems> Items { get; set; }
            public class FindVersionTestsResponseBodyVersionTestListItems : TeaModel {
                public long? Id { get; set; }
                public string VersionId { get; set; }
                public string VersionType { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string DeviceGroupId { get; set; }
                public string DeviceGroupName { get; set; }
                public string SucceededCount { get; set; }
                public string FailedCount { get; set; }
                public string SkippedCount { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifyTimestamp { get; set; }
            }
        };

    }

}
