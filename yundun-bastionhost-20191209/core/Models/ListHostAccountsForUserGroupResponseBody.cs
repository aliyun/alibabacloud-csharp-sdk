// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForUserGroupResponseBody : TeaModel {
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForUserGroupResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForUserGroupResponseBodyHostAccounts : TeaModel {
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("IsAuthorized")]
            [Validation(Required=false)]
            public bool? IsAuthorized { get; set; }

            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
