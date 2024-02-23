// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotInfoListResponseBody : TeaModel {
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
        /// The basic information about the robot, in the JSON format. The basic information contains the following parameters:
        /// 
        /// *   **id**: the robot ID.
        /// *   **robotName**: the robot name.
        /// *   **robotType**: the robot type.
        /// *   **auditStatus**: the review state.
        /// *   **gmtCreate**: the time when the task was created.
        /// *   **gmtModified**: the time when the task was modified.
        /// *   **partnerId**: the partner ID.
        /// *   **asrId**: the ID of the automatic speech recognition (ASR) model.
        /// *   **asrType**: the ASR type. Valid values: **Public** and **Private**.
        /// *   **remark**: the additional information.
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
