// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCronClearConfigResponseBody : TeaModel {
        /// <summary>
        /// Data configuration.
        /// </summary>
        [NameInMap("DataCronClearConfig")]
        [Validation(Required=false)]
        public GetDataCronClearConfigResponseBodyDataCronClearConfig DataCronClearConfig { get; set; }
        public class GetDataCronClearConfigResponseBodyDataCronClearConfig : TeaModel {
            /// <summary>
            /// The number of times that the task is run.
            /// </summary>
            [NameInMap("CronCallTimes")]
            [Validation(Required=false)]
            public string CronCallTimes { get; set; }

            /// <summary>
            /// The crontab expression that you can use to run the task at a specified time. For more information, see [Crontab expression](~~206581~~).
            /// </summary>
            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            /// <summary>
            /// The time when the task was last run.
            /// </summary>
            [NameInMap("CronLastCallStartTime")]
            [Validation(Required=false)]
            public string CronLastCallStartTime { get; set; }

            /// <summary>
            /// The time when the task is run next time. This parameter is displayed only when the status of the scheduled task is SUCCESS.
            /// </summary>
            [NameInMap("CronNextCallTime")]
            [Validation(Required=false)]
            public string CronNextCallTime { get; set; }

            /// <summary>
            /// The status of the scheduled task. If this parameter is empty, it indicates the task is not run. Valid values:
            /// 
            /// *   PAUSE: The task is suspended.
            /// *   WAITING: The task is waiting to be run.
            /// *   SUCCESS: The task is complete.
            /// </summary>
            [NameInMap("CronStatus")]
            [Validation(Required=false)]
            public string CronStatus { get; set; }

            /// <summary>
            /// The number of times that the Optimize Table statement is automatically exeuted. This parameter is valid only when the value of the OptimizeTableAfterEveryClearTimes parameter is greater than 0.
            /// </summary>
            [NameInMap("CurrentClearTaskCount")]
            [Validation(Required=false)]
            public long? CurrentClearTaskCount { get; set; }

            /// <summary>
            /// The execution duration of the task. Unit: hours. If the value is 0, it indicates the duration is not specified.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// Specifies whether to enable automatic execution of the OPTIMIZE TABLE statement. Valid values:
            /// 
            /// *   0: disables automatic execution
            /// *   A number greater than 0: enables automatic execution. The number specifies the number of times that cleanup operations must be performed before the OPTIMIZE TABLE statement is automatically executed.
            /// </summary>
            [NameInMap("OptimizeTableAfterEveryClearTimes")]
            [Validation(Required=false)]
            public long? OptimizeTableAfterEveryClearTimes { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
