// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// > The time must be in the latest 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The operation object that you want to query.
        /// </summary>
        [NameInMap("EntityObject")]
        [Validation(Required=false)]
        public string EntityObject { get; set; }

        /// <summary>
        /// The type of the operation object that you want to query. Valid values:
        /// 
        /// *   **1**: the IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance
        /// *   **2**: Anti-DDoS plans
        /// *   **3**: ECS instances
        /// *   **4**: all logs
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public int? EntityType { get; set; }

        /// <summary>
        /// The number of the page to return. For example, to query the returned results on the first page, set the value to **1**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// > The time must be in the latest 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
