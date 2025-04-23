// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetExplorerTaskResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public GetExplorerTaskResponseBodyTask Task { get; set; }
        public class GetExplorerTaskResponseBodyTask : TeaModel {
            [NameInMap("autoApply")]
            [Validation(Required=false)]
            public bool? AutoApply { get; set; }

            [NameInMap("autoDestroy")]
            [Validation(Required=false)]
            public bool? AutoDestroy { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("currentJobId")]
            [Validation(Required=false)]
            public string CurrentJobId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("explorerTaskId")]
            [Validation(Required=false)]
            public string ExplorerTaskId { get; set; }

            [NameInMap("initModuleState")]
            [Validation(Required=false)]
            public bool? InitModuleState { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("skipPropertyValidation")]
            [Validation(Required=false)]
            public bool? SkipPropertyValidation { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            [NameInMap("triggerValue")]
            [Validation(Required=false)]
            public string TriggerValue { get; set; }

            [NameInMap("uploadSignature")]
            [Validation(Required=false)]
            public GetExplorerTaskResponseBodyTaskUploadSignature UploadSignature { get; set; }
            public class GetExplorerTaskResponseBodyTaskUploadSignature : TeaModel {
                [NameInMap("accessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
