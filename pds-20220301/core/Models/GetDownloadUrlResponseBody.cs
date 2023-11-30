// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// The download URL of a file that is downloaded by using Alibaba Cloud CDN.
        /// </summary>
        [NameInMap("cdn_url")]
        [Validation(Required=false)]
        public string CdnUrl { get; set; }

        /// <summary>
        /// The hash value of the file content.
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// The name of the algorithm that is used to calculate the hash value of the file content.
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// The hash value calculated by using 64-bit cyclic redundancy check (CRC-64).
        /// </summary>
        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        /// <summary>
        /// The time when the download URL expires.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The download URL of a file that is downloaded over a virtual private cloud (VPC).
        /// </summary>
        [NameInMap("internal_url")]
        [Validation(Required=false)]
        public string InternalUrl { get; set; }

        /// <summary>
        /// The size of the file. Unit: bytes.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The download URL of a file that is downloaded over the Internet.
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
