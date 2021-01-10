// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateVersionPrepublishActiveStatusRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("PrepublishId")]
        [Validation(Required=false)]
        public string PrepublishId { get; set; }

        [NameInMap("IsActive")]
        [Validation(Required=false)]
        public string IsActive { get; set; }

    }

}
