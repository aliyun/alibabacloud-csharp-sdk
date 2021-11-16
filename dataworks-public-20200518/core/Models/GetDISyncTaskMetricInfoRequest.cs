// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskMetricInfoRequest : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
