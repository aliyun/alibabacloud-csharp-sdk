// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExecuteChangeRequestReleaseStageRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
