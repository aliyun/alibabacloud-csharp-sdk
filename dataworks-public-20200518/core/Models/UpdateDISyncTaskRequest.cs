// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDISyncTaskRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=true)]
        public string TaskType { get; set; }

        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        [NameInMap("FileId")]
        [Validation(Required=true)]
        public long? FileId { get; set; }

    }

}
