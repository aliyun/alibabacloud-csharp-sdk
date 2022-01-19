// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribePhoneInfoResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("detectTime")]
        [Validation(Required=false)]
        public string DetectTime { get; set; }

        [NameInMap("phoneNum")]
        [Validation(Required=false)]
        public long? PhoneNum { get; set; }

        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public long? RiskLevel { get; set; }

    }

}
