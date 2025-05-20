// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class LocalMountSpec : TeaModel {
        [NameInMap("LocalPath")]
        [Validation(Required=false)]
        public string LocalPath { get; set; }

        [NameInMap("MountMode")]
        [Validation(Required=false)]
        public string MountMode { get; set; }

        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

    }

}
