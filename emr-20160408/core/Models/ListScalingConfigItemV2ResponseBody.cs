// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListScalingConfigItemV2ResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingConfigItemV2ResponseBodyItems Items { get; set; }
        public class ListScalingConfigItemV2ResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingConfigItemV2ResponseBodyItemsItem> Item { get; set; }
            public class ListScalingConfigItemV2ResponseBodyItemsItem : TeaModel {
                public string ConfigItemInformation { get; set; }
                public string ConfigItemType { get; set; }
                public string ScalingConfigItemBizId { get; set; }
                public string ScalingGroupBizId { get; set; }
            }
        };

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
