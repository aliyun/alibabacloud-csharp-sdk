// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDownloadUrlResponseBody : TeaModel {
        [NameInMap("cdn_url")]
        [Validation(Required=false)]
        public string CdnUrl { get; set; }

        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("internal_url")]
        [Validation(Required=false)]
        public string InternalUrl { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
