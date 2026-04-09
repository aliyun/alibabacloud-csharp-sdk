// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentCallInfo : TeaModel {
        [NameInMap("CallDuration")]
        [Validation(Required=false)]
        public int? CallDuration { get; set; }

        [NameInMap("CallEndTime")]
        [Validation(Required=false)]
        public string CallEndTime { get; set; }

        [NameInMap("CallStartTime")]
        [Validation(Required=false)]
        public string CallStartTime { get; set; }

        [NameInMap("CalleeNumber")]
        [Validation(Required=false)]
        public string CalleeNumber { get; set; }

        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        [NameInMap("HangupRole")]
        [Validation(Required=false)]
        public int? HangupRole { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
