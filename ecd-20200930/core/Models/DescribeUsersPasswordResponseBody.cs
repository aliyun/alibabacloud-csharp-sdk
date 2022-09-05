// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersPasswordResponseBody : TeaModel {
        [NameInMap("DesktopUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersPasswordResponseBodyDesktopUsers> DesktopUsers { get; set; }
        public class DescribeUsersPasswordResponseBodyDesktopUsers : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
