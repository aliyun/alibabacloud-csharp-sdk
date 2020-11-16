// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ForbidLiveStreamRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=true)]
        public string StreamName { get; set; }

        [NameInMap("LiveStreamType")]
        [Validation(Required=true)]
        public string LiveStreamType { get; set; }

        [NameInMap("Oneshot")]
        [Validation(Required=false)]
        public string Oneshot { get; set; }

        [NameInMap("ResumeTime")]
        [Validation(Required=false)]
        public string ResumeTime { get; set; }

    }

}
