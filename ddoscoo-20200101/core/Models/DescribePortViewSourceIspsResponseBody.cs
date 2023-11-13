// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceIspsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the ISP.
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceIspsResponseBodyIsps> Isps { get; set; }
        public class DescribePortViewSourceIspsResponseBodyIsps : TeaModel {
            /// <summary>
            /// The total number of requests that are sent from the ISP.
            /// 
            /// > This parameter does not indicate the accurate number of requests. You can use this parameter to calculate the proportion of requests from different ISPs.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The ID of the ISP. For more information, see the ISP codes table.
            /// </summary>
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
