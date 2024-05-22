// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveTranscodeJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartMode")]
        [Validation(Required=false)]
        public int? StartMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveTranscodeJobRequestStreamInput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestTimedConfig TimedConfig { get; set; }
        public class SubmitLiveTranscodeJobRequestTimedConfig : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public SubmitLiveTranscodeJobRequestTranscodeOutput TranscodeOutput { get; set; }
        public class SubmitLiveTranscodeJobRequestTranscodeOutput : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
