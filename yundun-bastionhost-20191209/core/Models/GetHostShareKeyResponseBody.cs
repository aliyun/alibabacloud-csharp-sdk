// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostShareKeyResponseBody : TeaModel {
        [NameInMap("HostShareKey")]
        [Validation(Required=false)]
        public GetHostShareKeyResponseBodyHostShareKey HostShareKey { get; set; }
        public class GetHostShareKeyResponseBodyHostShareKey : TeaModel {
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }
            [NameInMap("HostShareKeyName")]
            [Validation(Required=false)]
            public string HostShareKeyName { get; set; }
            [NameInMap("LastModifyKeyAt")]
            [Validation(Required=false)]
            public long? LastModifyKeyAt { get; set; }
            [NameInMap("PrivateKeyFingerPrint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerPrint { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
