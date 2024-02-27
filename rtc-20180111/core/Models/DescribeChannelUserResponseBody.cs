// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUserResponseBody : TeaModel {
        [NameInMap("ChannelExist")]
        [Validation(Required=false)]
        public bool? ChannelExist { get; set; }

        [NameInMap("InChannel")]
        [Validation(Required=false)]
        public bool? InChannel { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeChannelUserResponseBodySessions> Sessions { get; set; }
        public class DescribeChannelUserResponseBodySessions : TeaModel {
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public long? Joined { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
