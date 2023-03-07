// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserAlarmThresholdRequest : TeaModel {
        /// <summary>
        /// The alert rules corresponding to the specified alert type. If you leave this parameter empty, no alert threshold exists.
        /// </summary>
        [NameInMap("AlarmThresholds")]
        [Validation(Required=false)]
        public string AlarmThresholds { get; set; }

        /// <summary>
        /// The type of the alert. Set the value to `quota_low_balance`.
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
