// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingJobResponseBody : TeaModel {
        [NameInMap("LiveEditingJob")]
        [Validation(Required=false)]
        public GetLiveEditingJobResponseBodyLiveEditingJob LiveEditingJob { get; set; }
        public class GetLiveEditingJobResponseBodyLiveEditingJob : TeaModel {
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public string Clips { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("LiveStreamConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig LiveStreamConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
            [NameInMap("MediaProduceConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig MediaProduceConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig : TeaModel {
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("OutputMediaConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig OutputMediaConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig : TeaModel {
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public long? Bitrate { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                [NameInMap("VodTemplateGroupId")]
                [Validation(Required=false)]
                public string VodTemplateGroupId { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
