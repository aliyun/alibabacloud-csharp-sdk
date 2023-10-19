// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseRoleMemberResponse : TeaModel {
        [NameInMap("assignment_list")]
        [Validation(Required=false)]
        public List<BaseAssignmentResponse> AssignmentList { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        [NameInMap("identity_name")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        [NameInMap("is_admin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        [NameInMap("subdomain_id")]
        [Validation(Required=false)]
        public string SubdomainId { get; set; }

    }

}
