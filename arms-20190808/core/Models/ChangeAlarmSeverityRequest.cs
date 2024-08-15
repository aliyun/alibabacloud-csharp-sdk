// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ChangeAlarmSeverityRequest : TeaModel {
        /// <summary>
        /// The ID of the alert.
        /// 
        /// For more information about how to obtain the ID of an alert, see [ListAlertEvents](https://help.aliyun.com/document_detail/2612346.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public long? AlarmId { get; set; }

        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The severity level of the alert. Valid values: P1, P2, P3, and P4. P4 indicates the lowest severity, whereas P1 indicates the highest severity.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

    }

}
