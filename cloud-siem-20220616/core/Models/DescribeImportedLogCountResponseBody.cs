// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeImportedLogCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImportedLogCountResponseBodyData Data { get; set; }
        public class DescribeImportedLogCountResponseBodyData : TeaModel {
            [NameInMap("ImportedLogCount")]
            [Validation(Required=false)]
            public int? ImportedLogCount { get; set; }

            [NameInMap("TotalLogCount")]
            [Validation(Required=false)]
            public int? TotalLogCount { get; set; }

            [NameInMap("UnImportedLogCount")]
            [Validation(Required=false)]
            public int? UnImportedLogCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
