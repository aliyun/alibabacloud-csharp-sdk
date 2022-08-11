// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UntagResourceRequest : TeaModel {
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        [NameInMap("tagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
