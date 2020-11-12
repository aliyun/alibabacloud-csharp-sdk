// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("ResourceGroups")]
        [Validation(Required=true)]
        public ListResourceGroupsResponseResourceGroups ResourceGroups { get; set; }
        public class ListResourceGroupsResponseResourceGroups : TeaModel {
            [NameInMap("ResourceGroup")]
            [Validation(Required=true)]
            public List<ListResourceGroupsResponseResourceGroupsResourceGroup> ResourceGroup { get; set; }
            public class ListResourceGroupsResponseResourceGroupsResourceGroup : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public string DisplayName { get; set; }
                public string Status { get; set; }
                public string CreateDate { get; set; }
                public string AccountId { get; set; }
            }
        };

    }

}
