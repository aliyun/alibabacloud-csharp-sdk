// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsResponseBody : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeSoarRecordsResponseBodyPage Page { get; set; }
        public class DescribeSoarRecordsResponseBodyPage : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SoarExecuteRecords")]
        [Validation(Required=false)]
        public List<DescribeSoarRecordsResponseBodySoarExecuteRecords> SoarExecuteRecords { get; set; }
        public class DescribeSoarRecordsResponseBodySoarExecuteRecords : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("RawEventReq")]
            [Validation(Required=false)]
            public string RawEventReq { get; set; }

            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

    }

}
