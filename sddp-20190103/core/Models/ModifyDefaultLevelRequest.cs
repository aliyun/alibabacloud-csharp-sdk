// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDefaultLevelRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("DefaultId")]
        [Validation(Required=false)]
        public long? DefaultId { get; set; }

        [NameInMap("SensitiveIds")]
        [Validation(Required=false)]
        public string SensitiveIds { get; set; }

    }

}
