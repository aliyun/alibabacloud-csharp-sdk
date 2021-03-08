// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeClientEventsResponseBodyEvents> Events { get; set; }
        public class DescribeClientEventsResponseBodyEvents : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("BytesReceived")]
            [Validation(Required=false)]
            public string BytesReceived { get; set; }

            [NameInMap("DesktopIp")]
            [Validation(Required=false)]
            public string DesktopIp { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("BytesSend")]
            [Validation(Required=false)]
            public string BytesSend { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientOS")]
            [Validation(Required=false)]
            public string ClientOS { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

        }

    }

}
