// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkedeploycoreDeploycoreProfileRequest : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("ProfileId")]
        [Validation(Required=false)]
        public long? ProfileId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
