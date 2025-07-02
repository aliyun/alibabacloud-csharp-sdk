// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ChangeResourceGroupOutput : TeaModel {
        [NameInMap("newResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        [NameInMap("oldResourceGroupId")]
        [Validation(Required=false)]
        public string OldResourceGroupId { get; set; }

        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
