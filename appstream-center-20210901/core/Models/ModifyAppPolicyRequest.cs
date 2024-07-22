// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppPolicyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public ModifyAppPolicyRequestVideoPolicy VideoPolicy { get; set; }
        public class ModifyAppPolicyRequestVideoPolicy : TeaModel {
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            [NameInMap("TerminalResolutionAdaptive")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptive { get; set; }

            [NameInMap("VisualQualityStrategy")]
            [Validation(Required=false)]
            public string VisualQualityStrategy { get; set; }

            [NameInMap("Webrtc")]
            [Validation(Required=false)]
            public bool? Webrtc { get; set; }

        }

    }

}
