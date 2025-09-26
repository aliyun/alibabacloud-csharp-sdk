// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListToolsOutput : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ToolListItem> Data { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
