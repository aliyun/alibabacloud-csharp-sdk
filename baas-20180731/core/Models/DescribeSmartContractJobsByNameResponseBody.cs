// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeSmartContractJobsByNameResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeSmartContractJobsByNameResponseBodyResult Result { get; set; }
        public class DescribeSmartContractJobsByNameResponseBodyResult : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeSmartContractJobsByNameResponseBodyResultContent> Content { get; set; }
            public class DescribeSmartContractJobsByNameResponseBodyResultContent : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public long? FinishedTime { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserBid")]
                [Validation(Required=false)]
                public string UserBid { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("First")]
            [Validation(Required=false)]
            public bool? First { get; set; }

            [NameInMap("Last")]
            [Validation(Required=false)]
            public bool? Last { get; set; }

            [NameInMap("NumberOfElements")]
            [Validation(Required=false)]
            public int? NumberOfElements { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
