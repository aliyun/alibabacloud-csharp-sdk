// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Format: yyyy-MM-dd or yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [NameInMap("ExpiredEndTime")]
        [Validation(Required=false)]
        public string ExpiredEndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Format: yyyy-MM-dd or yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [NameInMap("ExpiredStartTime")]
        [Validation(Required=false)]
        public string ExpiredStartTime { get; set; }

    }

}
