// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIJobResponseBody : TeaModel {
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class ListAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<ListAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class ListAIJobResponseBodyAIJobListAIJob : TeaModel {
                public string Code { get; set; }
                public string CompleteTime { get; set; }
                public string CreationTime { get; set; }
                public string Data { get; set; }
                public string JobId { get; set; }
                public string MediaId { get; set; }
                public string Message { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("NonExistAIJobIds")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyNonExistAIJobIds NonExistAIJobIds { get; set; }
        public class ListAIJobResponseBodyNonExistAIJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
