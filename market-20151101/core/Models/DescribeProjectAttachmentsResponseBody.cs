// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectAttachmentsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeProjectAttachmentsResponseBodyResult> Result { get; set; }
        public class DescribeProjectAttachmentsResponseBodyResult : TeaModel {
            [NameInMap("AttachmentToken")]
            [Validation(Required=false)]
            public string AttachmentToken { get; set; }

            [NameInMap("AttachmentType")]
            [Validation(Required=false)]
            public string AttachmentType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FileLink")]
            [Validation(Required=false)]
            public string FileLink { get; set; }

            [NameInMap("FileLinkGmtExpired")]
            [Validation(Required=false)]
            public long? FileLinkGmtExpired { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public long? Operator { get; set; }

            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

            [NameInMap("StepNo")]
            [Validation(Required=false)]
            public int? StepNo { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
