// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAuditProjectResponseBody : TeaModel {
        [NameInMap("audit_enabled")]
        [Validation(Required=false)]
        public bool? AuditEnabled { get; set; }

        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}
