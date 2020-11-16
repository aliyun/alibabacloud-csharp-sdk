// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRoomKickoutUserListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=true)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=true)]
        public List<DescribeRoomKickoutUserListResponseUserList> UserList { get; set; }
        public class DescribeRoomKickoutUserListResponseUserList : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=true)]
            public string AppUid { get; set; }

            [NameInMap("OpStartTime")]
            [Validation(Required=true)]
            public string OpStartTime { get; set; }

            [NameInMap("OpEndTime")]
            [Validation(Required=true)]
            public string OpEndTime { get; set; }

        }

    }

}
