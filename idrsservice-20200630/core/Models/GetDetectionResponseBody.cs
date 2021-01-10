// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetDetectionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDetectionResponseBodyData Data { get; set; }
        public class GetDetectionResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("DepartmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetDetectionResponseBodyDataTasks> Tasks { get; set; }
            public class GetDetectionResponseBodyDataTasks : TeaModel {
                public string Status { get; set; }
                public string VideoMetaUrl { get; set; }
                public string CreatedAt { get; set; }
                public string Id { get; set; }
                public string VideoUrl { get; set; }
            }
            [NameInMap("RecordingType")]
            [Validation(Required=false)]
            public string RecordingType { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
