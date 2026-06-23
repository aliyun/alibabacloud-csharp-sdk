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
            /// <para>The maximum number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of KubeConfig states associated with the cluster.</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListClusterKubeconfigStatesResponseBodyStates> States { get; set; }
        public class ListClusterKubeconfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// <para>The display name of the Resource Access Management (RAM) user or the role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("account_display_name")]
            [Validation(Required=false)]
            public string AccountDisplayName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account, Resource Access Management (RAM) user, or role ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22855*****************</para>
            /// </summary>
            [NameInMap("account_id")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The logon name of the Resource Access Management (RAM) user or the role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("account_name")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The account status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: The account is active.</para>
            /// </description></item>
            /// <item><description><para>InActive: The account is frozen.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The account is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("account_state")]
            [Validation(Required=false)]
            public string AccountState { get; set; }

            /// <summary>
            /// <para>The account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RootAccount: Alibaba Cloud account.</description></item>
            /// <item><description>RamUser: Resource Access Management (RAM) user.</description></item>
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
            /// <para>The expiration time of the KubeConfig client certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-07-15T01:32:20Z</para>
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the KubeConfig client certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Unexpired: The certificate has not expired.</para>
            /// </description></item>
            /// <item><description><para>Expired: The certificate has expired.</para>
            /// </description></item>
            /// <item><description><para>Unknown: The certificate status is unknown (abnormal state).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Expired</para>
            /// </summary>
            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            /// <summary>
            /// <para>The name of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs/ecs/sls</para>
            /// </summary>
            [NameInMap("cloud_service_name")]
            [Validation(Required=false)]
            public string CloudServiceName { get; set; }

            /// <summary>
            /// <para>The list of cluster roles associated with the cloud service role.</para>
            /// </summary>
            [NameInMap("cloud_service_roles")]
            [Validation(Required=false)]
            public List<ListClusterKubeconfigStatesResponseBodyStatesCloudServiceRoles> CloudServiceRoles { get; set; }
            public class ListClusterKubeconfigStatesResponseBodyStatesCloudServiceRoles : TeaModel {
                /// <summary>
                /// <para>Indicates whether the content matches the default cluster role template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The content matches the default template.</description></item>
                /// <item><description>false: The content does not match the default template.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("is_default_template")]
                [Validation(Required=false)]
                public bool? IsDefaultTemplate { get; set; }

                /// <summary>
                /// <para>The name of the cluster role associated with the cloud service role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster-admin</para>
                /// </summary>
                [NameInMap("role_name")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The namespace of the cluster role associated with the cloud service role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kube-system</para>
                /// </summary>
                [NameInMap("role_namespace")]
                [Validation(Required=false)]
                public string RoleNamespace { get; set; }

                /// <summary>
                /// <para>The type of the cluster role associated with the cloud service role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClusterRole</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the KubeConfig client certificate can be revoked.</para>
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
