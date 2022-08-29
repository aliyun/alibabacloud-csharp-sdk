// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSnapshotJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public GetSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class GetSnapshotJobResponseBodySnapshotJob : TeaModel {
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public GetSnapshotJobResponseBodySnapshotJobInput Input { get; set; }
            public class GetSnapshotJobResponseBodySnapshotJobInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetSnapshotJobResponseBodySnapshotJobInputOssFile OssFile { get; set; }
                public class GetSnapshotJobResponseBodySnapshotJobInputOssFile : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                };

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetSnapshotJobResponseBodySnapshotJobOutput Output { get; set; }
            public class GetSnapshotJobResponseBodySnapshotJobOutput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetSnapshotJobResponseBodySnapshotJobOutputOssFile OssFile { get; set; }
                public class GetSnapshotJobResponseBodySnapshotJobOutputOssFile : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                };

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

    }

}
