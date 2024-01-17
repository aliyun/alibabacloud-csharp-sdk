// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetRunningTasksResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRunningTasksResponseBodyResult> Result { get; set; }
        public class GetRunningTasksResponseBodyResult : TeaModel {
            [NameInMap("ActiveTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("ActualActionerId")]
            [Validation(Required=false)]
            public string ActualActionerId { get; set; }

            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("TitleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
