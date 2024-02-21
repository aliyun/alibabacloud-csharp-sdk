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
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("Cause")]
                [Validation(Required=false)]
                public string Cause { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("ExpectNum")]
                [Validation(Required=false)]
                public int? ExpectNum { get; set; }

                [NameInMap("HostGroupBizId")]
                [Validation(Required=false)]
                public string HostGroupBizId { get; set; }

                [NameInMap("HostGroupName")]
                [Validation(Required=false)]
                public string HostGroupName { get; set; }

                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public string InstanceIds { get; set; }

                [NameInMap("ScalingRuleId")]
                [Validation(Required=false)]
                public string ScalingRuleId { get; set; }

                [NameInMap("ScalingRuleName")]
                [Validation(Required=false)]
                public string ScalingRuleName { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public int? TotalCapacity { get; set; }

                [NameInMap("Transition")]
                [Validation(Required=false)]
                public string Transition { get; set; }

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
