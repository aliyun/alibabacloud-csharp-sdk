// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateScanTaskRequest : TeaModel {
        [NameInMap("DataLimitId")]
        [Validation(Required=false)]
        public long? DataLimitId { get; set; }

        [NameInMap("IntervalDay")]
        [Validation(Required=false)]
        public int? IntervalDay { get; set; }

        [NameInMap("RunHour")]
        [Validation(Required=false)]
        public int? RunHour { get; set; }

        [NameInMap("RunMinute")]
        [Validation(Required=false)]
        public int? RunMinute { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskUserName")]
        [Validation(Required=false)]
        public string TaskUserName { get; set; }

        [NameInMap("OssScanPath")]
        [Validation(Required=false)]
        public string OssScanPath { get; set; }

        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public int? ScanRange { get; set; }

        [NameInMap("ScanRangeContent")]
        [Validation(Required=false)]
        public string ScanRangeContent { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

    }

}
