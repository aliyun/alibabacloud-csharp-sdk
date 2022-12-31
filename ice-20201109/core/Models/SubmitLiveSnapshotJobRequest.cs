// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveSnapshotJobRequest : TeaModel {
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestSnapshotOutput SnapshotOutput { get; set; }
        public class SubmitLiveSnapshotJobRequestSnapshotOutput : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveSnapshotJobRequestStreamInput : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
