// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResellerUserAlarmThresholdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>quota_low_balance</para>
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
