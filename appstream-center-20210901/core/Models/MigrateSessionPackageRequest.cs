// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class MigrateSessionPackageRequest : TeaModel {
        [NameInMap("DestProjectId")]
        [Validation(Required=false)]
        public string DestProjectId { get; set; }

        [NameInMap("SessionPackageId")]
        [Validation(Required=false)]
        public string SessionPackageId { get; set; }

        [NameInMap("SourceProjectId")]
        [Validation(Required=false)]
        public string SourceProjectId { get; set; }

    }

}
