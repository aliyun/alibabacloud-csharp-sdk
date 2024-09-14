// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetImageResponseBody : TeaModel {
        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetImageResponseBodyImage Image { get; set; }
        public class GetImageResponseBodyImage : TeaModel {
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("CopyTime")]
            [Validation(Required=false)]
            public long? CopyTime { get; set; }

            [NameInMap("ExportTime")]
            [Validation(Required=false)]
            public long? ExportTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SourceBackupUid")]
            [Validation(Required=false)]
            public string SourceBackupUid { get; set; }

            [NameInMap("SourceImageUid")]
            [Validation(Required=false)]
            public string SourceImageUid { get; set; }

            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VsmDigest")]
            [Validation(Required=false)]
            public string VsmDigest { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
