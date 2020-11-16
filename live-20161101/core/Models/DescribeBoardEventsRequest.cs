// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardEventsRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("BoardId")]
        [Validation(Required=true)]
        public string BoardId { get; set; }

    }

}
