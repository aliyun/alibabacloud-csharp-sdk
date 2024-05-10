// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLoggingRequest : TeaModel {
        /// <summary>
        /// The configurations of service logs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<UpdateLoggingRequestLoggingDetails> LoggingDetails { get; set; }
        public class UpdateLoggingRequestLoggingDetails : TeaModel {
            /// <summary>
            /// The name of the Logstore to which you want to save service logs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// The type of service logs. Valid values:
            /// 
            /// *   consumergroup_log: the consumption delay logs of consumer groups.
            /// *   logtail_alarm: the alert logs of Logtail.
            /// *   operation_log: the operation logs.
            /// *   logtail_profile: the collection logs of Logtail.
            /// *   metering: the metering logs.
            /// *   logtail_status: the status logs of Logtail.
            /// *   scheduledsqlalert: the operational logs of Scheduled SQL jobs.
            /// *   etl_alert: the operational logs of data transformation jobs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The name of the project to which you want to save service logs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
