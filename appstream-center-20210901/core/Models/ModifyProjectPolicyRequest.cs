// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyProjectPolicyRequest : TeaModel {
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public int? Clipboard { get; set; }

        [NameInMap("FileTransfer")]
        [Validation(Required=false)]
        public int? FileTransfer { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public int? FrameRate { get; set; }

        [NameInMap("KeepAliveDuration")]
        [Validation(Required=false)]
        public int? KeepAliveDuration { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SessionResolutionHeight")]
        [Validation(Required=false)]
        public int? SessionResolutionHeight { get; set; }

        [NameInMap("SessionResolutionWidth")]
        [Validation(Required=false)]
        public int? SessionResolutionWidth { get; set; }

        [NameInMap("StreamingMode")]
        [Validation(Required=false)]
        public string StreamingMode { get; set; }

        [NameInMap("TerminalResolutionAdaptation")]
        [Validation(Required=false)]
        public bool? TerminalResolutionAdaptation { get; set; }

    }

}
