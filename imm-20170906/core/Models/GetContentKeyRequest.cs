// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetContentKeyRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("DRMServerId")]
        [Validation(Required=false)]
        public string DRMServerId { get; set; }

        [NameInMap("KeyIds")]
        [Validation(Required=false)]
        public string KeyIds { get; set; }

    }

}
