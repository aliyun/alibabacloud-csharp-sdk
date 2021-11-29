// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListScalingActivityV2Request : TeaModel {
        [NameInMap("ClusterBizId")]
        [Validation(Required=false)]
        public string ClusterBizId { get; set; }

        [NameInMap("CurrentSize")]
        [Validation(Required=false)]
        public int? CurrentSize { get; set; }

        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        [NameInMap("OrderMode")]
        [Validation(Required=false)]
        public string OrderMode { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScalingGroupBizId")]
        [Validation(Required=false)]
        public string ScalingGroupBizId { get; set; }

        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
