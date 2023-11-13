// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHeadersResponseBody : TeaModel {
        /// <summary>
        /// The information about the custom header.
        /// </summary>
        [NameInMap("CustomHeader")]
        [Validation(Required=false)]
        public DescribeHeadersResponseBodyCustomHeader CustomHeader { get; set; }
        public class DescribeHeadersResponseBodyCustomHeader : TeaModel {
            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The header of the response.
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public string Headers { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
