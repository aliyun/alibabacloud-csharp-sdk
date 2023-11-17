// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeDistinctReleasesResponseBody : TeaModel {
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDistinctReleasesResponseBodyRecords> Records { get; set; }
        public class DescribeDistinctReleasesResponseBodyRecords : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
