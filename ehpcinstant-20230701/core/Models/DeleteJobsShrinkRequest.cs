// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DeleteJobsShrinkRequest : TeaModel {
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public string ExecutorIdsShrink { get; set; }

        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpecShrink { get; set; }

    }

}
