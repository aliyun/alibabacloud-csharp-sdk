// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class TimeTriggerConfig : TeaModel {
        /// <summary>
        /// cronExpression
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// enable
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// payload
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

    }

}
