// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribePreCheckResultResponseBody : TeaModel {
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public DescribePreCheckResultResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class DescribePreCheckResultResponseBodyPreCheckResult : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("PreCheckName")]
            [Validation(Required=false)]
            public string PreCheckName { get; set; }
            [NameInMap("SubCheckItems")]
            [Validation(Required=false)]
            public List<DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems> SubCheckItems { get; set; }
            public class DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems : TeaModel {
                public string ErrorMsgCode { get; set; }
                public string State { get; set; }
                public List<string> ErrorMsgParams { get; set; }
                public string PreCheckItemName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
