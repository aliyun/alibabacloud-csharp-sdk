// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PutEnvironmentRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Environment Body { get; set; }

        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
