// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateOrgHonorTemplateRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateOrgHonorTemplateRequestTenantContext TenantContext { get; set; }
        public class CreateOrgHonorTemplateRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("avatarFrameMediaId")]
        [Validation(Required=false)]
        public string AvatarFrameMediaId { get; set; }

        [NameInMap("defaultBgColor")]
        [Validation(Required=false)]
        public string DefaultBgColor { get; set; }

        [NameInMap("medalDesc")]
        [Validation(Required=false)]
        public string MedalDesc { get; set; }

        [NameInMap("medalMediaId")]
        [Validation(Required=false)]
        public string MedalMediaId { get; set; }

        [NameInMap("medalName")]
        [Validation(Required=false)]
        public string MedalName { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
