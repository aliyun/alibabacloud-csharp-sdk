// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIVideoFaceRecogJobResponseBody : TeaModel {
        [NameInMap("AIVideoFaceRecogJobList")]
        [Validation(Required=false)]
        public ListAIVideoFaceRecogJobResponseBodyAIVideoFaceRecogJobList AIVideoFaceRecogJobList { get; set; }
        public class ListAIVideoFaceRecogJobResponseBodyAIVideoFaceRecogJobList : TeaModel {
            [NameInMap("AIVideoFaceRecogJob")]
            [Validation(Required=false)]
            public List<ListAIVideoFaceRecogJobResponseBodyAIVideoFaceRecogJobListAIVideoFaceRecogJob> AIVideoFaceRecogJob { get; set; }
            public class ListAIVideoFaceRecogJobResponseBodyAIVideoFaceRecogJobListAIVideoFaceRecogJob : TeaModel {
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

        [NameInMap("NonExistAIVideoFaceRecogJobIds")]
        [Validation(Required=false)]
        public ListAIVideoFaceRecogJobResponseBodyNonExistAIVideoFaceRecogJobIds NonExistAIVideoFaceRecogJobIds { get; set; }
        public class ListAIVideoFaceRecogJobResponseBodyNonExistAIVideoFaceRecogJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
