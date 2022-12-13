// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class AddProblemServiceGroupRequest : TeaModel {
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
