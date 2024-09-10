// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendRequest : TeaModel {
        /// <summary>
        /// The type of the security data that you want to query. Valid values:
        /// 
        /// *   **HC_NEW**: the number of new baseline risks.
        /// *   **HC_OPERATE**: the number of handled baseline risks.
        /// *   **VUL_NEW**: the number of new vulnerabilities.
        /// *   **VUL_OPERATE**: the number of handled vulnerabilities.
        /// *   **SUSP_NEW**: the number of new alerts.
        /// *   **SUSP_OPERATE**: the number of handled alerts.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizTypes")]
        [Validation(Required=false)]
        public string BizTypes { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// The interval of the data that you want to query. Unit: milliseconds.
        /// 
        /// >  The minimum value is 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
