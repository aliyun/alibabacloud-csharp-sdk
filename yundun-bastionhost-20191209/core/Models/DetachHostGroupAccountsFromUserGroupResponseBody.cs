// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostGroupAccountsFromUserGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachHostGroupAccountsFromUserGroupResponseBodyResults> Results { get; set; }
        public class DetachHostGroupAccountsFromUserGroupResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<DetachHostGroupAccountsFromUserGroupResponseBodyResultsHostAccountNames> HostAccountNames { get; set; }
            public class DetachHostGroupAccountsFromUserGroupResponseBodyResultsHostAccountNames : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("HostAccountName")]
                [Validation(Required=false)]
                public string HostAccountName { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
