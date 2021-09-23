// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachHostAccountsToUserGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachHostAccountsToUserGroupResponseBodyResults> Results { get; set; }
        public class AttachHostAccountsToUserGroupResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            [NameInMap("HostAccounts")]
            [Validation(Required=false)]
            public List<AttachHostAccountsToUserGroupResponseBodyResultsHostAccounts> HostAccounts { get; set; }
            public class AttachHostAccountsToUserGroupResponseBodyResultsHostAccounts : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("HostAccountId")]
                [Validation(Required=false)]
                public string HostAccountId { get; set; }

            }

        }

    }

}
