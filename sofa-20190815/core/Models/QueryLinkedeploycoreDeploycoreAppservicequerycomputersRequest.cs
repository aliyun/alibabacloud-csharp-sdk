// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppservicequerycomputersRequest : TeaModel {
        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
