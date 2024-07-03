// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScheduledTasksRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the scaling group to which the scheduled task belongs.
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
        /// The ID of the scaling group to which the scheduled task belongs.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The scaling rules of the scheduled tasks. Once the scheduled tasks are triggered, the scaling rules are executed.
        /// </summary>
        [NameInMap("ScheduledActions")]
        [Validation(Required=false)]
        public List<string> ScheduledActions { get; set; }

        /// <summary>
        /// The IDs of the scheduled tasks that you want to query.
        /// </summary>
        [NameInMap("ScheduledTaskIds")]
        [Validation(Required=false)]
        public List<string> ScheduledTaskIds { get; set; }

        /// <summary>
        /// The names of the scheduled tasks that you want to query.
        /// </summary>
        [NameInMap("ScheduledTaskNames")]
        [Validation(Required=false)]
        public List<string> ScheduledTaskNames { get; set; }

    }

}
