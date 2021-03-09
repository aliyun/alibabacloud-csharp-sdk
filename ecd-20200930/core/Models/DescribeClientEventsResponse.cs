// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Events")]
        [Validation(Required=true)]
        public List<DescribeClientEventsResponseEvents> Events { get; set; }
        public class DescribeClientEventsResponseEvents : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=true)]
            public string EventId { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=true)]
            public string EventType { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=true)]
            public string EventTime { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=true)]
            public string RegionId { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=true)]
            public string AliUid { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=true)]
            public string EndUserId { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopIp")]
            [Validation(Required=true)]
            public string DesktopIp { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=true)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=true)]
            public string DirectoryType { get; set; }

            [NameInMap("ClientOS")]
            [Validation(Required=true)]
            public string ClientOS { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=true)]
            public string ClientVersion { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=true)]
            public string ClientIp { get; set; }

            [NameInMap("BytesSend")]
            [Validation(Required=true)]
            public string BytesSend { get; set; }

            [NameInMap("BytesReceived")]
            [Validation(Required=true)]
            public string BytesReceived { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}
