// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateDetectProcessRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Draft")]
        [Validation(Required=false)]
        public string Draft { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
