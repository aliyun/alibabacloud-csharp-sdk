// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreatePidOrganizationRequest : TeaModel {
        [NameInMap("OrganizationName")]
        [Validation(Required=true)]
        public string OrganizationName { get; set; }

        [NameInMap("ParentOrganizationId")]
        [Validation(Required=false)]
        public string ParentOrganizationId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

    }

}
