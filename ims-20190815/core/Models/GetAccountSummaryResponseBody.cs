// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SummaryMap")]
        [Validation(Required=false)]
        public GetAccountSummaryResponseBodySummaryMap SummaryMap { get; set; }
        public class GetAccountSummaryResponseBodySummaryMap : TeaModel {
            [NameInMap("AccessKeysPerUserQuota")]
            [Validation(Required=false)]
            public int? AccessKeysPerUserQuota { get; set; }

            [NameInMap("AttachedPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerGroupQuota { get; set; }

            [NameInMap("AttachedPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerRoleQuota { get; set; }

            [NameInMap("AttachedPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedPoliciesPerUserQuota { get; set; }

            [NameInMap("AttachedSystemPoliciesPerGroupQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerGroupQuota { get; set; }

            [NameInMap("AttachedSystemPoliciesPerRoleQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerRoleQuota { get; set; }

            [NameInMap("AttachedSystemPoliciesPerUserQuota")]
            [Validation(Required=false)]
            public int? AttachedSystemPoliciesPerUserQuota { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public int? Groups { get; set; }

            [NameInMap("GroupsPerUserQuota")]
            [Validation(Required=false)]
            public int? GroupsPerUserQuota { get; set; }

            [NameInMap("GroupsQuota")]
            [Validation(Required=false)]
            public int? GroupsQuota { get; set; }

            [NameInMap("MFADevices")]
            [Validation(Required=false)]
            public int? MFADevices { get; set; }

            [NameInMap("MFADevicesInUse")]
            [Validation(Required=false)]
            public int? MFADevicesInUse { get; set; }

            [NameInMap("Policies")]
            [Validation(Required=false)]
            public int? Policies { get; set; }

            [NameInMap("PoliciesQuota")]
            [Validation(Required=false)]
            public int? PoliciesQuota { get; set; }

            [NameInMap("PolicySizeQuota")]
            [Validation(Required=false)]
            public int? PolicySizeQuota { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public int? Roles { get; set; }

            [NameInMap("RolesQuota")]
            [Validation(Required=false)]
            public int? RolesQuota { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public int? Users { get; set; }

            [NameInMap("UsersQuota")]
            [Validation(Required=false)]
            public int? UsersQuota { get; set; }

            [NameInMap("VersionsPerPolicyQuota")]
            [Validation(Required=false)]
            public int? VersionsPerPolicyQuota { get; set; }

            [NameInMap("VirtualMFADevicesQuota")]
            [Validation(Required=false)]
            public int? VirtualMFADevicesQuota { get; set; }

        }

    }

}
