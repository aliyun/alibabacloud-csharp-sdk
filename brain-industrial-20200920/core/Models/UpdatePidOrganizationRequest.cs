// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class UpdatePidOrganizationRequest : TeaModel {
        [NameInMap("OrganizationId")]
        [Validation(Required=true)]
        public string OrganizationId { get; set; }

        [NameInMap("OrganizationName")]
        [Validation(Required=true)]
        public string OrganizationName { get; set; }

    }

}
