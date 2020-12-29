// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateFabricConsortiumMemberRequest : TeaModel {
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateFabricConsortiumMemberRequestOrganization> Organization { get; set; }
        public class CreateFabricConsortiumMemberRequestOrganization : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
