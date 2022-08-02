// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class AccessControlPolicy : TeaModel {
        [NameInMap("AccessControlList")]
        [Validation(Required=false)]
        public AccessControlList AccessControlList { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

    }

}
