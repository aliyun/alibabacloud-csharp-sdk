// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMeasureDataRequest : TeaModel {
        /// <summary>
        /// The measurement component.
        /// 
        /// *   This parameter is set to Count if the DomainCode parameter is set to DideAlarmPhone or DideAlarmSms. In this case, statistics on the number of phone calls or text messages that are used to send alert notifications are collected.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ComponentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        /// <summary>
        /// The item to be measured. Valid values:
        /// 
        /// *   DideAlarmPhone: phone call-based alerts
        /// *   DideAlarmSms: text message-based alerts
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        /// <summary>
        /// The end timestamp of the measurement period, in milliseconds. The measurement period is calculated in days. You can query only the data within the last 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The start timestamp of the measurement period, in milliseconds. The measurement period is calculated in days. You can query only the data within the last 30 days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
