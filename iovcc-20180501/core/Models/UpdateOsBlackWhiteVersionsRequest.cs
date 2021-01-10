// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateOsBlackWhiteVersionsRequest : TeaModel {
        [NameInMap("WhiteVersions")]
        [Validation(Required=false)]
        public string WhiteVersions { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("BlackVersions")]
        [Validation(Required=false)]
        public string BlackVersions { get; set; }

    }

}
