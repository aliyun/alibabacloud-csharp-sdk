// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetAppVersionResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

        [NameInMap("AppVersionName")]
        [Validation(Required=false)]
        public string AppVersionName { get; set; }

        [NameInMap("AppVersionStatus")]
        [Validation(Required=false)]
        public string AppVersionStatus { get; set; }

        [NameInMap("AppVersionStatusMemo")]
        [Validation(Required=false)]
        public string AppVersionStatusMemo { get; set; }

        [NameInMap("ConsumeCu")]
        [Validation(Required=false)]
        public double? ConsumeCu { get; set; }

        [NameInMap("FileAddress")]
        [Validation(Required=false)]
        public string FileAddress { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("FileUploadFinishTime")]
        [Validation(Required=false)]
        public string FileUploadFinishTime { get; set; }

        [NameInMap("FileUploadType")]
        [Validation(Required=false)]
        public string FileUploadType { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
