// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktTagRequest : TeaModel {
        [NameInMap("CheckDuplicate")]
        [Validation(Required=false)]
        public string CheckDuplicate { get; set; }

        [NameInMap("Color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

    }

}
