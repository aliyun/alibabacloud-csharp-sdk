// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionTasksResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionTasksResponseBodyItems : TeaModel {
            [NameInMap("CollectStatMode")]
            [Validation(Required=false)]
            public string CollectStatMode { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("SourceInsName")]
            [Validation(Required=false)]
            public string SourceInsName { get; set; }

            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            [NameInMap("TargetInsName")]
            [Validation(Required=false)]
            public string TargetInsName { get; set; }

            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

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
