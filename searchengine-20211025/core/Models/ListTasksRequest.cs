// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTasksRequest : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
