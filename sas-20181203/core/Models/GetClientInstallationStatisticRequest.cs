// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientInstallationStatisticRequest : TeaModel {
        /// <summary>
        /// The timestamp that specifies the end of the time range to collect statistics. Unit: millisecond.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// The timestamp that specifies the beginning of the time range to collect statistics. Unit: millisecond.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
