// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDISyncTaskResponseData Data { get; set; }
        public class GetDISyncTaskResponseData : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=true)]
            public string Code { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
            [NameInMap("SolutionDetail")]
            [Validation(Required=true)]
            public GetDISyncTaskResponseDataSolutionDetail SolutionDetail { get; set; }
            public class GetDISyncTaskResponseDataSolutionDetail : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=true)]
                public long? Id { get; set; }

                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=true)]
                public long? ProjectId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("ProcessContent")]
                [Validation(Required=true)]
                public string ProcessContent { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=true)]
                public string StartTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=true)]
                public string CreatorName { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=true)]
                public string SourceType { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=true)]
                public string SubmitTime { get; set; }

                [NameInMap("ProcessExtra")]
                [Validation(Required=true)]
                public string ProcessExtra { get; set; }

            }
        };

    }

}
