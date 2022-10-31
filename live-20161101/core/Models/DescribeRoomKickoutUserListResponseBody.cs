// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRoomKickoutUserListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<DescribeRoomKickoutUserListResponseBodyUserList> UserList { get; set; }
        public class DescribeRoomKickoutUserListResponseBodyUserList : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            [NameInMap("OpEndTime")]
            [Validation(Required=false)]
            public string OpEndTime { get; set; }

            [NameInMap("OpStartTime")]
            [Validation(Required=false)]
            public string OpStartTime { get; set; }

        }

    }

}
