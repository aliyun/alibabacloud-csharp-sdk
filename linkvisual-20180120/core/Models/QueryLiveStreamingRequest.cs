// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryLiveStreamingRequest : TeaModel {
        [NameInMap("CacheDuration")]
        [Validation(Required=false)]
        public int? CacheDuration { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EnableStun")]
        [Validation(Required=false)]
        public bool? EnableStun { get; set; }

        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public int? EncryptType { get; set; }

        [NameInMap("ForceIFrame")]
        [Validation(Required=false)]
        public bool? ForceIFrame { get; set; }

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

        [NameInMap("ShouldEncrypt")]
        [Validation(Required=false)]
        public bool? ShouldEncrypt { get; set; }

        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

        [NameInMap("UrlValidDuration")]
        [Validation(Required=false)]
        public int? UrlValidDuration { get; set; }

    }

}
