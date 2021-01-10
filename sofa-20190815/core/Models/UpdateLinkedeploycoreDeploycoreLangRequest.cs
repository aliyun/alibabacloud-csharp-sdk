// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkedeploycoreDeploycoreLangRequest : TeaModel {
        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
