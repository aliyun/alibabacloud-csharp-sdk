// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ReInitDiskRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("DiskId")]
        [Validation(Required=true)]
        public string DiskId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

    }

}
