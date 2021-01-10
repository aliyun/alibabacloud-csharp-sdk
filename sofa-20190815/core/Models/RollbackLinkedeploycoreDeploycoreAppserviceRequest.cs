// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RollbackLinkedeploycoreDeploycoreAppserviceRequest : TeaModel {
        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
