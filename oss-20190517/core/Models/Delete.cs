// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class Delete : TeaModel {
        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<ObjectIdentifier> Objects { get; set; }

        [NameInMap("Quiet")]
        [Validation(Required=false)]
        public bool? Quiet { get; set; }

    }

}
