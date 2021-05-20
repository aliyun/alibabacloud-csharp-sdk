// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("GroupPagingResult")]
        [Validation(Required=true)]
        public ListDataServiceGroupsResponseGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseGroupPagingResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("Groups")]
            [Validation(Required=true)]
            public List<ListDataServiceGroupsResponseGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseGroupPagingResultGroups : TeaModel {
                public long? TenantId { get; set; }
                public string GroupId { get; set; }
                public string ApiGatewayGroupId { get; set; }
                public string GroupName { get; set; }
                public string Description { get; set; }
                public string CreatedTime { get; set; }
                public string ModifiedTime { get; set; }
                public string CreatorId { get; set; }
                public long? ProjectId { get; set; }
            }
        };

    }

}
