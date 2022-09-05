// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetLeadsListPageRequest : TeaModel {
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public long? ComponentId { get; set; }

        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public long? ContentId { get; set; }

        [NameInMap("CreativeId")]
        [Validation(Required=false)]
        public long? CreativeId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("MainId")]
        [Validation(Required=false)]
        public long? MainId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
