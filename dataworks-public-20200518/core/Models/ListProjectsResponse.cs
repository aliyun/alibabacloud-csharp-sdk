// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=true)]
        public ListProjectsResponsePageResult PageResult { get; set; }
        public class ListProjectsResponsePageResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("ProjectList")]
            [Validation(Required=true)]
            public List<ListProjectsResponsePageResultProjectList> ProjectList { get; set; }
            public class ListProjectsResponsePageResultProjectList : TeaModel {
                public string ProjectName { get; set; }
                public string ProjectIdentifier { get; set; }
                public string ProjectDescription { get; set; }
                public int? ProjectStatus { get; set; }
                public long ProjectId { get; set; }
                public string ProjectOwnerBaseId { get; set; }
                public string ProjectStatusCode { get; set; }
            }
        };

    }

}
