// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class BodyValue : TeaModel {
        [NameInMap("pauseAll")]
        [Validation(Required=false)]
        public bool? PauseAll { get; set; }

        [NameInMap("pauseIndex")]
        [Validation(Required=false)]
        public bool? PauseIndex { get; set; }

        [NameInMap("pauseIndexBatch")]
        [Validation(Required=false)]
        public bool? PauseIndexBatch { get; set; }

        [NameInMap("pauseBiz")]
        [Validation(Required=false)]
        public bool? PauseBiz { get; set; }

        [NameInMap("pauseRuntime")]
        [Validation(Required=false)]
        public bool? PauseRuntime { get; set; }

    }

}
