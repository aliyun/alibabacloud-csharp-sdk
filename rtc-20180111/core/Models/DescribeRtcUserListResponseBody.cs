// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcUserListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeRtcUserListResponseBodyUserList UserList { get; set; }
        public class DescribeRtcUserListResponseBodyUserList : TeaModel {
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<DescribeRtcUserListResponseBodyUserListUserList> UserList { get; set; }
            public class DescribeRtcUserListResponseBodyUserListUserList : TeaModel {
                public string User { get; set; }
            }
        };

    }

}
