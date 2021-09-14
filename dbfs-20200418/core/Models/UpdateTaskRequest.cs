// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class UpdateTaskRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

        [NameInMap("TaskProgress")]
        [Validation(Required=false)]
        public int? TaskProgress { get; set; }

    }

}
