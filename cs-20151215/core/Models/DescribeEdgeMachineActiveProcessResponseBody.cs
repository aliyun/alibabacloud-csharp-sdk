// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineActiveProcessResponseBody : TeaModel {
        [NameInMap("logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
