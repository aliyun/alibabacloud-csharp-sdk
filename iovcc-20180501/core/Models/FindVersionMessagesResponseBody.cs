// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindVersionMessagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public FindVersionMessagesResponseBodyMessageList MessageList { get; set; }
        public class FindVersionMessagesResponseBodyMessageList : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindVersionMessagesResponseBodyMessageListItems> Items { get; set; }
            public class FindVersionMessagesResponseBodyMessageListItems : TeaModel {
                public long? GmtModifyTimestamp { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public string Status { get; set; }
                public string GmtModify { get; set; }
                public string MessageId { get; set; }
                public string DeviceId { get; set; }
                public string GmtCreate { get; set; }
                public string VersionId { get; set; }
                public string StatusDesc { get; set; }
                public string TestId { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
