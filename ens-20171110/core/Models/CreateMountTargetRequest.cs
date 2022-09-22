// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateMountTargetRequest : TeaModel {
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("MountTargetName")]
        [Validation(Required=false)]
        public string MountTargetName { get; set; }

        [NameInMap("NetWorkId")]
        [Validation(Required=false)]
        public string NetWorkId { get; set; }

    }

}
