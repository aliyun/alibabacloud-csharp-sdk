// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDSTMiddlewareInstanceRequest : TeaModel {
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("Testf")]
        [Validation(Required=false)]
        public string Testf { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
