// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListScalingConfigItemResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingConfigItemResponseBodyItems Items { get; set; }
        public class ListScalingConfigItemResponseBodyItems : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListScalingConfigItemResponseBodyItemsItems> Items { get; set; }
            public class ListScalingConfigItemResponseBodyItemsItems : TeaModel {
                public string ConfigItemType { get; set; }
                public string ScalingGroupBizId { get; set; }
                public string ScalingConfigItemBizId { get; set; }
                public string ConfigItemInformation { get; set; }
            }
        };

    }

}
