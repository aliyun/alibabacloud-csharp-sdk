// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIJobResponseBody : TeaModel {
        /// <summary>
        /// The list of job IDs. You can obtain the job ID from the PlayInfo parameter in the response to the [GetPlayInfo](~~56124~~) operation.
        /// 
        /// >  You can specify a maximum of 10 job IDs in a request. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class ListAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<ListAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class ListAIJobResponseBodyAIJobListAIJob : TeaModel {
                /// <summary>
                /// Queries AI jobs. After a job is submitted, ApsaraVideo VOD asynchronously processes the job. You can call this operation to query the job information in real time.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// The status of the job. Valid values:
                /// 
                /// *   **success**: The job is complete.
                /// *   **fail**: The job failed.
                /// *   **init**: The job is being initialized.
                /// *   **Processing**: The job is in progress.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// {"OrigASRData":{"AsrTextList":\[{"EndTime":700,"StartTime":0,"Text":"Yes.","ChannelId":0,"SpeechRate":85},{"EndTime":3750,"StartTime":1630,"Text":"No.","ChannelId":0,"SpeechRate":28},{"EndTime":5910,"StartTime":4020,"Text":"Of course.","ChannelId":0,"SpeechRate":95},{"EndTime":12750,"StartTime":10090,"Text":"Message.","ChannelId":0,"SpeechRate":45},{"EndTime":25230,"StartTime":13590,"Text":"Hello, good afternoon.","ChannelId":0,"SpeechRate":20},{"EndTime":30000,"StartTime":28220,"Text":"Yes.","ChannelId":0,"SpeechRate":33}],"Duration":"30016"}}
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// The ID of the video.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The error message. This parameter is returned if the value of Status is fail.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The returned data. The value is a JSON string.
                /// 
                /// For more information, see [AITemplateConfig](~~89863~~).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The error code. This parameter is returned if the value of Status is fail.
        /// </summary>
        [NameInMap("NonExistAIJobIds")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyNonExistAIJobIds NonExistAIJobIds { get; set; }
        public class ListAIJobResponseBodyNonExistAIJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
