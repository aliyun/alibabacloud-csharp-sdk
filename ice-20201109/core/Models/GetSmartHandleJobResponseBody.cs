// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSmartHandleJobResponseBody : TeaModel {
        /// <summary>
        /// 任务Id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务结果
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 智能任务信息
        /// </summary>
        [NameInMap("SmartJobInfo")]
        [Validation(Required=false)]
        public GetSmartHandleJobResponseBodySmartJobInfo SmartJobInfo { get; set; }
        public class GetSmartHandleJobResponseBodySmartJobInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public GetSmartHandleJobResponseBodySmartJobInfoInputConfig InputConfig { get; set; }
            public class GetSmartHandleJobResponseBodySmartJobInfoInputConfig : TeaModel {
                /// <summary>
                /// OSS地址 或 内容库素材ID
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }

            }
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public GetSmartHandleJobResponseBodySmartJobInfoOutputConfig OutputConfig { get; set; }
            public class GetSmartHandleJobResponseBodySmartJobInfoOutputConfig : TeaModel {
                /// <summary>
                /// OSS Bucket
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// OSS Object
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// 用户自定义信息
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
