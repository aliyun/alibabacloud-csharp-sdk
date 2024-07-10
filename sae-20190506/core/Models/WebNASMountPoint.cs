// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebNASMountPoint : TeaModel {
        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("NasAddr")]
        [Validation(Required=false)]
        public string NasAddr { get; set; }

        [NameInMap("NasPath")]
        [Validation(Required=false)]
        public string NasPath { get; set; }

    }

}
