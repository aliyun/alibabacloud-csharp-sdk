// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListDelegatedAdministratorsResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListDelegatedAdministratorsResponseBodyAccounts Accounts { get; set; }
        public class ListDelegatedAdministratorsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListDelegatedAdministratorsResponseBodyAccountsAccount> Account { get; set; }
            public class ListDelegatedAdministratorsResponseBodyAccountsAccount : TeaModel {
                public string AccountId { get; set; }
                public string DelegationEnabledTime { get; set; }
                public string DisplayName { get; set; }
                public string JoinMethod { get; set; }
                public string ServicePrincipal { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
