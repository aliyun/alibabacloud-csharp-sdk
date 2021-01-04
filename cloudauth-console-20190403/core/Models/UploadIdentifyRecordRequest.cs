// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190403.Models
{
    public class UploadIdentifyRecordRequest : TeaModel {
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IdentifyingImageBase64")]
        [Validation(Required=false)]
        public string IdentifyingImageBase64 { get; set; }

        [NameInMap("IdentifyingTime")]
        [Validation(Required=false)]
        public long? IdentifyingTime { get; set; }

        [NameInMap("IdentifyingImageUrl")]
        [Validation(Required=false)]
        public string IdentifyingImageUrl { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("DeviceSecret")]
        [Validation(Required=false)]
        public string DeviceSecret { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

    }

}
