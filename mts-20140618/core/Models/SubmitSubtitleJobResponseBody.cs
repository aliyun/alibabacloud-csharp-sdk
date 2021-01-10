// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitSubtitleJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubtitleJob")]
        [Validation(Required=false)]
        public SubmitSubtitleJobResponseBodySubtitleJob SubtitleJob { get; set; }
        public class SubmitSubtitleJobResponseBodySubtitleJob : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
        };

    }

}
