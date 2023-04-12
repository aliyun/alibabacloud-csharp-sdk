// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListDelegatedAdministratorsResponseBody : TeaModel {
        /// <summary>
        /// The information about the delegated administrator accounts.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListDelegatedAdministratorsResponseBodyAccounts Accounts { get; set; }
        public class ListDelegatedAdministratorsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListDelegatedAdministratorsResponseBodyAccountsAccount> Account { get; set; }
            public class ListDelegatedAdministratorsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// The Alibaba Cloud account ID of the member.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The time when the member was specified as a delegated administrator account.
                /// </summary>
                [NameInMap("DelegationEnabledTime")]
                [Validation(Required=false)]
                public string DelegationEnabledTime { get; set; }

                /// <summary>
                /// The display name of the member.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The way in which the member joins the resource directory. Valid values:
                /// 
                /// *   invited: The member is invited to join the resource directory.
                /// *   created: The member is directly created in the resource directory.
                /// </summary>
                [NameInMap("JoinMethod")]
                [Validation(Required=false)]
                public string JoinMethod { get; set; }

                /// <summary>
                /// The identifier of the trusted service.
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
