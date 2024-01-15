// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetProjectPoliciesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectPoliciesResponseBodyData Data { get; set; }
        public class GetProjectPoliciesResponseBodyData : TeaModel {
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public int? Clipboard { get; set; }

            [NameInMap("FileTransfer")]
            [Validation(Required=false)]
            public int? FileTransfer { get; set; }

            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public string FrameRate { get; set; }

            [NameInMap("KeepAliveDuration")]
            [Validation(Required=false)]
            public int? KeepAliveDuration { get; set; }

            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public int? MaxHours { get; set; }

            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public int? MaxSessions { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            [NameInMap("TerminalResolutionAdaptation")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptation { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
