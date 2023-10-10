// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Grace20220606.Models
{
    public class FileInfo : TeaModel {
        [NameInMap("analyzeProgress")]
        [Validation(Required=false)]
        public FileInfoAnalyzeProgress AnalyzeProgress { get; set; }
        public class FileInfoAnalyzeProgress : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("percent")]
            [Validation(Required=false)]
            public double? Percent { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("creationTime")]
        [Validation(Required=false)]
        public long? CreationTime { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("shared")]
        [Validation(Required=false)]
        public bool? Shared { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("transferProgress")]
        [Validation(Required=false)]
        public FileInfoTransferProgress TransferProgress { get; set; }
        public class FileInfoTransferProgress : TeaModel {
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            [NameInMap("transferredSize")]
            [Validation(Required=false)]
            public long? TransferredSize { get; set; }

        }

        [NameInMap("transferState")]
        [Validation(Required=false)]
        public string TransferState { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
