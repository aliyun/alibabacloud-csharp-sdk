// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopOversoldGroupResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDesktopOversoldGroupResponseBodyData> Data { get; set; }
        public class DescribeDesktopOversoldGroupResponseBodyData : TeaModel {
            [NameInMap("ConcurrenceCount")]
            [Validation(Required=false)]
            public int? ConcurrenceCount { get; set; }

            [NameInMap("CurConcurrenceCount")]
            [Validation(Required=false)]
            public int? CurConcurrenceCount { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public string IdleDisconnectDuration { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public string KeepDuration { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OversoldGroupId")]
            [Validation(Required=false)]
            public string OversoldGroupId { get; set; }

            [NameInMap("OversoldUserCount")]
            [Validation(Required=false)]
            public int? OversoldUserCount { get; set; }

            [NameInMap("OversoldWarn")]
            [Validation(Required=false)]
            public int? OversoldWarn { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("SaleStatus")]
            [Validation(Required=false)]
            public string SaleStatus { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
