// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowProjectsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Projects")]
        [Validation(Required=false)]
        public ListFlowProjectsResponseBodyProjects Projects { get; set; }
        public class ListFlowProjectsResponseBodyProjects : TeaModel {
            [NameInMap("Project")]
            [Validation(Required=false)]
            public List<ListFlowProjectsResponseBodyProjectsProject> Project { get; set; }
            public class ListFlowProjectsResponseBodyProjectsProject : TeaModel {
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string UserId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
