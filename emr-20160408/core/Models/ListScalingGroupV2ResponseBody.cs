// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListScalingGroupV2ResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingGroupV2ResponseBodyItems Items { get; set; }
        public class ListScalingGroupV2ResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingGroupV2ResponseBodyItemsItem> Item { get; set; }
            public class ListScalingGroupV2ResponseBodyItemsItem : TeaModel {
                public string Description { get; set; }
                public string ScalingInMode { get; set; }
                public int? ScalingMaxSize { get; set; }
                public string Name { get; set; }
                public string HostGroupBizId { get; set; }
                public int? ScalingMinSize { get; set; }
                public string ActiveStatus { get; set; }
                public string ScalingGroupId { get; set; }
            }
        };

    }

}
