// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallDetailByTaskIdResponseBody : TeaModel {
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
        /// The call details of the outbound robocall task, in the JSON format.
        /// 
        /// *   **startDate**: the time when the call was answered.
        /// 
        /// *   **stateDesc**: the reason why the call was hung up. If the status code of early media was returned, this parameter indicates the reason why the status code of early media was used.
        /// 
        /// *   **statusCode**: the status code.
        /// 
        /// *   **EndDate**: the time when the call was ended.
        /// 
        /// *   **calleeShowNumber**: the calling number displayed to the called party.
        /// 
        /// *   **callee**: the called number.
        /// 
        /// *   **duration**: the billing duration.
        /// 
        /// *   **gmtCreate**: the time when the outbound robocall task was created.
        /// 
        /// *   **hangupDirection**: the party who hung up.
        /// 
        /// *   **tags**: the call tags.
        /// 
        /// *   **dialogCount**: the number of conversation rounds in the call.
        /// 
        /// *   **sureCount**: the number of times that the robocall task was acknowledged.
        /// 
        /// *   **denyCount**: the number of times that the robocall task was denied.
        /// 
        /// *   **rejectCount**: the number of times that the robocall task was rejected.
        /// 
        /// *   **customCount**: the number of times that the robocall task was customized.
        /// 
        /// *   **knowledgeCount**: the number of times that the knowledge base was queried.
        /// 
        /// *   **recordFile**: the download URL of the recording file. The URL is valid only for 48 hours. The recording file must be downloaded in time.
        /// 
        /// *   **callId**: the call ID.
        /// 
        /// *   **recordStatus**: indicates whether a recording file was available. Valid values:
        /// 
        ///     *   1: A recording file was available.
        ///     *   2: No recording file was available.
        /// 
        /// *   **knowledgeCommonCount**: the number of call failures caused by the common issues in the knowledge base.
        /// 
        /// *   **knowledgeBusinessCount**: the number of call failures caused by the business issues in the knowledge base.
        /// 
        /// *   **callee**: the called number.
        /// 
        /// *   **dialogDetail**: the conversation details. The value is a JSON array that contains the following parameters:
        /// 
        ///     *   **role**: the role who spoke.
        ///     *   **content**: the content of the speech.
        ///     *   **time**: the start time of the speech.
        /// 
        /// > The preceding parameters are for reference only. The actually returned parameters prevail.
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
