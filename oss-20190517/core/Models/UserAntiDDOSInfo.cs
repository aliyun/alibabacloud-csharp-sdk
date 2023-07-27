// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class UserAntiDDOSInfo : TeaModel {
        [NameInMap("ActiveTime")]
        [Validation(Required=false)]
        public long? ActiveTime { get; set; }

        [NameInMap("Ctime")]
        [Validation(Required=false)]
        public long? Ctime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Mtime")]
        [Validation(Required=false)]
        public long? Mtime { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
