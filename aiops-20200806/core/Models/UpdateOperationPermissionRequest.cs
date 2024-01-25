// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateOperationPermissionRequest : TeaModel {
        [NameInMap("PermissionType")]
        [Validation(Required=false)]
        public int? PermissionType { get; set; }

        [NameInMap("SwitchFrontOperaUid")]
        [Validation(Required=false)]
        public string SwitchFrontOperaUid { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
