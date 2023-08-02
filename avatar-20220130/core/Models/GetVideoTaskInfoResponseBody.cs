// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class GetVideoTaskInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVideoTaskInfoResponseBodyData Data { get; set; }
        public class GetVideoTaskInfoResponseBodyData : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public GetVideoTaskInfoResponseBodyDataTaskResult TaskResult { get; set; }
            public class GetVideoTaskInfoResponseBodyDataTaskResult : TeaModel {
                [NameInMap("AlphaUrl")]
                [Validation(Required=false)]
                public string AlphaUrl { get; set; }

                [NameInMap("FailCode")]
                [Validation(Required=false)]
                public string FailCode { get; set; }

                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                [NameInMap("SubtitlesUrl")]
                [Validation(Required=false)]
                public string SubtitlesUrl { get; set; }

                [NameInMap("VideoDuration")]
                [Validation(Required=false)]
                public int? VideoDuration { get; set; }

                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

                /// <summary>
                /// 字粒度的时间戳文件，特定任务支持
                /// </summary>
                [NameInMap("WordSubtitlesUrl")]
                [Validation(Required=false)]
                public string WordSubtitlesUrl { get; set; }

            }

            [NameInMap("TaskUuid")]
            [Validation(Required=false)]
            public string TaskUuid { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
