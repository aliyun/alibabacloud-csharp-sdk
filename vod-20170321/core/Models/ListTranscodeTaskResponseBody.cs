// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeTaskList")]
        [Validation(Required=false)]
        public List<ListTranscodeTaskResponseBodyTranscodeTaskList> TranscodeTaskList { get; set; }
        public class ListTranscodeTaskResponseBodyTranscodeTaskList : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

        }

    }

}
