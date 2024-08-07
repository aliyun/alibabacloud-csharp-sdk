// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetArmsTopNMetricRequest : TeaModel {
        /// <summary>
        /// The SAE application type. Valid values:
        /// 
        /// *   **micro_service**
        /// *   **web**
        /// *   **job**
        /// </summary>
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// The CPU allocation policy. Valid values:
        /// 
        /// *   **request**: CPU cores are allocated only when a request is initiated.
        /// *   **always**: Fixed CPU cores are always allocated.
        /// </summary>
        [NameInMap("CpuStrategy")]
        [Validation(Required=false)]
        public string CpuStrategy { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The number of entries to return. Valid values: 0 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// The field based on which you want to sort the returned entries.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
