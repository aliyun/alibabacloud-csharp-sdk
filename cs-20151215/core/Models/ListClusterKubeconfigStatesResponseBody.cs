// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterKubeconfigStatesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListClusterKubeconfigStatesResponseBodyPage Page { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyPage : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The status list of the kubeconfig files associated with the cluster.
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListClusterKubeconfigStatesResponseBodyStates> States { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// The displayed name or role name of the RAM user.
            /// </summary>
            [NameInMap("account_display_name")]
            [Validation(Required=false)]
            public string AccountDisplayName { get; set; }

            /// <summary>
            /// The ID of an Alibaba Cloud account, RAM user, or RAM role.
            /// </summary>
            [NameInMap("account_id")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The logon name or role name of the RAM user.
            /// </summary>
            [NameInMap("account_name")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The status of the account.
            /// 
            /// *   Active: The account is active.
            /// *   InActive: The account is locked.
            /// *   Deleted: The account is deleted.
            /// </summary>
            [NameInMap("account_state")]
            [Validation(Required=false)]
            public string AccountState { get; set; }

            /// <summary>
            /// The type of the account.
            /// 
            /// *   RootAccount: Alibaba Cloud account.
            /// *   RamUser: RAM user.
            /// *   RamRole: RAM role.
            /// </summary>
            [NameInMap("account_type")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// The expiration time of the client certificate for the kubeconfig file.
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// The status of the client certificate for the kubeconfig file.
            /// 
            /// *   Unexpired: The certificate is not expired.
            /// *   Expired: The certificate is expired.
            /// *   Unknown: The status of the certificate is unknown.
            /// </summary>
            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            /// <summary>
            /// Indicates whether the client certificate for the kubeconfig file can be revoked.
            /// </summary>
            [NameInMap("revokable")]
            [Validation(Required=false)]
            public bool? Revokable { get; set; }

        }

    }

}
