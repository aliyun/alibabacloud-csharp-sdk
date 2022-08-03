// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class GetAccountSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SummaryMap")]
        [Validation(Required=false)]
        public GetAccountSummaryResponseBodySummaryMap SummaryMap { get; set; }
        public class GetAccountSummaryResponseBodySummaryMap : TeaModel {
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
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public int? Policies { get; set; }
            [NameInMap("PoliciesQuota")]
            [Validation(Required=false)]
            public int? PoliciesQuota { get; set; }
            [NameInMap("PolicySizeQuota")]
            [Validation(Required=false)]
            public int? PolicySizeQuota { get; set; }
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public int? ResourceGroups { get; set; }
            [NameInMap("ResourceGroupsQuota")]
            [Validation(Required=false)]
            public int? ResourceGroupsQuota { get; set; }
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public int? Roles { get; set; }
            [NameInMap("RolesQuota")]
            [Validation(Required=false)]
            public int? RolesQuota { get; set; }
            [NameInMap("VersionsPerPolicyQuota")]
            [Validation(Required=false)]
            public int? VersionsPerPolicyQuota { get; set; }
        };

    }

}
