// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewTopCostTimeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The URLs which require the longest time to respond to requests.
        /// </summary>
        [NameInMap("UrlList")]
        [Validation(Required=false)]
        public List<DescribeDomainViewTopCostTimeResponseBodyUrlList> UrlList { get; set; }
        public class DescribeDomainViewTopCostTimeResponseBodyUrlList : TeaModel {
            /// <summary>
            /// The response duration. Unit: milliseconds.
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public float? CostTime { get; set; }

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
