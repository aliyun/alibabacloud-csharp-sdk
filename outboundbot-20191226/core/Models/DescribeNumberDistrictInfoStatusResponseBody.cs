// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeNumberDistrictInfoStatusResponseBody : TeaModel {
        [NameInMap("AppliedVersion")]
        [Validation(Required=false)]
        public DescribeNumberDistrictInfoStatusResponseBodyAppliedVersion AppliedVersion { get; set; }
        public class DescribeNumberDistrictInfoStatusResponseBodyAppliedVersion : TeaModel {
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ParsingVersion")]
        [Validation(Required=false)]
        public DescribeNumberDistrictInfoStatusResponseBodyParsingVersion ParsingVersion { get; set; }
        public class DescribeNumberDistrictInfoStatusResponseBodyParsingVersion : TeaModel {
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("ParseProgress")]
            [Validation(Required=false)]
            public long? ParseProgress { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
