// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class ListWorkflowInstancesRequest : TeaModel {
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
