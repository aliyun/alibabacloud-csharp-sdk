// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class FileCnt : TeaModel {
        [NameInMap("Large")]
        [Validation(Required=false)]
        public long? Large { get; set; }

        [NameInMap("Middle")]
        [Validation(Required=false)]
        public long? Middle { get; set; }

        [NameInMap("Small")]
        [Validation(Required=false)]
        public long? Small { get; set; }

        [NameInMap("Tiny")]
        [Validation(Required=false)]
        public long? Tiny { get; set; }

    }

}
