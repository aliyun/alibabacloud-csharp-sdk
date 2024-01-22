// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class NASConfig : TeaModel {
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<NASMountConfig> MountPoints { get; set; }

    }

}
