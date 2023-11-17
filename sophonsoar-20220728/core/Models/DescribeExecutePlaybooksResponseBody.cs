// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksResponseBody : TeaModel {
        [NameInMap("PlaybookMetrics")]
        [Validation(Required=false)]
        public List<DescribeExecutePlaybooksResponseBodyPlaybookMetrics> PlaybookMetrics { get; set; }
        public class DescribeExecutePlaybooksResponseBodyPlaybookMetrics : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public string ParamConfig { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
