// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultRequest : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("RequestIds")]
        [Validation(Required=false)]
        public string RequestIds { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
