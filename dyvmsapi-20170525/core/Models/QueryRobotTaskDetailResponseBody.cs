// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the robocall task, in the JSON format.
        /// 
        /// *   **Id**: the unique ID of the robocall task.
        /// *   **taskName**: the task name.
        /// *   **robotId**: the robot ID.
        /// *   **robotName**: the robot name.
        /// *   **corpName**: the company name.
        /// *   **caller**: the number displayed to the called party.
        /// *   **numberStatusIdent**: indicates whether number status identification was enabled. Valid values: **true** and **false**. The value true indicates that number status identification was enabled. The value false indicates that number status identification was not enabled.
        /// *   **status**: the task state. You can call the [QueryRobotTaskList](~~QueryRobotTaskList~~) operation to obtain the task state from the `status` parameter.
        /// *   **scheduleType**: the scheduling type. Valid values: **SINGLE** and **ORDER**. The value SINGLE indicates that the task was started immediately after it was created. The value ORDER indicates that the task was started at a scheduled time.
        /// *   **retryType**: indicates whether auto-redial was enabled. Valid values: **1** and **0**. The value 1 indicates that auto-redial was enabled. The value 0 indicates that auto-redial was not enabled.
        /// *   **recallStateCodes**: the call state in which redial is required. Valid values: **200010**, **200011**, **200002**, **200012**, and **200005**. The value 200010 indicates that the phone of the called party was powered off. The value 200011 indicates that the number of the called party was out of service. The value 200002 indicates that the line was busy. The value 200012 indicates that the call was lost. The value 200005 indicates that the called party could not be connected.
        /// *   **recallTimes**: the number of redial times.
        /// *   **recallInterval**: the redial interval. Unit: minutes.
        /// *   **createTime**: the time when the task was created, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **fireTime**: the time when the task was started, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **completeTime**: the time when the task was completed, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **filename**: the name of the called number file.
        /// *   **ossFilePath**: the path of the called number file.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
