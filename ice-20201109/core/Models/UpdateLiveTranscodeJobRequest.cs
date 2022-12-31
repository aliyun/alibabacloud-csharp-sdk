// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveTranscodeJobRequest : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestStreamInput StreamInput { get; set; }
        public class UpdateLiveTranscodeJobRequestStreamInput : TeaModel {
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("TimedConfig")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestTimedConfig TimedConfig { get; set; }
        public class UpdateLiveTranscodeJobRequestTimedConfig : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("TranscodeOutput")]
        [Validation(Required=false)]
        public UpdateLiveTranscodeJobRequestTranscodeOutput TranscodeOutput { get; set; }
        public class UpdateLiveTranscodeJobRequestTranscodeOutput : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
