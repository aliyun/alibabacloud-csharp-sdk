// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelParticipantsResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeChannelParticipantsResponseBodyUserList UserList { get; set; }
        public class DescribeChannelParticipantsResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<string> User { get; set; }
        };

    }

}
