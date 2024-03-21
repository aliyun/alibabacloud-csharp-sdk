// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class ReportSessionStatusRequest : TeaModel {
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SessionChangeTime")]
        [Validation(Required=false)]
        public long? SessionChangeTime { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("SessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

    }

}
