// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewTopUrlResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the URLs that receive the most requests.
        /// </summary>
        [NameInMap("UrlList")]
        [Validation(Required=false)]
        public List<DescribeDomainViewTopUrlResponseBodyUrlList> UrlList { get; set; }
        public class DescribeDomainViewTopUrlResponseBodyUrlList : TeaModel {
            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The URL that is Base64-encoded.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
