// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterKubeconfigStatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListClusterKubeconfigStatesResponseBodyPage Page { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The status list of the kubeconfig files associated with the cluster.</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListClusterKubeconfigStatesResponseBodyStates> States { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// <para>The displayed name or role name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("account_display_name")]
            [Validation(Required=false)]
            public string AccountDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of an Alibaba Cloud account, RAM user, or RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22855*****************</para>
            /// </summary>
            [NameInMap("account_id")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The logon name or role name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("account_name")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The status of the account.</para>
            /// <list type="bullet">
            /// <item><description>Active: The account is active.</description></item>
            /// <item><description>InActive: The account is locked.</description></item>
            /// <item><description>Deleted: The account is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("account_state")]
            [Validation(Required=false)]
            public string AccountState { get; set; }

            /// <summary>
            /// <para>The type of the account.</para>
            /// <list type="bullet">
            /// <item><description>RootAccount: Alibaba Cloud account.</description></item>
            /// <item><description>RamUser: RAM user.</description></item>
            /// <item><description>RamRole: RAM role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamUser</para>
            /// </summary>
            [NameInMap("account_type")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The expiration time of the client certificate for the kubeconfig file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-07-15T01:32:20Z</para>
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the client certificate for the kubeconfig file.</para>
            /// <list type="bullet">
            /// <item><description>Unexpired: The certificate is not expired.</description></item>
            /// <item><description>Expired: The certificate is expired.</description></item>
            /// <item><description>Unknown: The status of the certificate is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Expired</para>
            /// </summary>
            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            /// <summary>
            /// <para>Indicates whether the client certificate for the kubeconfig file can be revoked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("revokable")]
            [Validation(Required=false)]
            public bool? Revokable { get; set; }

        }

    }

}
