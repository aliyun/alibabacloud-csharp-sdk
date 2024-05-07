// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class UploadReportRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClientBaseParam")]
        [Validation(Required=false)]
        public string ClientBaseParam { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("DetectProcessId")]
        [Validation(Required=false)]
        public string DetectProcessId { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("FeeId")]
        [Validation(Required=false)]
        public string FeeId { get; set; }

        [NameInMap("MetaUrl")]
        [Validation(Required=false)]
        public string MetaUrl { get; set; }

        [NameInMap("OuterBusinessId")]
        [Validation(Required=false)]
        public string OuterBusinessId { get; set; }

        [NameInMap("RecordAt")]
        [Validation(Required=false)]
        public string RecordAt { get; set; }

        [NameInMap("ResultUrl")]
        [Validation(Required=false)]
        public string ResultUrl { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("RtcRecordId")]
        [Validation(Required=false)]
        public string RtcRecordId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("VideoType")]
        [Validation(Required=false)]
        public string VideoType { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
