// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeAssistReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AssistResult")]
        [Validation(Required=false)]
        public string AssistResult { get; set; }

        [NameInMap("AssistReason")]
        [Validation(Required=false)]
        public string AssistReason { get; set; }

        [NameInMap("AssistId")]
        [Validation(Required=false)]
        public string AssistId { get; set; }

        [NameInMap("AssistDescription")]
        [Validation(Required=false)]
        public string AssistDescription { get; set; }

        [NameInMap("AssistTag")]
        [Validation(Required=false)]
        public string AssistTag { get; set; }

    }

}
