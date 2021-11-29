// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListScalingActivityV2ResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListScalingActivityV2ResponseBodyItems Items { get; set; }
        public class ListScalingActivityV2ResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListScalingActivityV2ResponseBodyItemsItem> Item { get; set; }
            public class ListScalingActivityV2ResponseBodyItemsItem : TeaModel {
                public string BizId { get; set; }
                public string Cause { get; set; }
                public string Description { get; set; }
                public long? EndTime { get; set; }
                public int? ExpectNum { get; set; }
                public string HostGroupBizId { get; set; }
                public string HostGroupName { get; set; }
                public string InstanceIds { get; set; }
                public string ScalingRuleId { get; set; }
                public string ScalingRuleName { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public int? TotalCapacity { get; set; }
                public string Transition { get; set; }
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
