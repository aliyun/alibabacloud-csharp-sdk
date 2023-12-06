// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListWorkflowTaskLogsRequest : TeaModel {
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<string> FilterValues { get; set; }

        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("workflowType")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

        [NameInMap("xuid")]
        [Validation(Required=false)]
        public string Xuid { get; set; }

    }

}
