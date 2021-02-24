// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class InitTenantRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public InitTenantRequestRequest Request { get; set; }
        public class InitTenantRequestRequest : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
        };

    }

}
