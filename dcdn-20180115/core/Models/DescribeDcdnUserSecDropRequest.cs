// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropRequest : TeaModel {
        /// <summary>
        /// The date or month that you want to query.
        /// 
        /// *   If data is collected every day, set Data in the format of yyyymmdd, such as 20201203.
        /// *   If data is collected every month, set Data in the format of yyyymm, such as 202012.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The time interval at which data is collected.
        /// 
        /// *   If data is collected every day, the number of blocked packets on the specified day is calculated.
        /// *   If data is collected every month, the number of blocked packets in the specified month is calculated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// The security feature. Valid values:
        /// 
        /// *   waf: WAF
        /// *   tmd: rate limiting
        /// *   robot: bot traffic recognition
        /// *   l4_dm_drop: domain name blocking at Layer 4
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecFunc")]
        [Validation(Required=false)]
        public string SecFunc { get; set; }

    }

}
