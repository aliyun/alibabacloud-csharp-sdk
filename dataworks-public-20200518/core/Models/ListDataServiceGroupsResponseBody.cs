// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponseBody : TeaModel {
        [NameInMap("GroupPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceGroupsResponseBodyGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseBodyGroupPagingResult : TeaModel {
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDataServiceGroupsResponseBodyGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseBodyGroupPagingResultGroups : TeaModel {
                [NameInMap("ApiGatewayGroupId")]
                [Validation(Required=false)]
                public string ApiGatewayGroupId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
