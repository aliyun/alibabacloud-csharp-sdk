// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannelSnapshot : TeaModel {
        [NameInMap("DestBucket")]
        [Validation(Required=false)]
        public string DestBucket { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("NotifyTopic")]
        [Validation(Required=false)]
        public string NotifyTopic { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
