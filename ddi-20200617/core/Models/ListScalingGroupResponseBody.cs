// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListScalingGroupResponseBody : TeaModel {
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
        public ListScalingGroupResponseBodyItems Items { get; set; }
        public class ListScalingGroupResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingGroupResponseBodyItemsItem> Item { get; set; }
            public class ListScalingGroupResponseBodyItemsItem : TeaModel {
                public string ScalingGroupId { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string ActiveStatus { get; set; }
                public string HostGroupBizId { get; set; }
                public string ScalingInMode { get; set; }
                public string ScalingMinSize { get; set; }
                public string ScalingMaxSize { get; set; }
            }
        };

    }

}
