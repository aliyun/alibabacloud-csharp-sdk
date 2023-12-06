// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class Disk : TeaModel {
        [NameInMap("capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        [NameInMap("fsType")]
        [Validation(Required=false)]
        public string FsType { get; set; }

        [NameInMap("mountPoint")]
        [Validation(Required=false)]
        public string MountPoint { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("remain")]
        [Validation(Required=false)]
        public int? Remain { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
