// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class CreateDBImportTaskRequest : TeaModel {
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
