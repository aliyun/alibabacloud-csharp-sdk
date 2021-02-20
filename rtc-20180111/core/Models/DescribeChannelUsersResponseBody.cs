// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InteractiveUserList")]
        [Validation(Required=false)]
        public List<string> InteractiveUserList { get; set; }

        [NameInMap("LiveUserNum")]
        [Validation(Required=false)]
        public int? LiveUserNum { get; set; }

        [NameInMap("ChannelProfile")]
        [Validation(Required=false)]
        public int? ChannelProfile { get; set; }

        [NameInMap("InteractiveUserNum")]
        [Validation(Required=false)]
        public int? InteractiveUserNum { get; set; }

        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

        [NameInMap("LiveUserList")]
        [Validation(Required=false)]
        public List<string> LiveUserList { get; set; }

        [NameInMap("CommTotalNum")]
        [Validation(Required=false)]
        public int? CommTotalNum { get; set; }

    }

}
