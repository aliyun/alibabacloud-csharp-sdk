// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetPropertyScheduleConfigResponseBody : TeaModel {
        /// <summary>
        /// The configurations for the collection frequency of asset fingerprints.
        /// </summary>
        [NameInMap("PropertyScheduleConfig")]
        [Validation(Required=false)]
        public GetPropertyScheduleConfigResponseBodyPropertyScheduleConfig PropertyScheduleConfig { get; set; }
        public class GetPropertyScheduleConfigResponseBodyPropertyScheduleConfig : TeaModel {
            /// <summary>
            /// The timestamp when the next collection of asset fingerprints starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("NextScheduleTime")]
            [Validation(Required=false)]
            public long? NextScheduleTime { get; set; }

            /// <summary>
            /// The collection frequency of asset fingerprints. Valid values:
            /// 
            /// *   **0**: disabled, which indicates that the asset fingerprints are not automatically or periodically collected.
            /// *   **1**: collects asset fingerprints once an hour.
            /// *   **3**: collects asset fingerprints once every 3 hours.
            /// *   **12**: collects asset fingerprints once every 12 hours.
            /// *   **24**: collects asset fingerprints once a day.
            /// *   **168**: collects asset fingerprints once every 7 days.
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// The type of the asset fingerprints. Valid values:
            /// 
            /// *   **scheduler_port_period**: listening port
            /// *   **scheduler_process_period**: running process
            /// *   **scheduler_account_period**: account
            /// *   **scheduler_software_period**: software
            /// *   **scheduler_cron_period**: scheduled task
            /// *   **scheduler_sca_period**: middleware
            /// *   **scheduler_autorun_period**: startup item
            /// *   **scheduler_lkm_period**: kernel module
            /// *   **scheduler_sca_proxy_period**: website
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
