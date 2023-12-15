// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ConfirmConsortiumMemberRequest : TeaModel {
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<ConfirmConsortiumMemberRequestOrganization> Organization { get; set; }
        public class ConfirmConsortiumMemberRequestOrganization : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
