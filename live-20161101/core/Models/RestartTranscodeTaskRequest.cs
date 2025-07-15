// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RestartTranscodeTaskRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("TranscodingTemplate")]
        [Validation(Required=false)]
        public string TranscodingTemplate { get; set; }

    }

}
