// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssUsageDataRequest : TeaModel {
        /// <summary>
        /// The name of the logical Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The end of the time range to query. The time is in UTC. Format: 2010-01-21T09:50:23Z.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The aggregation granularity. Unit: minutes.
        /// 
        /// Default value: 5. Valid values: 5 to 1440.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The time is in UTC. Format: 2010-01-21T09:50:23Z.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
