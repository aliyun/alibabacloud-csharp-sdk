// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81313F5E-3C85-478F-BCC9-E1B70E4556DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The overview information about the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("SummaryMap")]
        [Validation(Required=false)]
        public GetAccountSummaryResponseBodySummaryMap SummaryMap { get; set; }
        public class GetAccountSummaryResponseBodySummaryMap : TeaModel {
            /// <summary>
            /// <para>The maximum number of AccessKey pairs that a Resource Access Management (RAM) user can have.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AccessKeysPerUserQuota")]
            [Validation(Required=false)]
            public int? AccessKeysPerUserQuota { get; set; }

            [NameInMap("AccountAccessKeysPerAccountQuota")]
            [Validation(Required=false)]
            public int? AccountAccessKeysPerAccountQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of custom policies that can be added to a RAM user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AttachedPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerGroupQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of custom policies that can be added to a RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AttachedPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerRoleQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of custom policies that can be added to a RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AttachedPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerUserQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of system policies that can be added to a RAM user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerGroupQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of system policies that can be added to a RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerRoleQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of system policies that can be added to a RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerUserQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of network access control policies that can be configured for an Alibaba Cloud account or AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ConditionsPerAKPolicyQuota")]
            [Validation(Required=false)]
            public int? ConditionsPerAKPolicyQuota { get; set; }

            /// <summary>
            /// <para>The number of RAM user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public int? Groups { get; set; }

            /// <summary>
            /// <para>The maximum number of RAM user groups to which a RAM user can be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("GroupsPerUserQuota")]
            [Validation(Required=false)]
            public int? GroupsPerUserQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of RAM user groups that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("GroupsQuota")]
            [Validation(Required=false)]
            public int? GroupsQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses that can be specified in an account-level AccessKey pair-based or AccessKey pair-level policy for network access control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("IPItemsPerAKPolicyQuota")]
            [Validation(Required=false)]
            public int? IPItemsPerAKPolicyQuota { get; set; }

            /// <summary>
            /// <para>The number of virtual multi-factor authentication (MFA) devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("MFADevices")]
            [Validation(Required=false)]
            public int? MFADevices { get; set; }

            /// <summary>
            /// <para>The number of virtual MFA devices in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MFADevicesInUse")]
            [Validation(Required=false)]
            public int? MFADevicesInUse { get; set; }

            /// <summary>
            /// <para>The number of custom policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public int? Policies { get; set; }

            /// <summary>
            /// <para>The maximum number of custom policies that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("PoliciesQuota")]
            [Validation(Required=false)]
            public int? PoliciesQuota { get; set; }

            /// <summary>
            /// <para>The maximum length of the policy content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("PolicySizeQuota")]
            [Validation(Required=false)]
            public int? PolicySizeQuota { get; set; }

            /// <summary>
            /// <para>The number of RAM roles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public int? Roles { get; set; }

            /// <summary>
            /// <para>The maximum number of RAM roles that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RolesQuota")]
            [Validation(Required=false)]
            public int? RolesQuota { get; set; }

            /// <summary>
            /// <para>The number of RAM users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public int? Users { get; set; }

            /// <summary>
            /// <para>The maximum number of RAM users that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("UsersQuota")]
            [Validation(Required=false)]
            public int? UsersQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of policy versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VersionsPerPolicyQuota")]
            [Validation(Required=false)]
            public int? VersionsPerPolicyQuota { get; set; }

            /// <summary>
            /// <para>The maximum number of virtual MFA devices that can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("VirtualMFADevicesQuota")]
            [Validation(Required=false)]
            public int? VirtualMFADevicesQuota { get; set; }

        }

    }

}
