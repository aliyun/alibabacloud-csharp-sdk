// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the transcoding task. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Obtain the value of TranscodeTaskId from the response to the [SubmitTranscodeJobs](~~68570~~) operation.
        /// *   Obtain the value of TranscodeTaskId from the response to the [ListTranscodeTask](~~109120~~) operation.
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
