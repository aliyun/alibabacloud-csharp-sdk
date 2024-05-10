// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySecurityCheckScheduleConfigRequest : TeaModel {
        /// <summary>
        /// The days on which the automatic configuration check runs. You can specify multiple days. Separate multiple days with commas (,). Valid values:
        /// 
        /// *   **1**: Monday
        /// *   **2**: Tuesday
        /// *   **3**: Wednesday
        /// *   **4**: Thursday
        /// *   **5**: Friday
        /// *   **6**: Saturday
        /// *   **7**: Sunday
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DaysOfWeek")]
        [Validation(Required=false)]
        public string DaysOfWeek { get; set; }

        /// <summary>
        /// The time period during which the automatic configuration check ends. Valid values:
        /// 
        /// *   **0**: 00:00 to 06:00
        /// *   **6**: 06:00 to 12:00
        /// *   **12**: 12:00 to 18:00
        /// *   **18**: 18:00 to 24:00
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The time period during which the automatic configuration check starts. Valid values:
        /// 
        /// *   **0**: 00:00 to 06:00
        /// *   **6**: 06:00 to 12:00
        /// *   **12**: 12:00 to 18:00
        /// *   **18**: 18:00 to 24:00
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
