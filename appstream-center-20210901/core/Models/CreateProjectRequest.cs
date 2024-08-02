// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public int? Clipboard { get; set; }

        [NameInMap("CloudEnvId")]
        [Validation(Required=false)]
        public string CloudEnvId { get; set; }

        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public string ContentId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FileTransfer")]
        [Validation(Required=false)]
        public int? FileTransfer { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public int? FrameRate { get; set; }

        [NameInMap("KeepAliveDuration")]
        [Validation(Required=false)]
        public int? KeepAliveDuration { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

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

}
