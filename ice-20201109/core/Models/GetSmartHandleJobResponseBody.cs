// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSmartHandleJobResponseBody : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public GetSmartHandleJobResponseBodyJobResult JobResult { get; set; }
        public class GetSmartHandleJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// 智能分析结果
            /// </summary>
            [NameInMap("AiResult")]
            [Validation(Required=false)]
            public string AiResult { get; set; }

            /// <summary>
            /// 媒资Id
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

            /// <summary>
            /// userid。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
