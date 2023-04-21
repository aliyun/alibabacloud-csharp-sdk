// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCustomizedListHeadersResponseBody : TeaModel {
        /// <summary>
        /// The headers.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<DescribeCustomizedListHeadersResponseBodyHeaders> Headers { get; set; }
        public class DescribeCustomizedListHeadersResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The display type of the header. You can call the `ModifyCustomizedListHeaders` operation to modify the display type of the header.
            /// </summary>
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// The key of the header.
            /// </summary>
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            /// <summary>
            /// The name of the header.
            /// </summary>
            [NameInMap("HeaderName")]
            [Validation(Required=false)]
            public string HeaderName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
