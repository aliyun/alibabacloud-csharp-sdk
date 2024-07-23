// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCustomizedListHeadersResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<DescribeCustomizedListHeadersResponseBodyHeaders> Headers { get; set; }
        public class DescribeCustomizedListHeadersResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>display</para>
            /// </summary>
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pay_type</para>
            /// </summary>
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            [NameInMap("HeaderName")]
            [Validation(Required=false)]
            public string HeaderName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
