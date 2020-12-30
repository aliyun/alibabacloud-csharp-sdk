// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowProjectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Projects")]
        [Validation(Required=false)]
        public ListFlowProjectResponseBodyProjects Projects { get; set; }
        public class ListFlowProjectResponseBodyProjects : TeaModel {
            [NameInMap("Project")]
            [Validation(Required=false)]
            public List<ListFlowProjectResponseBodyProjectsProject> Project { get; set; }
            public class ListFlowProjectResponseBodyProjectsProject : TeaModel {
                public string Description { get; set; }
                public string UserId { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
