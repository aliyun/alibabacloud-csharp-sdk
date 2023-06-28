// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UntagResourceRequest : TeaModel {
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("tagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
