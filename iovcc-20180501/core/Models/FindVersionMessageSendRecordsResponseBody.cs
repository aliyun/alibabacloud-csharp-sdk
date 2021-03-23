// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindVersionMessageSendRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MessageSendRecordList")]
        [Validation(Required=false)]
        public FindVersionMessageSendRecordsResponseBodyMessageSendRecordList MessageSendRecordList { get; set; }
        public class FindVersionMessageSendRecordsResponseBodyMessageSendRecordList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindVersionMessageSendRecordsResponseBodyMessageSendRecordListItems> Items { get; set; }
            public class FindVersionMessageSendRecordsResponseBodyMessageSendRecordListItems : TeaModel {
                public long? Id { get; set; }
                public string MessageType { get; set; }
                public string VersionId { get; set; }
                public string TargetId { get; set; }
                public string Result { get; set; }
                public string ResultDesc { get; set; }
                public string SucceededCount { get; set; }
                public string FailedCount { get; set; }
                public string SkippedCount { get; set; }
                public string GmtCreate { get; set; }
                public long? GmtCreateTimestamp { get; set; }
            }
        };

    }

}
