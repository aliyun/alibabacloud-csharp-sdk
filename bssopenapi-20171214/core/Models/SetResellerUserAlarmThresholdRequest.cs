// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserAlarmThresholdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;denominator\&quot;:100,\&quot;numerator\&quot;:30,\&quot;thresholdType\&quot;:1}]</para>
        /// </summary>
        [NameInMap("AlarmThresholds")]
        [Validation(Required=false)]
        public string AlarmThresholds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_low_balance</para>
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
