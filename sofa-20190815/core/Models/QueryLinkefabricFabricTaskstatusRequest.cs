// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricTaskstatusRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("CommonState")]
        [Validation(Required=false)]
        public string CommonState { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DevStage")]
        [Validation(Required=false)]
        public string DevStage { get; set; }

        [NameInMap("OriginAppName")]
        [Validation(Required=false)]
        public string OriginAppName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        [NameInMap("SubTaskType")]
        [Validation(Required=false)]
        public string SubTaskType { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("UtcCreate")]
        [Validation(Required=false)]
        public string UtcCreate { get; set; }

        [NameInMap("UtcModified")]
        [Validation(Required=false)]
        public string UtcModified { get; set; }

    }

}
