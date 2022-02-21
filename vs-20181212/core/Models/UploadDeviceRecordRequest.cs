// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadDeviceRecordRequest : TeaModel {
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SearchCriteria")]
        [Validation(Required=false)]
        public string SearchCriteria { get; set; }

        [NameInMap("StreamId")]
        [Validation(Required=false)]
        public string StreamId { get; set; }

        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        [NameInMap("UploadMode")]
        [Validation(Required=false)]
        public string UploadMode { get; set; }

        [NameInMap("UploadParams")]
        [Validation(Required=false)]
        public string UploadParams { get; set; }

        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
