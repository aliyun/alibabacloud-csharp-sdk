// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class BlockAlarmNotificationRequest : TeaModel {
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

        /// <summary>
        /// The ID of the alert handler.
        /// </summary>
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
        /// The number of seconds that elapse before alert notifications are blocked. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
