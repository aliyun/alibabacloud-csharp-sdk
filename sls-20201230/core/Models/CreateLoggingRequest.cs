// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLoggingRequest : TeaModel {
        /// <summary>
        /// The configurations of service logs.
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<CreateLoggingRequestLoggingDetails> LoggingDetails { get; set; }
        public class CreateLoggingRequestLoggingDetails : TeaModel {
            /// <summary>
            /// The name of the Logstore to which service logs of the type are stored.
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
            /// *   scheduledsqlalert: the run logs of Scheduled SQL jobs.
            /// *   etl_alert: the run logs of data transformation jobs.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The name of the project to which service logs are stored.
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
