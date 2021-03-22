// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DescribeAsyncTaskStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAsyncTaskStatusResponseBodyResult Result { get; set; }
        public class DescribeAsyncTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("AsyncTaskStatus")]
            [Validation(Required=false)]
            public string AsyncTaskStatus { get; set; }
        };

    }

}
