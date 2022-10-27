// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeNFSClientStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeNFSClientStatusResponseBodyResult Result { get; set; }
        public class DescribeNFSClientStatusResponseBodyResult : TeaModel {
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public int? ExitCode { get; set; }

            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
