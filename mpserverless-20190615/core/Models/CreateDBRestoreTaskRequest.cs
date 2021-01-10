// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class CreateDBRestoreTaskRequest : TeaModel {
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        [NameInMap("OriginCollections")]
        [Validation(Required=false)]
        public string OriginCollections { get; set; }

        [NameInMap("NewCollections")]
        [Validation(Required=false)]
        public string NewCollections { get; set; }

    }

}
