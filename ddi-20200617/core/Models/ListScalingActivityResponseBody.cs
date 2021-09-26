// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListScalingActivityResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// pageNumber
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// totalCount
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// nextToken
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingActivityResponseBodyItems Items { get; set; }
        public class ListScalingActivityResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingActivityResponseBodyItemsItem> Item { get; set; }
            public class ListScalingActivityResponseBodyItemsItem : TeaModel {
                public string BizId { get; set; }
                public long? StartTime { get; set; }
                public long? EndTime { get; set; }
                public long? ExpectNum { get; set; }
                public string InstanceIds { get; set; }
                public long? TotalCapacity { get; set; }
                public string Cause { get; set; }
                public string Description { get; set; }
                public string Transition { get; set; }
                public string Status { get; set; }
                public string ScalingRuleId { get; set; }
                public string ScalingRuleName { get; set; }
                public string HostGroupBizId { get; set; }
                public string HostGroupName { get; set; }
            }
        };

    }

}
