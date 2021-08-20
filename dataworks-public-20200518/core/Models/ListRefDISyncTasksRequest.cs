// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("DatasourceName")]
        [Validation(Required=true)]
        public string DatasourceName { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=true)]
        public string TaskType { get; set; }

        [NameInMap("RefType")]
        [Validation(Required=true)]
        public string RefType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
