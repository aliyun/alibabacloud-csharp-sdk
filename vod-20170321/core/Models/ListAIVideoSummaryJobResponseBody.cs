// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIVideoSummaryJobResponseBody : TeaModel {
        [NameInMap("AIVideoSummaryJobList")]
        [Validation(Required=false)]
        public ListAIVideoSummaryJobResponseBodyAIVideoSummaryJobList AIVideoSummaryJobList { get; set; }
        public class ListAIVideoSummaryJobResponseBodyAIVideoSummaryJobList : TeaModel {
            [NameInMap("AIVideoSummaryJob")]
            [Validation(Required=false)]
            public List<ListAIVideoSummaryJobResponseBodyAIVideoSummaryJobListAIVideoSummaryJob> AIVideoSummaryJob { get; set; }
            public class ListAIVideoSummaryJobResponseBodyAIVideoSummaryJobListAIVideoSummaryJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NonExistAIVideoSummaryJobIds")]
        [Validation(Required=false)]
        public ListAIVideoSummaryJobResponseBodyNonExistAIVideoSummaryJobIds NonExistAIVideoSummaryJobIds { get; set; }
        public class ListAIVideoSummaryJobResponseBodyNonExistAIVideoSummaryJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
