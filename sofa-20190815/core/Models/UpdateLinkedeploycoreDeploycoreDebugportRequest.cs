// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkedeploycoreDeploycoreDebugportRequest : TeaModel {
        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("DebugPort")]
        [Validation(Required=false)]
        public string DebugPort { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
