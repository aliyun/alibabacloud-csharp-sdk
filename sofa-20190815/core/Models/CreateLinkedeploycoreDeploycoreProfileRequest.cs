// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkedeploycoreDeploycoreProfileRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
