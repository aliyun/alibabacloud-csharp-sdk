// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamTranscodeRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        [NameInMap("EncryptParameters")]
        [Validation(Required=false)]
        public string EncryptParameters { get; set; }

        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

    }

}
