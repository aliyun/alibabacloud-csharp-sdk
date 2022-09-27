// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitTraceAbRequest : TeaModel {
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        [NameInMap("CipherBase64ed")]
        [Validation(Required=false)]
        public string CipherBase64ed { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
