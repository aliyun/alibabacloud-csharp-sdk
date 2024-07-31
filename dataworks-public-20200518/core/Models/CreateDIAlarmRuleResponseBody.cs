// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIAlarmRuleResponseBody : TeaModel {
        /// <summary>
        /// The alert rule ID.
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
