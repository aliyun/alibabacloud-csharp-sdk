// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostShareKeysResponseBody : TeaModel {
        [NameInMap("HostShareKeys")]
        [Validation(Required=false)]
        public List<ListHostShareKeysResponseBodyHostShareKeys> HostShareKeys { get; set; }
        public class ListHostShareKeysResponseBodyHostShareKeys : TeaModel {
            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public long? HostAccountCount { get; set; }

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

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
