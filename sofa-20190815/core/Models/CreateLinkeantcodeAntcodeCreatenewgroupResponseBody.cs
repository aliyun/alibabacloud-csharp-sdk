// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeCreatenewgroupResponseBody : TeaModel {
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MembersTotal")]
        [Validation(Required=false)]
        public long? MembersTotal { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("WebUrl")]
        [Validation(Required=false)]
        public string WebUrl { get; set; }

        [NameInMap("Public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectsTotal")]
        [Validation(Required=false)]
        public long? ProjectsTotal { get; set; }

        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeCreatenewgroupResponseBodyTenant Tenant { get; set; }
        public class CreateLinkeantcodeAntcodeCreatenewgroupResponseBodyTenant : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }
            [NameInMap("WhileListIp")]
            [Validation(Required=false)]
            public string WhileListIp { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public CreateLinkeantcodeAntcodeCreatenewgroupResponseBodyPermission Permission { get; set; }
        public class CreateLinkeantcodeAntcodeCreatenewgroupResponseBodyPermission : TeaModel {
            [NameInMap("ProjectAccess")]
            [Validation(Required=false)]
            public string ProjectAccess { get; set; }
            [NameInMap("ReviewAccess")]
            [Validation(Required=false)]
            public string ReviewAccess { get; set; }
            [NameInMap("GroupAccess")]
            [Validation(Required=false)]
            public string GroupAccess { get; set; }
            [NameInMap("TenantAccess")]
            [Validation(Required=false)]
            public string TenantAccess { get; set; }
        };

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
