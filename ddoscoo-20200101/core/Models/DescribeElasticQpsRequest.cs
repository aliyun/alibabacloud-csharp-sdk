// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// >  This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The sampling interval. Unit: seconds. The value must be a multiple of 60. Default value: 60. Unit: seconds. The query result varies depending on the sampling interval.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The IP address of the Anti-DDoS Proxy instance to query.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The type of the service. Valid values:
        /// 
        /// *   **cn**: Anti-DDoS Proxy (Chinese Mainland)
        /// *   **cn-hongkong**: Anti-DDoS Proxy (Outside Chinese Mainland)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// >  This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
