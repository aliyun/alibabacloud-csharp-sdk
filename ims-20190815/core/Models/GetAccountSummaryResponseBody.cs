// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSummaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The overview information of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("SummaryMap")]
        [Validation(Required=false)]
        public GetAccountSummaryResponseBodySummaryMap SummaryMap { get; set; }
        public class GetAccountSummaryResponseBodySummaryMap : TeaModel {
            /// <summary>
            /// The maximum number of AccessKey pairs that a RAM user can have.
            /// </summary>
            [NameInMap("AccessKeysPerUserQuota")]
            [Validation(Required=false)]
            public int? AccessKeysPerUserQuota { get; set; }

            /// <summary>
            /// The maximum number of custom policies that can be added to a RAM user group.
            /// </summary>
            [NameInMap("AttachedPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerGroupQuota { get; set; }

            /// <summary>
            /// The maximum number of custom policies that can be added to a RAM role.
            /// </summary>
            [NameInMap("AttachedPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerRoleQuota { get; set; }

            /// <summary>
            /// The maximum number of custom policies that can be added to a RAM user.
            /// </summary>
            [NameInMap("AttachedPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerUserQuota { get; set; }

            /// <summary>
            /// The maximum number of system policies that can be added to a RAM user group.
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerGroupQuota { get; set; }

            /// <summary>
            /// The maximum number of system policies that can be added to a RAM role.
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerRoleQuota { get; set; }

            /// <summary>
            /// The maximum number of system policies that can be added to a RAM user.
            /// </summary>
            [NameInMap("AttachedSystemPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerUserQuota { get; set; }

            /// <summary>
            /// The number of RAM user groups.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public int? Groups { get; set; }

            /// <summary>
            /// The maximum number of RAM user groups to which a RAM user can be added.
            /// </summary>
            [NameInMap("GroupsPerUserQuota")]
            [Validation(Required=false)]
            public int? GroupsPerUserQuota { get; set; }

            /// <summary>
            /// The maximum number of RAM user groups that can be created.
            /// </summary>
            [NameInMap("GroupsQuota")]
            [Validation(Required=false)]
            public int? GroupsQuota { get; set; }

            /// <summary>
            /// The number of virtual multi-factor authentication (MFA) devices.
            /// </summary>
            [NameInMap("MFADevices")]
            [Validation(Required=false)]
            public int? MFADevices { get; set; }

            /// <summary>
            /// The number of virtual MFA devices in use.
            /// </summary>
            [NameInMap("MFADevicesInUse")]
            [Validation(Required=false)]
            public int? MFADevicesInUse { get; set; }

            /// <summary>
            /// The number of custom policies.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public int? Policies { get; set; }

            /// <summary>
            /// The maximum number of custom policies that can be created.
            /// </summary>
            [NameInMap("PoliciesQuota")]
            [Validation(Required=false)]
            public int? PoliciesQuota { get; set; }

            /// <summary>
            /// The maximum length of the policy content.
            /// </summary>
            [NameInMap("PolicySizeQuota")]
            [Validation(Required=false)]
            public int? PolicySizeQuota { get; set; }

            /// <summary>
            /// The number of RAM roles.
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public int? Roles { get; set; }

            /// <summary>
            /// The maximum number of RAM roles that can be created.
            /// </summary>
            [NameInMap("RolesQuota")]
            [Validation(Required=false)]
            public int? RolesQuota { get; set; }

            /// <summary>
            /// The number of RAM users.
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public int? Users { get; set; }

            /// <summary>
            /// The maximum number of RAM users that can be created.
            /// </summary>
            [NameInMap("UsersQuota")]
            [Validation(Required=false)]
            public int? UsersQuota { get; set; }

            /// <summary>
            /// The maximum number of policy versions.
            /// </summary>
            [NameInMap("VersionsPerPolicyQuota")]
            [Validation(Required=false)]
            public int? VersionsPerPolicyQuota { get; set; }

            /// <summary>
            /// The maximum number of virtual MFA devices that can be created.
            /// </summary>
            [NameInMap("VirtualMFADevicesQuota")]
            [Validation(Required=false)]
            public int? VirtualMFADevicesQuota { get; set; }

        }

    }

}
