// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetObjectRequest : TeaModel {
        /// <summary>
        /// The cache-control header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-cache-control")]
        [Validation(Required=false)]
        public string ResponseCacheControl { get; set; }

        /// <summary>
        /// The content-disposition header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-content-disposition")]
        [Validation(Required=false)]
        public string ResponseContentDisposition { get; set; }

        /// <summary>
        /// The content-encoding header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-content-encoding")]
        [Validation(Required=false)]
        public string ResponseContentEncoding { get; set; }

        /// <summary>
        /// The content-language header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-content-language")]
        [Validation(Required=false)]
        public string ResponseContentLanguage { get; set; }

        /// <summary>
        /// The content-type header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-content-type")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        /// <summary>
        /// The expires header in the response that OSS returns.
        /// </summary>
        [NameInMap("response-expires")]
        [Validation(Required=false)]
        public string ResponseExpires { get; set; }

    }

}
