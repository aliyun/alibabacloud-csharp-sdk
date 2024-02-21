// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListScalingGroupV2ResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingGroupV2ResponseBodyItems Items { get; set; }
        public class ListScalingGroupV2ResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingGroupV2ResponseBodyItemsItem> Item { get; set; }
            public class ListScalingGroupV2ResponseBodyItemsItem : TeaModel {
                [NameInMap("ActiveStatus")]
                [Validation(Required=false)]
                public string ActiveStatus { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HostGroupBizId")]
                [Validation(Required=false)]
                public string HostGroupBizId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                [NameInMap("ScalingInMode")]
                [Validation(Required=false)]
                public string ScalingInMode { get; set; }

                [NameInMap("ScalingMaxSize")]
                [Validation(Required=false)]
                public int? ScalingMaxSize { get; set; }

                [NameInMap("ScalingMinSize")]
                [Validation(Required=false)]
                public int? ScalingMinSize { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
