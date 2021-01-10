// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppservicequeryimportRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
