// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DelayPublishOsVersionRequest : TeaModel {
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("PrepubTime")]
        [Validation(Required=false)]
        public long? PrepubTime { get; set; }

        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public long? PublishTime { get; set; }

        [NameInMap("DownTime")]
        [Validation(Required=false)]
        public long? DownTime { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SendMessage")]
        [Validation(Required=false)]
        public string SendMessage { get; set; }

        [NameInMap("PrepublishCount")]
        [Validation(Required=false)]
        public string PrepublishCount { get; set; }

    }

}
