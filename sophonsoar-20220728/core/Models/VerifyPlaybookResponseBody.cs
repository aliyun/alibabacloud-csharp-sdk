// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPlaybookResponseBody : TeaModel {
        [NameInMap("CheckTaskInfos")]
        [Validation(Required=false)]
        public List<VerifyPlaybookResponseBodyCheckTaskInfos> CheckTaskInfos { get; set; }
        public class VerifyPlaybookResponseBodyCheckTaskInfos : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
