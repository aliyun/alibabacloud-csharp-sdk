// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUserInfoInChannelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsInChannel")]
        [Validation(Required=false)]
        public bool? IsInChannel { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        [NameInMap("Property")]
        [Validation(Required=false)]
        public List<DescribeUserInfoInChannelResponseBodyProperty> Property { get; set; }
        public class DescribeUserInfoInChannelResponseBodyProperty : TeaModel {
            [NameInMap("Session")]
            [Validation(Required=false)]
            public string Session { get; set; }

            [NameInMap("Join")]
            [Validation(Required=false)]
            public int? Join { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

        }

    }

}
