// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPropertyScheduleConfigRequest : TeaModel {
        /// <summary>
        /// The new collection frequency of asset fingerprints. Valid values:
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
        /// The type of the asset fingerprints for which you want to modify the collection frequency. Valid values:
        /// 
        /// *   **scheduler\_port_period**: listening port
        /// *   **scheduler\_process_period**: running process
        /// *   **scheduler\_account_period**: account
        /// *   **scheduler\_software_period**: software
        /// *   **scheduler\_cron_period**: scheduled task
        /// *   **scheduler\_sca_period**: middleware, database, or web service
        /// *   **scheduler\_autorun_period**: startup item
        /// *   **scheduler\_lkm_period**: kernel module
        /// *   **scheduler\_sca\_proxy_period**: website
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
