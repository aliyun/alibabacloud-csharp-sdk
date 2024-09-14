// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivitiesRequest : TeaModel {
        [NameInMap("InstanceRefreshTaskId")]
        [Validation(Required=false)]
        public string InstanceRefreshTaskId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the scaling group to which the scaling activity that you want to query belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of the scaling activities that you want to query.
        /// 
        /// > When you call this operation, you must specify one of the `ScalingGroupId` and `ScalingActivityId.N` parameters. Otherwise, an error is reported.
        /// </summary>
        [NameInMap("ScalingActivityIds")]
        [Validation(Required=false)]
        public List<string> ScalingActivityIds { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// > When you call this operation, you must specify one of the `ScalingGroupId` and `ScalingActivityId.N` parameters. Otherwise, an error is reported.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The status of the scaling activity. Valid values:
        /// 
        /// *   Successful: The scaling activity is successful.
        /// *   Warning: The scaling activity is partially successful.
        /// *   Failed: The scaling activity failed.
        /// *   InProgress: The scaling activity is in progress.
        /// *   Rejected: The request to trigger the scaling activity is rejected.
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

    }

}
