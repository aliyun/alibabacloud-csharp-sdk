// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class AppendObjectRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

        [NameInMap("position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

    }

}
