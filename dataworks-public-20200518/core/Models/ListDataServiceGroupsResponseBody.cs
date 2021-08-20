// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceGroupsResponseBodyGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseBodyGroupPagingResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDataServiceGroupsResponseBodyGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseBodyGroupPagingResultGroups : TeaModel {
                public string ModifiedTime { get; set; }
                public string Description { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public long? ProjectId { get; set; }
                public string ApiGatewayGroupId { get; set; }
                public string CreatorId { get; set; }
                public string CreatedTime { get; set; }
                public long? TenantId { get; set; }
            }
        };

    }

}
