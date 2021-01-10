// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class MoveWebHostingFileRequest : TeaModel {
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("SourceFilePath")]
        [Validation(Required=false)]
        public string SourceFilePath { get; set; }

        [NameInMap("TargetFilePath")]
        [Validation(Required=false)]
        public string TargetFilePath { get; set; }

    }

}
