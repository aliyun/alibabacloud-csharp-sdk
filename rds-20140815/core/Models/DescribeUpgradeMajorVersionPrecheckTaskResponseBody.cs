// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionPrecheckTaskResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionPrecheckTaskResponseBodyItems : TeaModel {
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
