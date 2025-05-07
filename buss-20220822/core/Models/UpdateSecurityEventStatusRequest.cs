// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class UpdateSecurityEventStatusRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("callerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        [NameInMap("callerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

    }

}
