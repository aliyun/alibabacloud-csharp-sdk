// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class GetTaskDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public GetTaskDetailResponseBodyResponse Response { get; set; }
        public class GetTaskDetailResponseBodyResponse : TeaModel {
            [NameInMap("DeduplicateProcessInfos")]
            [Validation(Required=false)]
            public List<GetTaskDetailResponseBodyResponseDeduplicateProcessInfos> DeduplicateProcessInfos { get; set; }
            public class GetTaskDetailResponseBodyResponseDeduplicateProcessInfos : TeaModel {
                public bool? Flag { get; set; }
                public int? JsonNum { get; set; }
                public int? ResultNum { get; set; }
                public string VideoName { get; set; }
            }
            [NameInMap("DeduplicateResultOssPath")]
            [Validation(Required=false)]
            public string DeduplicateResultOssPath { get; set; }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }
            [NameInMap("ExceptionMessage")]
            [Validation(Required=false)]
            public string ExceptionMessage { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("ImageCompletedTotal")]
            [Validation(Required=false)]
            public int? ImageCompletedTotal { get; set; }
            [NameInMap("ImageTotal")]
            [Validation(Required=false)]
            public int? ImageTotal { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }
            [NameInMap("MidResultOssPath")]
            [Validation(Required=false)]
            public string MidResultOssPath { get; set; }
            [NameInMap("MqAccessKey")]
            [Validation(Required=false)]
            public string MqAccessKey { get; set; }
            [NameInMap("MqConfigName")]
            [Validation(Required=false)]
            public string MqConfigName { get; set; }
            [NameInMap("MqEndpoint")]
            [Validation(Required=false)]
            public string MqEndpoint { get; set; }
            [NameInMap("MqGroupId")]
            [Validation(Required=false)]
            public string MqGroupId { get; set; }
            [NameInMap("MqTopic")]
            [Validation(Required=false)]
            public string MqTopic { get; set; }
            [NameInMap("OssAccessKeyId")]
            [Validation(Required=false)]
            public string OssAccessKeyId { get; set; }
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }
            [NameInMap("OssConfigName")]
            [Validation(Required=false)]
            public string OssConfigName { get; set; }
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }
            [NameInMap("OssInputPath")]
            [Validation(Required=false)]
            public string OssInputPath { get; set; }
            [NameInMap("OssOutputPath")]
            [Validation(Required=false)]
            public string OssOutputPath { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("TaskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }
            [NameInMap("TaskUid")]
            [Validation(Required=false)]
            public string TaskUid { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
