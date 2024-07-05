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
        /// *   Obtain the value of TranscodeTaskId from the response to the [SubmitTranscodeJobs](https://help.aliyun.com/document_detail/68570.html) operation.
        /// *   Obtain the value of TranscodeTaskId from the response to the [ListTranscodeTask](https://help.aliyun.com/document_detail/109120.html) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
