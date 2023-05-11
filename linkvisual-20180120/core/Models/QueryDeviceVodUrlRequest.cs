// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryDeviceVodUrlRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EnableStun")]
        [Validation(Required=false)]
        public bool? EnableStun { get; set; }

        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public int? EncryptType { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PlayUnLimited")]
        [Validation(Required=false)]
        public bool? PlayUnLimited { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Scheme")]
        [Validation(Required=false)]
        public string Scheme { get; set; }

        [NameInMap("SeekTime")]
        [Validation(Required=false)]
        public int? SeekTime { get; set; }

        [NameInMap("ShouldEncrypt")]
        [Validation(Required=false)]
        public bool? ShouldEncrypt { get; set; }

        [NameInMap("UrlValidDuration")]
        [Validation(Required=false)]
        public int? UrlValidDuration { get; set; }

    }

}
