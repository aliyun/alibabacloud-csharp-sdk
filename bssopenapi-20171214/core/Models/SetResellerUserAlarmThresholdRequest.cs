// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserAlarmThresholdRequest : TeaModel {
        [NameInMap("AlarmThresholds")]
        [Validation(Required=false)]
        public string AlarmThresholds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
