// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeDataSetMessageResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeDataSetMessageResponseBodyResult> Result { get; set; }
        public class DescribeDataSetMessageResponseBodyResult : TeaModel {
            [NameInMap("ErrorLevel")]
            [Validation(Required=false)]
            public string ErrorLevel { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

        }

    }

}
